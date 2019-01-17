using Microsoft.AspNetCore.Antiforgery;
using ppl.Controllers;

namespace ppl.Web.Host.Controllers
{
    public class AntiForgeryController : pplControllerBase
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
        public AntiforgeryTokenSet SetToken()
        {
            return _antiforgery.GetTokens(HttpContext);
        }
    }
}
