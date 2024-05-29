using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models;
public class DaiLy 
{
    [Key]
    public string MaDaiLy {get; set;}
    public string TenDaiLy {get; set;}
    public string DiaChi {get; set;}
    public string NguoiDaiDien {get; set;}
    public string SoDienThoai {get; set;}
     [ForeignKey("MaHTPP")]
    public string? MaHTPP {get; set;}

}
