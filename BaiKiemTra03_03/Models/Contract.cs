using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiKiemTra03_03.Models
{
    public class Contract
    {
        [Key]
        public int contract_id { get; set; }
        [Required(ErrorMessage = "Không được để trông tên")]
        public string contract_name { get; set; }
        [Required(ErrorMessage = "Không được để trông ngày kí kết")]
        public DateTime signing_date { get; set; }
        [Required(ErrorMessage = "Không được để trông giá trị hợp đồng")]
        public string contact_value { get; set; }

        [ForeignKey("Customer")]
        [ValidateNever]
        public  Customer customer { get; set; }
       
    }
}
