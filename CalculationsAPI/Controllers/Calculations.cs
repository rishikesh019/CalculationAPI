using CalculationsAPI.Model;
using CalculationsAPI.Repository;
using CalculationsAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculationsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationsController : ControllerBase
    {
        private readonly ICalculations _claclulation;
        public CalculationsController(ICalculations calculation)
        {
            this._claclulation = calculation;

        }

        [HttpPost]
        [Route("Addition")]
        public async Task<IActionResult> Addition(RequestModel request)
        {
            try
            {
                var result =await _claclulation.Addition(request);
                if (result is not null)
                    return Ok(result);
                else return BadRequest(new Responce());
            }
            catch (Exception e)
            {
                return BadRequest(new Responce() { Message = e.Message });
            }
        }
        [HttpPost]
        [Route("Subtraction")]
        public async Task<IActionResult> Substraction(RequestModel request)
        {
            try
            {
                var result = await _claclulation.Subtraction(request);
                if (result is not null)
                    return Ok(result);
                else return BadRequest(new Responce());
            }
            catch (Exception e)
            {
                return BadRequest(new Responce() { Message = e.Message });
            }
        }
        [HttpPost]
        [Route("Multiplication")]
        public async Task<IActionResult> Multiplication(RequestModel request)
        {
            try
            {
                var result = await _claclulation.Multiplication(request);
                if (result is not null)
                    return Ok(result);
                else return BadRequest(new Responce());
            }
            catch (Exception e)
            {
                return BadRequest(new Responce() { Message = e.Message });
            }
        }
        [HttpPost]
        [Route("Division")]
        public async Task<IActionResult> Division(RequestModel request)
        {
            try
            {
                var result = await _claclulation.Division(request);
                if (result is not null)
                    return Ok(result);
                else return BadRequest(new Responce());
            }
            catch (Exception e)
            {
                return BadRequest(new Responce() { Message = e.Message });
            }
        }
    }
}
