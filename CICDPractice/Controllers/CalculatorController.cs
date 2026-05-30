using CICDPractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace CICDPractice.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly CalculatorService _calculator;

    public CalculatorController(CalculatorService calculator)
    {
        _calculator = calculator;
    }

    [HttpGet("add")]
    public IActionResult Add([FromQuery] double a, [FromQuery] double b)
    { 
        return Ok(_calculator.Add(a, b));
    }
    [HttpGet("subtract")]
    public IActionResult Subtract([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(_calculator.Subtract(a, b));
    }

    [HttpGet("multiply")]
    public IActionResult Multiply([FromQuery]double a, [FromQuery] double b)
    {
        return Ok(_calculator.Multiply(a, b));
    }

    [HttpGet("divide")]
    public IActionResult Divide([FromQuery] double a, [FromQuery] double b)
    {
        try
        {
            return Ok(_calculator.Divide(a, b));
        }
        catch (DivideByZeroException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
