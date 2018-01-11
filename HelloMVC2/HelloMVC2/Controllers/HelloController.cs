using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC2.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var text = "<form method='post'>" +
                "<input type='text' name = 'name' /> " +
                "<select name='select'>" +
                "<option value='english'>English</option>" +
                "<option value='french'>French</option>" +
                "<option value='german'>German</option>" +
                "</select>" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";

            return Content(text, "text/html");
        }
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        // Handle requests to /Hello/NAME (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }


        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }

        [HttpPost]
        public IActionResult Index(string name, string language)
        {
            //something
            return Content("well...");
        }

    }
}
