using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDayOne.Models;

namespace WebApiDayOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {

        private readonly List<Shop> _shops= new();

        [HttpPost]
        public ActionResult AddShop(Shop newShop) {



          _shops.Add(newShop);

            return StatusCode(StatusCodes.Status201Created);
        
        }



    }
}
