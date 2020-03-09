namespace Microfunctions.Services.Document
{
    using System.Threading.Tasks;
    using Microfunctions.Services.Document.Models;

    public class DocumentService
    {
        public async Task<CreateDocumentResponse> CreateDocumentAsync(CreateDocumentRequest request)
        {
            return await Task.FromResult(new CreateDocumentResponse { StatusCode = 69 });
        }
    }
}
