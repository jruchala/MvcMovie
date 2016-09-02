using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }
        // public string Index()
        // {
        //    return "This is my <b>default</b> action...";
        // }
        
        //
        // GET: /HelloWorld/Welcome/

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            // return "This is the Welcome action method..."; 
            // return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
            // return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}