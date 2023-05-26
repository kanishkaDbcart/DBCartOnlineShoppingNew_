using Microsoft.AspNetCore.Mvc;
using OnlineShoppingProject.BAL;


namespace OnlineShoppingProject.Controllers
{
    public class AddressController : Controller
    {
      
        private AddressImplementation AddressImplemenation;

        public AddressController(AddressImplementation AddressImplemenation)
        {
            this.AddressImplemenation = AddressImplemenation;
        }

        public IActionResult GetAddressId(int userId, int Id)
        {

            var buy = AddressImplemenation.GetIDAddressBAL(userId, Id);
            return View();
        }
    }
}
