using FreeCourse.Services.Payment.Models;
using FreeCourse.Shared.Base;
using FreeCourse.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FreeCourse.Services.Payment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : CustomBaseController
    {
        [HttpPost]
        public IActionResult ReceivePayment(PaymentDto paymentDto)
        {
            // paymentDto ile ödeme işlemi
            return CreateActionResultInstance(Response<NoContent>.Success(200));
        }
    }
}
