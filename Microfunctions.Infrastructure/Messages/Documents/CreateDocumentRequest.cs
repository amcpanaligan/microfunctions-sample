namespace Microfunctions.Infrastructure.Messages.Documents
{
    using System.Runtime.Serialization;

    [DataContract]
    public class CreateDocumentRequest
    {
        [DataMember]
        public string Name { get; set; }
    }
}
