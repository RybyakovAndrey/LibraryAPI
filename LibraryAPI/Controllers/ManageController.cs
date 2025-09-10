using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("[customers]")]
    public class ManageController : ControllerBase
    {
        public IActionResult FindCustomerById()
        {
            throw new NotImplementedException();
        }

        public IActionResult FindCustomerByName()
        {
            throw new NotImplementedException();
        }

        public IActionResult AddCustomer()
        {
            throw new NotImplementedException();
        }

        public IActionResult EditCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
