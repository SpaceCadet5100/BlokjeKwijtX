using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlokjeKwijt.Domain;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace BlokjeKwijt.Controllers
{
    public class MatchController : Controller
    {
        public IActionResult Index()
        {

            using (var ctx = new BlokjeKwijtContext())
            {
                dynamic model = new ExpandoObject();
                model.UserHasExtraBricks = ctx.UserHasExtraBricks.Include(u => u.User).ToList();
                model.UserHasMissingBricks = ctx.UserHasMissingBricks.Include(u => u.User).ToList();
                return View(model);
            }
        }
    }
}
