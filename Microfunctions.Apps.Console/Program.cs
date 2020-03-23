namespace Microfunctions.Apps.Console
{
    using Microfunctions.Clients.Document;
    using Microfunctions.Infrastructure.Interfaces;
    using Microfunctions.Infrastructure.Messages.Documents;
    using Microfunctions.Services.Document;

    class Program
    {
        static void Main(string[] args)
        {
            //// Let this be in the context of a client, an Api, Console App, or Any App that uses the DocumentClient which is an interface to DocumentService / Function

            System.Console.WriteLine("Please any key to simulate function app");
            System.Console.ReadKey();
            System.Console.WriteLine("Loading. Please wait...");

            //// You can now interchange IDocumentService to Function Clients or the Real Service

            IDocumentService service = new DocumentClient("http://localhost:7071", string.Empty); //// All should be in config.
            //// service = new DocumentService();

            var response = service.CreateDocumentAsync(new CreateDocumentRequest { Name = "Test" }).Result;
            System.Console.ReadKey();
        }
    }
}
