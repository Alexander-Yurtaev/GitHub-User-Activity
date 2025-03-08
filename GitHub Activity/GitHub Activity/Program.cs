using GitHub_Activity.Models;
using System.Net.Http.Headers;

if (args.Length < 1)
{
    Console.WriteLine("Username was not sent.");
    return;
}

string username = args[0];

string url = $"users/{username}/events";
using HttpClient httpClient = new (){BaseAddress = new Uri("https://api.github.com/") };

httpClient.DefaultRequestHeaders.Accept.Clear();
httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("GitHub_Activity", "1")); // set your own values here

HttpResponseMessage response = await httpClient.GetAsync(url);

if (response.IsSuccessStatusCode)
{
    Console.WriteLine($"Username: {username}");
    Console.WriteLine($"StatusCode: {response.StatusCode}");
    var events = await response.Content.ReadAsAsync<Event[]>();

    foreach (Event @event in events)
    {
        ShowEvent(@event);
    }
}
else
{
    var data = await response.Content.ReadAsAsync<ErrorMessage>();
    Console.WriteLine($"Status: {data.Status}, Error: {data.Message}");
}