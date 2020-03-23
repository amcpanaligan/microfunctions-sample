namespace Microfunctions.Services.Document
{
    using System.Threading.Tasks;
    using Microfunctions.Infrastructure.Interfaces;
    using Microfunctions.Infrastructure.Messages.Documents;

    public class DocumentService : IDocumentService
    {
        public async Task<CreateDocumentResponse> CreateDocumentAsync(CreateDocumentRequest request)
        {
            return await Task.FromResult(new CreateDocumentResponse { StatusCode = 69 });
        }
    }
}
