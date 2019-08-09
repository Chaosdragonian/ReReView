using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ReReView.DAL;
using System.Text;

namespace ReReView.Controllers
{
    public class RankandrecentController : Controller
    {
        private ReReViewContext db = new ReReViewContext();
        // GET: Rankandrecent
        public ActionResult Index()
        {
            var model = new RankandrecentViewModel();
            
            model.Rankrestuarants = (from r in db.Restuarants orderby r.star descending select r).Take(4); ;
            model.Recentreviews = (from r in db.Reviews orderby r.reviewID descending select r).Take(4);
            return View(model);
        }
    }
}