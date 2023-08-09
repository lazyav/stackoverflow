using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SendEmail([FromBody] EmailRequest request)
        {
            await Task.Delay(100);
            string email = request.Email;
            return Ok(new { Success = true, Message = "Email received and processed successfully." });

        }
        public class EmailRequest
        {
            private string email = "";
            public string Email { get => email; set => email = value ?? ""; }

        }
    }
}
