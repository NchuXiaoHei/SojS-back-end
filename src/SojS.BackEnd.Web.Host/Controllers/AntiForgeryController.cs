using Microsoft.AspNetCore.Antiforgery;
using SojS.BackEnd.Controllers;

namespace SojS.BackEnd.Web.Host.Controllers
{
    public class AntiForgeryController : BackEndControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
