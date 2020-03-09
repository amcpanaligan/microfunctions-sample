namespace Microfunctions.Apps.Console
{
    using Microfunctions.Clients.Document;

    class Program
    {
        static void Main(string[] args)
        {
            //// Let this be in the context of a client, an Api, Console App, or Any App that uses the DocumentClient which is an interface to DocumentService / Function

            System.Console.WriteLine("Please any key to simulate function app");
            System.Console.ReadKey();
            System.Console.WriteLine("Loading. Please wait...");


            var client = new DocumentClient("http://localhost:7071", string.Empty); //// All should be in config.

            var response = client.CreateDocumentAsync(new Clients.Document.Models.CreateDocumentRequest { Name = "Test" }).Result;
            System.Console.ReadKey();
        }
    }
}
