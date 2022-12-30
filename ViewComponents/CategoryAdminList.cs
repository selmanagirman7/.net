using Business.Concrete;
using DataAccess.Concrete;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebUI.ViewComponents
{
	public class CategoryAdminList:ViewComponent
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
		

		public IViewComponentResult Invoke()
		{
			var result = categoryManager.GetAll().OrderBy(x=>x.CategoryName).ToList();
			return View(result);
		}

	}
}
