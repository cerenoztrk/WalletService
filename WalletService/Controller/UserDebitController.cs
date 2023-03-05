using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalletService.Models;

namespace WalletService.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDebitController : ControllerBase
    {
        [HttpGet]

        public ActionResult<List<VUserDebit>> Index()
        {
            WalletContext ctx = new WalletContext();

            return ctx.VUserDebits.ToList();
            
        }
       

       
    }
}
