using System.ComponentModel.DataAnnotations;

namespace E_Commerce_MVC.PL.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }

        public ICollection<Cart> Carts { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
