using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AnigramsProductionsV2.EF;

namespace AnigramsProductionsV2.Controllers
{
    public class ProjectsController : Controller
    {
        private AnigramsEntities db = new AnigramsEntities();

        // GET: Projects
        public ActionResult Index()
        {
            return View(db.AnigramsProjects.ToList());
        }

        // GET: Projects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnigramsProject anigramsProject = db.AnigramsProjects.Find(id);
            if (anigramsProject == null)
            {
                return HttpNotFound();
            }
            return View(anigramsProject);
        }

        public ActionResult Genesis()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
