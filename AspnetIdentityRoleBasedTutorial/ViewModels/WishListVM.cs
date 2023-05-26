using OnlineShoppingProject.Models;
using OnlineShoppingProject.ViewModels.ProductModels;

namespace OnlineShoppingProject.ViewModels
{
	public class WishListVM : ProductVM
	{
	    public int id { get; set; }
		public List<TblWishList>? tblWishLists { get; set; } = new List<TblWishList>();
	}
}
