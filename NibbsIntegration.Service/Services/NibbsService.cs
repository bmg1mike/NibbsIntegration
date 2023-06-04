using Microsoft.Extensions.Configuration;
using NibbsIntegration.Domain;

namespace NibbsIntegration.Service;

public interface INibbsService
{
    Task<Result<NameEnquirySingleResponse>> NameEnquiry();
}

public class NibbsService : INibbsService
{
    private readonly ILogger<NibbsService> _logger;
    private readonly ISoapHelper _soapHelper;
    private readonly IConfiguration _configuration;

    public NibbsService(ILogger<NibbsService> logger, ISoapHelper soapHelper, IConfiguration configuration)
    {
        _logger = logger;
        _soapHelper = soapHelper;
        _configuration = configuration;
    }

    public async Task<Result<NameEnquirySingleResponse>> NameEnquiry()
    {
        try
        {
            var payload = NipsPayloads.NameEnquiryPayload();
            var url = "http://196.6.103.10:88/NIPWS/NIPTSQInterface";
            var response = await _soapHelper.ConsumeApi(payload, url);

            if (string.IsNullOrEmpty(response))
            {
                return Result<NameEnquirySingleResponse>.Failure("There was an error, please try again  later");
            }

            var result = XmlOjectConverter.XmlToObject<NameEnquirySingleResponse>(response);
            return Result<NameEnquirySingleResponse>.Success(result);
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}