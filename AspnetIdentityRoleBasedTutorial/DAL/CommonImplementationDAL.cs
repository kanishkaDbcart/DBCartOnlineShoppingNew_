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
        public int GetTheUserIdDAL(string username)
        {
            if (username == null)
            {
                var userId = 0;
                return userId;
            }
            return _context.AspNetUsers.Single(r => r.Email == username).UserId;

        }
        //public string GetPassword(string username)
        //{
        //    return _context.TblUsers.Single(r => r.Email == username).Password;

        //}
    }
}
