using System.ComponentModel.DataAnnotations;
namespace BTTH.Models;
public class HeThongPhanPhoi
{
    [Key]
    public string MaHTPP {get; set;}
    public string TenHTPP {get; set;}
    public ICollection<DaiLy>? DaiLy {get; set;}
}