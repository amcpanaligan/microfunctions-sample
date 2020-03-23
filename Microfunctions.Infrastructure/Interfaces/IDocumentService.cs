namespace Microfunctions.Infrastructure.Interfaces
{
    using System.Threading.Tasks;
    using Microfunctions.Infrastructure.Messages.Documents;

    public interface IDocumentService
    {
        Task<CreateDocumentResponse> CreateDocumentAsync(CreateDocumentRequest request);
    }
}
