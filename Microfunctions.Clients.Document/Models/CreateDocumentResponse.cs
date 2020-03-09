namespace Microfunctions.Clients.Document.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class CreateDocumentResponse
    {
        [DataMember]
        public int StatusCode { get; set; }
    }
}
