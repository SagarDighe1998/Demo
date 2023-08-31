using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

public static class HelloWorldFunction
{
    [FunctionName("GreetFunction"  )] public static async Task<IActionResult> 
        Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] 
    HttpRequest req, ILogger log) { log.LogInformation("C# HTTP trigger function processed a request.");
        string name = req.Query["name"];
        string responseMessage = string.IsNullOrEmpty(name) ? "Please1 provide a name in the query string." : $"Hello, {name}!";
        return new OkObjectResult(responseMessage); }
}

