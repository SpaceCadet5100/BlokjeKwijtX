using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlokjeKwijt.Domain;
using System.Data.Entity.Validation;

namespace BlokjeKwijt.Controllers
{
    public class BlokjeColorController : Controller
    {
        // GET: BlokjeColorController
        public ActionResult Index()
        {

            using(var ctx = new BlokjeKwijtContext())
            {
                return View(ctx.BlokjeColors.ToList());
            }
        }


        // GET: BlokjeColorController/Create
        public ActionResult Create()
        {
            using (var ctx = new BlokjeKwijtContext())
            {
                ViewBag.selection = ctx.BlokjeColors.ToList();
            }
            return View();
        }

        // POST: BlokjeColorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BlokjeColor source)
        {
            try
            {
                if (ModelState.IsValid) { 
                    using (var ctx = new BlokjeKwijtContext())
                    {
                        ctx.BlokjeColors.Add(source);
                        ctx.SaveChanges();
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(source);
            }

            catch
            {
                return View(source);
            }
        }

        // GET: BlokjeColorController/Edit/5
        public ActionResult Edit(int id)
        {
            BlokjeColor temp;
            try
            {
                using (var ctx = new BlokjeKwijtContext())
                {
                  temp = ctx.BlokjeColors.FirstOrDefault(selection => selection.ID == id);
                }
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
            return temp == null ? RedirectToAction(nameof(Index)) : View(temp);
        }

        // POST: BlokjeColorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BlokjeColor source)
        {
            BlokjeColor temp;
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new BlokjeKwijtContext())
                    {
                        temp = ctx.BlokjeColors.FirstOrDefault(selection => selection.ID == id);
                        ctx.Entry(temp).CurrentValues.SetValues(source);
                        ctx.SaveChanges();
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(source);
            }
            catch
            {
                return View(source);
            }
        }
    }
}
