namespace Microfunctions.Api.Controllers
{
    using System.Threading.Tasks;
    using Microfunctions.Api.Messages.Documents;
    using Microfunctions.Infrastructure.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/documents")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService service;

        public DocumentController(IDocumentService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> SendDocumentAsync([FromBody] SendDocumentWebRequest webRequest)
        {
            //// await this.service.CreateDocumentAsync(webRequest.AsRequest());
            return this.StatusCode(200);
        }
    }
}
