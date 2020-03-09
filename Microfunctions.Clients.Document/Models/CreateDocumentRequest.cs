namespace Microfunctions.Clients.Document.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class CreateDocumentRequest
    {
        [DataMember]
        public string Name { get; set; }
    }
}
