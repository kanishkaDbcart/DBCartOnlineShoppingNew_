using OnlineShoppingProject.Models;

namespace OnlineShoppingProject.DAL
{
    public class CommonImplementationDAL
    {
        private OnlineShopDbContext _context;

        public CommonImplementationDAL(OnlineShopDbContext Context)
        {
            _context = Context;
        }
        public string GetTheUserIdDAL(string username)
        {
           
            return _context.AspNetUsers.Single(r => r.Email == username).Id;

        }
        //public string GetPassword(string username)
        //{
        //    return _context.TblUsers.Single(r => r.Email == username).Password;

        //}
    }
}
