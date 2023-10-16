using Microsoft.AspNetCore.Mvc;
using WebApiDayOne.Model;

namespace WebApiDayOne.Controllers
{

    [ApiController]
    [Route("api/controllers")]
    public class MobilesControllers : ControllerBase
    {

        private static List<Mobile> _mobiles = new List<Mobile>() { new Mobile(1,"iphone","1","1000$"),
           new Mobile(2,"samsung","2","1000$"),
         new Mobile(3,"xiamoi","2","1000$"),
         new Mobile(4,"blackberry","3","1000$"),

        };

        [HttpGet]
        public ActionResult<List<Mobile>> Mobiles() {

            if (_mobiles == null) {
                return NotFound();
            }

            return _mobiles;
        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult<Mobile> GetMobile(int id) {
            var MobileFound = _mobiles.FirstOrDefault(f => f.Id == id);
            if (MobileFound is null) {
                return NotFound();
            }

            return MobileFound;
        }

        [HttpPost]
        public ActionResult PostMobile(Mobile mobile) {

            _mobiles.Add(mobile);

            return StatusCode(StatusCodes.Status201Created, "added");//=> Content

        }



        [HttpPut]
        [Route("{id}")]
        public ActionResult EditMobile(int id, Mobile newmobile) {

            Mobile MobileFounded = _mobiles.Find(f => f.Id == id);

            if (id != newmobile.Id) {
                return BadRequest();
            }


            if (MobileFounded is null) {
                return StatusCode(StatusCodes.Status404NotFound, "Not Found");
            }
            MobileFounded.Name = newmobile.Name;
            MobileFounded.Price = newmobile.Price;
            MobileFounded.Model = newmobile.Model;

            return Content("Edited");

        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteMobile(int? id) { 
        
        var found=_mobiles.First(f => f.Id == id);

            if (found is null) {
                return NotFound();
            }
            _mobiles.Remove(found);
            return StatusCode(StatusCodes.Status204NoContent,"Deleted");

        
        }



    }
}
