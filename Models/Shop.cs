using System.ComponentModel.DataAnnotations;

namespace WebApiDayOne.Models
{
    public class Shop
    {

        [Range(1,1000,ErrorMessage ="Invalid {0},Range between {1} and {2}")]
        public int Id { get; set; }

        [StringLength(10,MinimumLength =3,ErrorMessage ="Your String must be between 3 and 10.")]
        public string? Name { get; set; }    

        public DateTime OpenDate { get; set; }



    }
}
