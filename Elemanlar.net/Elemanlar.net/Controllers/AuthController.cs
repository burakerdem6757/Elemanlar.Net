using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Elemanlar.net.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        [Route("signin")]
        public IActionResult SignIn()
        {
            return Challenge(new AuthenticationProperties { RedirectUri = "/" });
        }
    }
}
