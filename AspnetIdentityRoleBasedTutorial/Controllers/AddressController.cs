using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingProject.BAL;
using OnlineShoppingProject.Models;

namespace OnlineShoppingProject.Controllers
{
    public class AddressController : Controller
    {

        private OnlineShopDbContext _context;
        private AddressImplementation AddressImplemenation;

        public AddressController(AddressImplementation AddressImplemenation, OnlineShopDbContext context)
        {
            this.AddressImplemenation = AddressImplemenation;
            this._context = context;
        }

        public IActionResult GetAddressId(int id)
        {
            var userName =HttpContext.User.Identity.Name;
            var userId = _context.AspNetUsers.Single(r => r.Email == userName).Id;


            var buy = AddressImplemenation.GetIDAddressBAL(userId, id);
            return View();
        }


        //public IActionResult GetAddressId()
        //{
        //    return View();
        //}
    }
}
