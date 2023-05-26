using OnlineShoppingProject.Models;

namespace OnlineShoppingProject.ViewModels
{
    public class AddressVM
    {
        public int AddressId { get; set; }

        public int ProductId { get; set; }

        public string? DeliverAddress { get; set; }

        public short Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedBy { get; set; }


        public List<TblAddress>? TblProducts { get; set; } = new List<TblAddress>();
    }
}
