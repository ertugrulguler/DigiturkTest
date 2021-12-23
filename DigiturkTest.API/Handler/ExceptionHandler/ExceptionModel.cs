using Newtonsoft.Json;

namespace DigiturkTest.API.Handler.ExceptionHandler
{
    public class ExceptionModel
    {
        public int StatusCode { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; }

        public ExceptionModel(string message="Bilinmeyen bir hata oluştu.", int statusCode = 500)
        {
            StatusCode = statusCode;
            Message = message;
        }
    }
}