using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ppl.Controllers;

namespace ppl.Web.Mvc.Controllers
{
    public class ApiController : pplControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("api/login")]
        public IActionResult Login()
        {
            return new JsonResult("s");
        }
    }
}