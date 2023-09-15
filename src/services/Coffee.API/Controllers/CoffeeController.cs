using Microsoft.AspNetCore.Mvc;

namespace Coffee.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        private static readonly string[] Coffees = new[]
        {
        "Nutty"
        ,"Chocolatey"
        ,"Fruity"
        ,"Floral"
        ,"Spicy"
        ,"Earthy"
        ,"Caramel"
        ,"Smoky"
        ,"Nutritional"
        ,"Herbal"
    };

        [HttpGet]
        public IActionResult Get()
        {
            var rnd = new Random();

            return Ok(Coffees[rnd.Next(Coffees.Length)]);
        }
    }
}
