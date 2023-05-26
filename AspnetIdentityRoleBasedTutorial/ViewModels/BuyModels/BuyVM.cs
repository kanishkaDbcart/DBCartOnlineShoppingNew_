using OnlineShoppingProject.Models;


namespace OnlineShoppingProject.ViewModels.BuyModels
{
    public class BuyVM
    {
        public int BuyNowId { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }

        public int PayementTypes { get; set; }

        public decimal Quantity { get; set; }

        public decimal Rate { get; set; }

        public decimal TotalAmount { get; set; }
        public int CreatedBy { get; set; }


        public List<TblBuyNow>? TblBuyNow { get; set; } = new List<TblBuyNow>();

    }
}
