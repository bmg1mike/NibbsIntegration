namespace NibbsIntegration.Service;

public class SoapHelper : ISoapHelper
{
    private readonly IHttpClientFactory _client;
    private readonly ILogger<SoapHelper> _logger;

    public SoapHelper(IHttpClientFactory client, ILogger<SoapHelper> logger)
    {
        _client = client;
        _logger = logger;
    }

    public async Task<string>? ConsumeApi(string payload, string url, Dictionary<string, string>? headers = null)
    {

        try
        {
            _logger.LogInformation($"Request Payload :\n{payload}");
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);

            if (headers != null)
            {
                foreach (var item in headers)
                {
                    requestMessage.Headers.Add(item.Key, item.Value);
                }
            }

            requestMessage.Content = new StringContent(payload, Encoding.UTF8, "text/xml");

            var client = _client.CreateClient("creditClient");
            var response = await client.SendAsync(requestMessage);

            var result = await response.Content.ReadAsStringAsync();

            _logger.LogInformation($"Response Payload :\n{result}");

            if (response.IsSuccessStatusCode)
            {
                return result;
            }

            return string.Empty;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Soap Error\n{ex.Message}");
            
            return string.Empty;
        }
    }


}