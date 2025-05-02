using System.ComponentModel.DataAnnotations;

namespace E_Commerce_MVC.PL.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public DateTime PayDate { get; set; }
        public string PayMethod { get; set; }
    }
}
