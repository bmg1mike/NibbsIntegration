namespace NibbsIntegration.Domain;

[XmlRoot(ElementName = "BalanceEnquiryResponse")]
public class BalanceEnquiryResponse
{
    [XmlElement(ElementName = "SessionID")]
    public string? SessionID { get; set; }

    [XmlElement(ElementName = "DestinationInstitutionCode")]
    public string? DestinationInstitutionCode { get; set; }

    [XmlElement(ElementName = "ChannelCode")]
    public int ChannelCode { get; set; }

    [XmlElement(ElementName = "AuthorizationCode")]
    public string? AuthorizationCode { get; set; }

    [XmlElement(ElementName = "TargetAccountName")]
    public string? TargetAccountName { get; set; }

    [XmlElement(ElementName = "TargetBankVerificationNumber")]
    public string? TargetBankVerificationNumber { get; set; }

    [XmlElement(ElementName = "TargetAccountNumber")]
    public string? TargetAccountNumber { get; set; }

    [XmlElement(ElementName = "AvailableBalance")]
    public decimal AvailableBalance { get; set; }

    [XmlElement(ElementName = "ResponseCode")]
    public string? ResponseCode { get; set; }
}