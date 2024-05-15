using BTTH.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace BTTH.Controllers;

public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index (Person ps)
    {
        string strResult = "Xin chao " + ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
        ViewBag.Person = strResult;
        return View();
    }
}