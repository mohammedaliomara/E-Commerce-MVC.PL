using System.ComponentModel.DataAnnotations;

namespace E_Commerce_MVC.PL.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime CreationDate { get; set; }

       // public ICollection<OrderPayment> OrderPayments { get; set; }
    }
}
