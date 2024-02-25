using Microsoft.AspNetCore.Mvc;
using PayrollSystem.Core;

namespace PayrollSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayrollCalaculatorController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public ActionResult<decimal> Calculate(Employee employee)
        {
            PayrollCalaculator calaculate = new();
            return Ok(calaculate.Calculate(employee));
        }
    }
}
