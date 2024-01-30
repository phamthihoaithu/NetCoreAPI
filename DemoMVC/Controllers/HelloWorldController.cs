namespace DemoMVC.Controllers;

public class HelloWorldController : Controllers
{
    public IActionResult Index()
    {
        return View();
    }
}

