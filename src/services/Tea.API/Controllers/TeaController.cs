using Microsoft.AspNetCore.Mvc;

namespace Tea.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new[]
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

            return Ok(Teas[rnd.Next(Teas.Length)]);
        }
    }
}
