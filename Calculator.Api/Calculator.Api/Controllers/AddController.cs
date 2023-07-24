using Calculator.Api.Dtos;
using Calculator.Api.Service;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        private readonly IAdditionService _additionService;

        public AddController(IAdditionService additionService)
        {
             _additionService = additionService;
        }

        [HttpPost]
        public  async Task<IActionResult> Add([FromBody] AdditionDto inputDto)
        {
            var result = await _additionService.Add(inputDto);
            return Ok(result);
         
        }
    }
}