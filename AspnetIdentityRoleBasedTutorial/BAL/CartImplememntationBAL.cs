using OnlineShoppingProject.DAL;
using OnlineShoppingProject.ViewModels.ProductModels;

namespace OnlineShoppingProject.BAL
{
    public class CartImplememntationBAL
    {
        private CartImplememntationDAL _cartImplementation;
        public CartImplememntationBAL(CartImplememntationDAL cartImplementation)
        {
            this._cartImplementation = cartImplementation;
        }
        public async Task<AddProductCartVM> GetProductCartBAL(string Id)
        {
            return new AddProductCartVM
            {
                TblCarts = await _cartImplementation.GetAllProductCart(Id)
            };

        }
        public async Task<bool> InsertCartBAL(ProductVM product)
        {
            return await _cartImplementation.AddToCart(product);

        }
    }
}
