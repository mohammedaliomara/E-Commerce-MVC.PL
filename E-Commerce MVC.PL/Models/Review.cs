using E_Commerce.Data.DataOrEntity;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_MVC.PL.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public bool IsConfirmed { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
