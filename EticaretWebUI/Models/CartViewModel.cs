using Eticaret.Core.Entities;

namespace EticaretWebUI.Models
{
    public class CartViewModel
    {
        public List<CartLine>? CartLines { get; set; }
        public decimal TotalPrice { get; set; }

        
    }
}
