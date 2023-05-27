using OnlineShoppingProject.DAL;
using OnlineShoppingProject.Models;
using OnlineShoppingProject.ViewModels;

namespace OnlineShoppingProject.BAL
{
    public class AddressImplementation
    {
        private AddressImplementationDAL addressImplementationDAL;
        public AddressImplementation(AddressImplementationDAL addressImplementationDAL)
        {
            this.addressImplementationDAL = addressImplementationDAL;
        }

        public List<AddressVM> GetIDAddressBAL(string CreatedBy, int ProductId)
        {
            return addressImplementationDAL.GetIDAddressDAL(CreatedBy,ProductId);
        }


    }
}
