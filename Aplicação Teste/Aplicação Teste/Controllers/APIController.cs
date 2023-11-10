using Microsoft.AspNetCore.Mvc;

namespace Aplicação_Teste.Controllers
{
    [Route("API/[controller]")]
    [ApiController]
    public class Calculos : ControllerBase
    {
        [HttpGet("Somar")]
        public String somar (Int16 num1, Int16 num2)
        {
            return (num1 + num2).ToString();
        }

        [HttpGet("Subrair")]
        public String subtrair (Int16 num1, Int16 num2)
        {
            return (num1 - num2).ToString();
        }
    }
}
