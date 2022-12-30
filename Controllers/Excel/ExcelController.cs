using DataAccess;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;

namespace WebUI.Controllers.Excel
{
    [AllowAnonymous]
    public class ExcelController : Controller
    {
        Vega vega = new Vega();
        private readonly IConfiguration configuration;
        private readonly ILogger<ExcelController> logger;
        Context context = new Context();
        public ExcelController(IConfiguration configuration, ILogger<ExcelController> logger)
        {
            this.configuration = configuration;
            this.logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ImportExcel()
        {
            return View();
        }



        [HttpPost]
        public IActionResult ImportExcel(IFormFile formFile)
        {
            try
            { 
                if ( formFile.Length > 0)
                {

                    var mainPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "UploadExcelFile");
                    if (!Directory.Exists(mainPath))
                    {
                        Directory.CreateDirectory(mainPath);
                    }

                    var fileName = formFile.FileName;
                    string extension = Path.GetExtension(fileName);
                    string newName = new DateTime().Date.ToString("dd-mm-yyyy-hh-MM-ss") + extension;
                    var filePath = Path.Combine(mainPath, newName);
                    using (FileStream stream = new FileStream(filePath, FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }
                    string conString = string.Empty;
                    switch (extension)
                    {
                        case ".xls":
                            conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + filePath + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=2\\'";
                            break;
                        case ".xlsx":
                            conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="+filePath+ ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=2\\'";
                            break;
                    }

                    DataTable dt = new DataTable();
                    conString = string.Format(conString, filePath);
                    using (OleDbConnection conExcel = new OleDbConnection(conString))
                    {
                        using (OleDbCommand cmdExcel = new OleDbCommand())
                        {
                            using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                            {
                                cmdExcel.Connection = conExcel;
                                conExcel.Open();
                                DataTable dtExcelSchema = conExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                                string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                                cmdExcel.CommandText = "SELECT * FROM [" + sheetName + "]";
                                odaExcel.SelectCommand = cmdExcel;
                                odaExcel.Fill(dt);
                                conExcel.Close();

                            }
                        }
                    }


                    conString = configuration.GetConnectionString("DefaultConnection");
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            sqlBulkCopy.DestinationTableName = "VegaProducts";
                            sqlBulkCopy.ColumnMappings.Add("Stok", "Stok");
                            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                            sqlBulkCopy.ColumnMappings.Add("Iskonto", "Iskonto");
                            sqlBulkCopy.ColumnMappings.Add("Price", "Price");
                            sqlBulkCopy.ColumnMappings.Add("MonyTyp", "MonyTyp");
                            sqlBulkCopy.ColumnMappings.Add("CategoryName", "CategoryName");
                            sqlBulkCopy.ColumnMappings.Add("ImageUrl", "ImageUrl");
                            sqlBulkCopy.ColumnMappings.Add("CategoryId", "CategoryId");
                            sqlBulkCopy.ColumnMappings.Add("KeyWords", "KeyWords");

                            con.Open();

                 
                            sqlBulkCopy.WriteToServer(dt);
                            con.Close();
                        }
                    }

                    ViewBag.massage = "File Import successfully, data saved into database";

                    return RedirectToAction("Index","Product");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                string msg=ex.Message;  
            }

            return View();

           
        }

    }
}





