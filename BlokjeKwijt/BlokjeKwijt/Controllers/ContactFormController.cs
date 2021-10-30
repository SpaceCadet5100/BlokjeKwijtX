using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlokjeKwijt.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlokjeKwijt.Controllers
{
    public class ContactFormController : Controller
    {
        // GET: ContactFormController
        public ActionResult Index()
        {
            using(var ctx = new BlokjeKwijtContext())
            {
                return View(ctx.ContactForms.Include
                    (u => u.User).ToList());
            }
        }

        // GET: ContactFormController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactFormController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactForm model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new BlokjeKwijtContext())
                    {
                        ctx.ContactForms.Add(model);
                        ctx.SaveChanges();
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        // GET: ContactFormController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                using (var ctx = new BlokjeKwijtContext())
                {
                    return View(ctx.ContactForms.Include
                    (u => u.User).FirstOrDefault(b => b.ID == id));
                }
            }
            catch
            {
                return View();
            }
        }

        // POST: ContactFormController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ContactForm model)
        {
            try
            {
                using (var ctx = new BlokjeKwijtContext())
                {
                    ctx.ContactForms.Remove(model);
                    ctx.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
