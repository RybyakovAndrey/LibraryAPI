using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("[book]")]
    public class BookController : ControllerBase
    {
        public IActionResult ShowBookDetails()
        {
            throw new NotImplementedException();
        }

    }
}
