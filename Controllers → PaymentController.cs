using System.Web.Mvc;
using PaymentSystem.Models;

namespace PaymentSystem.Controllers
{
    public class PaymentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Process(Payment pay)
        {
            ViewBag.Message = "Payment Successful!";
            ViewBag.Amount = pay.Amount;

            return View("Success");
        }
    }
}
