namespace E_Commerce_MVC.PL.Models
{
    public class ProductBase
    {
        public ICollection<Cart> Carts { get; set; }
    }
}