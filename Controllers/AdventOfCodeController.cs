using AdventOfCode;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections;

namespace otel_advent_of_code.Controllers;

[ApiController]
[Route("[controller]")]
public class AdventOfCodeController : ControllerBase
{
    private readonly ILogger<AdventOfCodeController> _logger;

    public AdventOfCodeController(ILogger<AdventOfCodeController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetDay01PartA")]
    public int Get()
    {
        return Day01_2022.PartA();
    }
}