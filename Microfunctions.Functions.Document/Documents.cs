namespace Microfunctions.Functions.Document
{
    using System;
    using System.Threading.Tasks;
    using Extensions;
    using Microfunctions.Services.Document;
    using Microfunctions.Services.Document.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Extensions.Logging;

    public static class Documents
    {
        [FunctionName("documents")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            try
            {
                //// This goes back to RESTful way per endpoint. Create Separate Functions if needed
                //// Refactor to preferred approach if needed. e.g. Strategy, Chain.
                switch (req.Method)
                {
                    case "POST":
                        var service = new DocumentService(); //// Consider DI and/or Factory
                        var response = await service.CreateDocumentAsync(req.As<CreateDocumentRequest>());
                        return new OkObjectResult(response);
                }

                return new NotFoundResult();
            }
            catch (Exception) //// Can be DocumentServiceException
            {
                //// Since the DocumentService has logging. Ensure stack trace are not exposed.
                return new StatusCodeResult(500);
            }
        }
    }
}
