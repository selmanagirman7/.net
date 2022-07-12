using PersonelApp.Data;
using PersonelApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelApp.UI.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        public ActionResult List()
        {
            using(UnitOfWork uow = new UnitOfWork())
            {
                Departman departman = uow.Departmanlar.GetItem(1);

                //uow.Personeller.Add(new Personel { Ad = "Kişi 1", Soyad = "kişi 1", Departman = departman });
                //uow.Personeller.Add(new Personel { Ad = "Kişi 2", Soyad = "kişi 2", Departman = departman });
                //uow.Personeller.Add(new Personel { Ad = "Kişi 3", Soyad = "kişi 3", Departman = departman });
                //uow.Personeller.Add(new Personel { Ad = "Kişi 4", Soyad = "kişi 4", Departman = departman });

                //uow.Save();

                //return View(departman.Personeller);
                return View(uow.Personeller.GetAllWithDepartman());
            }
        }
    }
}