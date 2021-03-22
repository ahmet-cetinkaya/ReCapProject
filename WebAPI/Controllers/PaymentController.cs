using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("test")]
        public IActionResult Test() // Test
        {
            var result = _paymentService.test();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}