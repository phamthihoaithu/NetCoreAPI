using System.ComponentModel.DataAnnotations.Schema;

namespace TEST.Models;
public class DaiLy
{
    public string MaDaiLy { get; set; }
    public string TenDaiLy { get; set; }
    public string DiaChi { get; set; }
    public string NguoiDaiDien {get; set; }
    public string DienThoai { get; set; }
    [ForeignKey("MaHTPP")]
    public string MaHTPP { get; set; }
}