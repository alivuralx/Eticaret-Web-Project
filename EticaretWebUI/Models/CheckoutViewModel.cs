using Eticaret.Core.Entities;

namespace EticaretWebUI.Models
{
    public class CheckoutViewModel
    {
        public List<CartLine>? CartProducts { get; set; }
        public decimal TotalPrice { get; set; }
        public List<Address>? Addresses { get; set; }
    }
}
