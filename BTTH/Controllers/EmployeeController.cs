using BTTH.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace BTTH.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index (Employee ep)
    {
        string strResult = "Xin chao " + ep.EmployeeId + "-" + ep.Age;
        ViewBag.Info = strResult;
        return View();
    }
}