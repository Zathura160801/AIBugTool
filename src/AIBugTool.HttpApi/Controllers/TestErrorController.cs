using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AIBugTool.Controllers;

[ApiController]
[Route("api/test")]
[ApiExplorerSettings(GroupName = "v1")]
public class TestErrorController : AIBugToolController
{
    private readonly ILogger<TestErrorController> _logger;

    public TestErrorController(ILogger<TestErrorController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Intentionally throws a NullReferenceException for logging tests.
    /// </summary>
    [HttpGet("null-ref")]
    public IActionResult TriggerNullRef()
    {
        try
        {
            string? data = null;
            var length = data!.Length;
            return Ok(length);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to process data in TestErrorController");
            throw;
        }
    }

    /// <summary>
    /// Intentionally throws an InvalidOperationException for logging tests.
    /// </summary>
    [HttpGet("invalid-op")]
    public IActionResult TriggerInvalidOp()
    {
        try
        {
            throw new InvalidOperationException("Simulated invalid state for testing");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An invalid operation occurred");
            throw;
        }
    }
}
