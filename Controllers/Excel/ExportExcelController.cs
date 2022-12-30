using Business.Concrete;
using ClosedXML.Excel;
using DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebUI.Models.Excel;

namespace WebUI.Controllers.Excel
{
    [AllowAnonymous]

    public class ExportExcelController : Controller
    {
        IVegaDal _vegaDal;

        VegaManager vegaManager = new VegaManager(new EfVegaDal());

        public IActionResult ExportExcelList()
        {

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Celebi");
                worksheet.Cell(1, 1).Value = "Stok";
                worksheet.Cell(1, 2).Value = "Name";
                worksheet.Cell(1, 3).Value = "Iskonto";
                worksheet.Cell(1, 4).Value = "Price";
                worksheet.Cell(1, 5).Value = "MonyTyp";
                worksheet.Cell(1, 6).Value = "CategoryName";
                worksheet.Cell(1, 7).Value = "ImageUrl";
                worksheet.Cell(1, 8).Value = "CategoryId";
                worksheet.Cell(1, 9).Value = "KeyWords";

                int VegaRowCount = 2;
                foreach (var item in GetVegaList())
                {
                    worksheet.Cell(VegaRowCount, 1).Value = item.Stok;
                    worksheet.Cell(VegaRowCount, 2).Value = item.Name;
                    worksheet.Cell(VegaRowCount, 3).Value = item.Iskonto;
                    worksheet.Cell(VegaRowCount, 4).Value = item.Price;
                    worksheet.Cell(VegaRowCount, 5).Value = item.MonyTyp;
                    worksheet.Cell(VegaRowCount, 6).Value = item.CategoryName;
                    worksheet.Cell(VegaRowCount, 7).Value = item.ImageUrl;
                    worksheet.Cell(VegaRowCount, 8).Value = item.CategoryId;
                    worksheet.Cell(VegaRowCount, 9).Value = item.KeyWords;
                    VegaRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "CelebiHirdavat.xlsx");
                }

            }

            return View();
        }

        public List<ExportModel> GetVegaList()
        {
            List<ExportModel> exportList = new List<ExportModel>();

            using (var ct =new Context() )
            {
                exportList = ct.VegaProducts.Select(x => new ExportModel
                {
                    Stok = x.Stok,
                    Name = x.Name,
                    Iskonto= x.Iskonto,
                    Price=x.Price,
                    MonyTyp=x.MonyTyp,
                    CategoryName=x.CategoryName,
                    ImageUrl=x.ImageUrl,
                    CategoryId=x.CategoryId,    
                    
                    KeyWords=x.KeyWords
                }).ToList();
            }
            return exportList;
                


                
            return exportList;
        }


        public IActionResult ExportExcelListCategory(int id)
        {

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Celebi");
                worksheet.Cell(1, 1).Value = "Stok";
                worksheet.Cell(1, 2).Value = "Name";
                worksheet.Cell(1, 3).Value = "Iskonto";
                worksheet.Cell(1, 4).Value = "Price";
                worksheet.Cell(1, 5).Value = "MonyTyp";
                worksheet.Cell(1, 6).Value = "CategoryName";
                worksheet.Cell(1, 7).Value = "ImageUrl";
                worksheet.Cell(1, 8).Value = "CategoryId";
                worksheet.Cell(1, 9).Value = "KeyWords";

                int VegaRowCount = 2;
                foreach (var item in vegaManager.GetByCategory(id))
                {
                    worksheet.Cell(VegaRowCount, 1).Value = item.Stok;
                    worksheet.Cell(VegaRowCount, 2).Value = item.Name;
                    worksheet.Cell(VegaRowCount, 3).Value = item.Iskonto;
                    worksheet.Cell(VegaRowCount, 4).Value = item.Price;
                    worksheet.Cell(VegaRowCount, 5).Value = item.MonyTyp;
                    worksheet.Cell(VegaRowCount, 6).Value = item.CategoryName;
                    worksheet.Cell(VegaRowCount, 7).Value = item.ImageUrl;
                    worksheet.Cell(VegaRowCount, 8).Value = item.CategoryId;
                    worksheet.Cell(VegaRowCount, 9).Value = item.KeyWords;
                    VegaRowCount++;
                }


                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "CelebiHirdavat.xlsx");
                }

            }

            return View();
        }



        public IActionResult VegaListExcel()
        {
            return View();
        }
    }
}
