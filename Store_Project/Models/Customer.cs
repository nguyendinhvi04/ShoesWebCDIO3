using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Store_Project.Models
{
    public  class Customer
    {
   
        [Key]
        public int Id {get; set;}
        [DisplayName("Họ Tên")]
       public string? FullName { get; set;}
        [DisplayName("Ngày Sinh")]
        public DateTime Birthday { get; set;}
        [DisplayName("Địa Chỉ")]
        public string? Address { get; set;}
        [DisplayName("Số Điện Thoại")]
        public string? Phone { get; set;}
        [ForeignKey("User")]
        public int UserId { get; set;}

        public virtual User? User { get; set;}
	}
}
