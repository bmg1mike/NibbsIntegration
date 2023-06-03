namespace NibbsIntegration.Domain.DTOs.Responses.NipsResponses;


[XmlRoot(ElementName = "NESingleResponse")]
public class NipsNameEnquirySingleResponse
{

    [XmlElement(ElementName = "SessionID")]
    public string? SessionID { get; set; }

    [XmlElement(ElementName = "DestinationInstitutionCode")]
    public string? DestinationInstitutionCode { get; set; }

    [XmlElement(ElementName = "ChannelCode")]
    public int ChannelCode { get; set; }

    [XmlElement(ElementName = "AccountNumber")]
    public string? AccountNumber { get; set; }

    [XmlElement(ElementName = "AccountName")]
    public string? AccountName { get; set; }

    [XmlElement(ElementName = "BankVerificationNumber")]
    public int BankVerificationNumber { get; set; }

    [XmlElement(ElementName = "KYCLevel")]
    public int KYCLevel { get; set; }

    [XmlElement(ElementName = "ResponseCode")]
    public string? ResponseCode { get; set; }
}