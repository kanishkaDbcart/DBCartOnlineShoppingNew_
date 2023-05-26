using Microsoft.AspNetCore.Mvc;
using OnlineShoppingProject.BAL;
using OnlineShoppingProject.DAL;
using OnlineShoppingProject.ViewModels.ProductModels;

namespace OnlineShoppingProject.Controllers
{
    public class CartController : Controller
    {
        private CommonImplementationDAL _commonImplementation;
        private CartImplememntationBAL _cartImplementation;
        public CartController(CartImplememntationBAL cartImplementation, CommonImplementationDAL commonImplementation)
        {
            this._cartImplementation = cartImplementation;
            this._commonImplementation = commonImplementation;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CartList()
        {
            var UserName = HttpContext.User.Identity.Name;
            int userId = _commonImplementation.GetTheUserIdDAL(UserName);
            if(userId ==  0)
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
            var model = await _cartImplementation.GetProductCartBAL(userId);
           
            return View(model);
        }
        public async Task<IActionResult> InsertToCart(ProductVM product)
        {

            var UserName = HttpContext.User.Identity.Name;
            int userId = _commonImplementation.GetTheUserIdDAL(UserName);
            if (userId != 0)
            {
                if (await _cartImplementation.InsertCartBAL(product))
                {
                    return RedirectToPage("GetProductCart");
                    // return Json(new { isValid = true, message = "Cart item added successfully." });
                }
                else
                {
                    return Json(new { isValid = false, html = "<h1>failed to submit</h1>" });
                }
            }
            return RedirectToPage("Login", "Login");
        }
    }
}
