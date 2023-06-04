namespace NibbsIntegration.Service;

public interface ISoapHelper
{
    Task<string>? ConsumeApi(string payload, string url, Dictionary<string, string>? headers = null);
}