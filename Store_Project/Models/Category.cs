using System.ComponentModel.DataAnnotations;

namespace Store_Project.Models
{
    public  class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

    }
}
