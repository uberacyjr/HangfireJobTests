using Hangfire.EF;
using Hangfire.EF.Models;
using System.Web.Mvc;

namespace Hangfire.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public JsonResult FirstJob()
        {
            //fire and forget
            //execute only once and immediately
            BackgroundJob.Enqueue(() => AddPessoa());
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public void AddPessoa()
        {
            using (var ctx = new Context())
            {
                System.Threading.Thread.Sleep(millisecondsTimeout: 10000);
                ctx.Pessoa.Add(new Pessoa { Nome = "BERA" });
                ctx.SaveChanges();
            }
        }
    }
}