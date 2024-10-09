using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_03.Models
{
    public class Customer
    {
        [Key]
        public int customer_Id { get; set; }
        [Required(ErrorMessage = "Không được để trông tên")]
		[Display(Name = "Tên khách hàng")]
		public string customer_name { get; set; }
        [Required(ErrorMessage = "Không được để trông địa chỉ")]
		[Display(Name = "Địa chỉ")]
		public string address { get; set; }
        [Required(ErrorMessage = "Không được để trông số điện thoại")]
		[Display(Name = "Số điện thoại")]
		public int phone_number { get; set; }
        [Required(ErrorMessage = "Không được để trông email")]
		[Display(Name = "Email")]
		public string email { get; set; }
    }
}
