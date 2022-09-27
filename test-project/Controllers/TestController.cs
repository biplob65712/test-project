using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace test_project.Controller
{
    public class TestController : ControllerBase
    {
        // GET: TestController
        public ActionResult Index()
        {
            return View();
        }        
    }
}
