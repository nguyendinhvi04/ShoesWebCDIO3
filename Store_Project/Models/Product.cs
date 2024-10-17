using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Store_Project.Models
{
    public class Product
    {
       

        [Key]
        public int Id { get; set; }
        [DisplayName("Tên Sản Phẩm")]
        public string? Name { get; set; }
        [DisplayName("Mô Tả")]
        public string? Description {  get; set; }
        [DisplayName("Giá")]
        public decimal Price { get; set; }
        [DisplayName("Số Lượng")]
        public int Quantity { get; set; }
        public string? ImageUrl {  get; set; }

       


        [ForeignKey("Category")]
        public int CategoryId {  get; set; }
       public virtual Category? Category { get; set; }
    }
}
