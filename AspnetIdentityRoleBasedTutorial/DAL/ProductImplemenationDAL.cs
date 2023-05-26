using Microsoft.EntityFrameworkCore;
using OnlineShoppingProject.Models;

namespace OnlineShoppingProject.DAL
{
    public class ProductImplemenationDAL
    {
        private OnlineShopDbContext _context;

        public ProductImplemenationDAL(OnlineShopDbContext Context)
        {
            _context = Context;
        }

        public async Task<List<TblProduct>> GetListOfProducts()
        {
            return await _context.TblProducts.Select(r => r).ToListAsync();
        }

    }
}
