using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContentModerationFunction;

public class AnalyzeKeyPhrases
{
    private readonly ILogger<AnalyzeKeyPhrases> _logger;

    public AnalyzeKeyPhrases(ILogger<AnalyzeKeyPhrases> logger)
    {
        _logger = logger;
    }

    [Function("AnalyzeKeyPhrases")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}
