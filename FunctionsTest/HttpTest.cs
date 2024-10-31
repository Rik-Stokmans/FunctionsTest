using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FunctionsTest;

public class HttpTest
{
    private readonly ILogger<HttpTest> _logger;

    public HttpTest(ILogger<HttpTest> logger)
    {
        _logger = logger;
    }

    [Function("HttpTest")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
        
    }

}