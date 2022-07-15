using Microsoft.AspNetCore.Mvc;

namespace EmailSender.API.Controllers
{
    [ApiController]
    public class EmailSenderController : Controller
    {
        [HttpGet]
        [Route("/emailSender/api/v1/sendEmail")]
        public async Task<IActionResult> SendEmail()
        {
            return Ok(new 
            {
                Email = "EmailTeste@gmail.com.br",
                Teste = "TesteAqui"
            }); ;
        }
    }
}
