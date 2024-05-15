using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace BTTH.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}