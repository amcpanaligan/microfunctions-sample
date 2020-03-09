namespace Microfunctions.Clients.Document
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microfunctions.Clients.Document.Models;

    public sealed class DocumentClient
    {
        private static HttpClient client = new HttpClient();

        public DocumentClient(string endpoint, string key)
        {
            client.BaseAddress = new Uri(endpoint);
            client.DefaultRequestHeaders.Add("x-functions-key", key);
        }

        public async Task<CreateDocumentResponse> CreateDocumentAsync(CreateDocumentRequest request)
        {
            //// This should do nothing but call the http function through HttpClient
            var response = await client.PostAsJsonAsync("api/documents", request);
            return await response.Content.ReadAsAsync<CreateDocumentResponse>();
        }
    }
}
