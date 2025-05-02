using System.ComponentModel.DataAnnotations;

namespace E_Commerce_MVC.PL.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
