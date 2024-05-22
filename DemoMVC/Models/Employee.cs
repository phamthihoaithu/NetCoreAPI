using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models;
public class Employee : Person
{
    public string EployeeId { get; set; }
    public int Age { get; set; }
}