using System.ComponentModel.DataAnnotations;

namespace QuanlyNguoiDung.Models
{
    public class User
    {
        [Key]
        [Display(Name = "Mã ")]
        public int MaND { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày sinh")]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày Sinh")]
        public DateTime NgaySinh { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Email")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [RegularExpression(@"^(0[3|5|7|8|9])+([0-9]{8})\b", ErrorMessage = "Số điện thoại không hợp lệ")]
        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
    }
}
