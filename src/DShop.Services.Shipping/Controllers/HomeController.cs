using Microsoft.AspNetCore.Mvc;

namespace DShop.Services.Shipping.Controllers
{
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get() => Ok("DShop Shipping Service");
    }
}