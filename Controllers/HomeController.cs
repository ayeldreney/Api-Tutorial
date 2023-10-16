using Faker;
using Microsoft.AspNetCore.Mvc;
using WebApiDayOne.Models;
using WebApiDayOne.DataSource;

namespace WebApiDayOne.Controllers
{

    [ApiController]
    [Route("api/controller")]
    public class HomeController : ControllerBase
    {
    
     

        [HttpGet]
        public ActionResult<List<UserProfile>> Index()
        {

            return new List<UserProfile>() {
            LoadUsers.genUsers(),
            LoadUsers.genUsers(), 
            LoadUsers.genUsers(),
            LoadUsers.genUsers(),
            LoadUsers.genUsers(),
            LoadUsers.genUsers(),
            LoadUsers.genUsers(),
            LoadUsers.genUsers(),
            LoadUsers.genUsers(),};

        }
    }
}
