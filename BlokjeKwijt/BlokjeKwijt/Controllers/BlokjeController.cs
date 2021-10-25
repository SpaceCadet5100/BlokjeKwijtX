using BlokjeKwijt.Domain;
using BlokjeKwijt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlokjeKwijt.Controllers
{
    public class BlokjeController : Controller
    {
        // GET: BlokjeController
        public ActionResult Index()
        {
            using (var ctx = new BlokjeKwijtContext())
            {
                return View(ctx.Blokjes.Include
                    (b => b.Color)
                        .ToList());
            }
        }

        // GET: BlokjeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlokjeController/Create
        public ActionResult Create()
        {
            using (var ctx = new BlokjeKwijtContext())
            {
                ViewBag.ColorSelection = ctx.BlokjeColors.ToList();


            }
            return View();
        }

        // POST: BlokjeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BlokjeViewModel source)
        {
            using (var ctx = new BlokjeKwijtContext())
            {
                ViewBag.ColorSelection = ctx.BlokjeColors.ToList();
            }
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new BlokjeKwijtContext())
                    {
                        var b = source.Blokje;
                        b.Color = ctx.BlokjeColors.Find(source.ColorID);

                        ctx.Blokjes.Add(b);
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

        // GET: BlokjeController/Edit/5
        public ActionResult Edit(int id)
        {
            Blokje temp;
            try
            {
                using (var ctx = new BlokjeKwijtContext())
                {
                    temp = ctx.Blokjes.FirstOrDefault(selection => selection.ID == id);
                }
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
            return temp == null ? RedirectToAction(nameof(Index)) : View(temp);
        }

        // POST: BlokjeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Blokje source)
        {
            Blokje temp;
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new BlokjeKwijtContext())
                    {
                        temp = ctx.Blokjes.FirstOrDefault(selection => selection.ID == id);
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

        // GET: BlokjeController/Delete/5
        public ActionResult Delete(int id)
        {
            Blokje temp;
            try
            {
                if (ModelState.IsValid)
                {
                    using (var ctx = new BlokjeKwijtContext())
                    {
                        temp = ctx.Blokjes.FirstOrDefault(selection => selection.ID == id);
                        if (temp != null)
                        {
                            ctx.Blokjes.Remove(temp);
                            ctx.SaveChanges();
                        }
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: BlokjeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
