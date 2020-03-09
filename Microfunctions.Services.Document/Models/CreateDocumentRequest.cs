namespace Microfunctions.Services.Document.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class CreateDocumentRequest
    {
        [DataMember]
        public string Name { get; set; }
    }
}
