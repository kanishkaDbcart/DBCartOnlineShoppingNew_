using OnlineShoppingProject.Models;

namespace OnlineShoppingProject.ViewModels.ProductModels
{
    public class AddProductCartVM
    {
        public int AddCartProductId { get; set; }

        public int? ProductMasterId { get; set; }

        public decimal Quantity { get; set; }

        public decimal Rate { get; set; }

        public int Status { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int CreatedById { get; set; }

        public int? ModifiedById { get; set; }

        public List<TblCart>? TblCarts { get; set; } = new List<TblCart>();


    }
}
