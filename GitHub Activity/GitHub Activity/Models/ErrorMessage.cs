using Newtonsoft.Json;

namespace GitHub_Activity.Models;

public class ErrorMessage
{
    public ErrorMessage()
    {
        
    }

    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("documentation_url")]
    public string DocumentationUrl { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }
}