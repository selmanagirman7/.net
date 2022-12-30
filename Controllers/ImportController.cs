using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace WebUI.wwwroot
{
    [AllowAnonymous]
    public class ImportController : Controller
    {

        private readonly IConfiguration configuration;

        public ImportController(IConfiguration configuration)
        {
            this.configuration = configuration;

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
                if (formFile.Length > 0)
                {

                    var mainPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ExcelFiles");
                    if (!Directory.Exists(mainPath))
                    {
                        Directory.CreateDirectory(mainPath);
                    }
                    var filePath = Path.Combine(mainPath, formFile.FileName);
                    using (FileStream stream = new FileStream(filePath, FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }

                    var fileName = formFile.FileName;
                    string extension = Path.GetExtension(fileName);
                    string conString = string.Empty;
                    switch (extension)
                    {
                        case ".xls":
                            conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + filePath + ";Extended Properties='Excel 8.0;HDR=Yes'";
                            break;
                        case ".xlsx":
                            conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + filePath + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=2\\'";
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
                            sqlBulkCopy.ColumnMappings.Add("Price", "Price");
                            sqlBulkCopy.ColumnMappings.Add("Adet", "Adet");
                            sqlBulkCopy.ColumnMappings.Add("Kdv", "Kdv");
                            sqlBulkCopy.ColumnMappings.Add("ImageUrl", "ImageUrl");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dt);
                            con.Close();
                        }
                    }

                    ViewBag.massage = "File Import successfully, data saved into database";

                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }

            return View();


        }
    }
}
