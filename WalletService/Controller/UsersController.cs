using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalletService.Models;

namespace WalletService.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]

        public ActionResult<List<VUser>> Index()
        {
            WalletContext ctx = new WalletContext();

            return ctx.VUsers.ToList();
        }
       
        
    }
}
