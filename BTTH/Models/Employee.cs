using System.ComponentModel.DataAnnotations;
namespace BTTH.Models;
public class Employee:Person
{
    public string? EmployeeId {get; set;}
    public int? Age {get; set;}
}