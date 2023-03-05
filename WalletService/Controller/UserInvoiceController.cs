using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalletService.Models;

namespace WalletService.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInvoiceController : ControllerBase
    {
        [HttpGet]

        public ActionResult<List<VUserInvoice>> Index()
        {
            WalletContext ctx = new WalletContext();

            return ctx.VUserInvoices.ToList();

        }
    }
}
