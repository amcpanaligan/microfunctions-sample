namespace Microfunctions.Functions.Document.Extensions
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Newtonsoft.Json;

    public static class HttpRequestExtensions
    {
        public static T As<T> (this HttpRequest request)
        {
            var requestBody = request.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(requestBody);
        }
    }
}
