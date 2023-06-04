namespace NibbsIntegration.Domain;

[XmlRoot(ElementName = "AmountUnblockResponse")]
public class AmountUnblockResponse
{

    [XmlElement(ElementName = "SessionID")]
    public string? SessionID { get; set; }

    [XmlElement(ElementName = "DestinationInstitutionCode")]
    public string? DestinationInstitutionCode { get; set; }

    [XmlElement(ElementName = "ChannelCode")]
    public int ChannelCode { get; set; }

    [XmlElement(ElementName = "ReferenceCode")]
    public string? ReferenceCode { get; set; }

    [XmlElement(ElementName = "TargetAccountName")]
    public string? TargetAccountName { get; set; }

    [XmlElement(ElementName = "TargetBankVerificationNumber")]
    public string? TargetBankVerificationNumber { get; set; }

    [XmlElement(ElementName = "TargetAccountNumber")]
    public string? TargetAccountNumber { get; set; }

    [XmlElement(ElementName = "ReasonCode")]
    public string? ReasonCode { get; set; }

    [XmlElement(ElementName = "Narration")]
    public string? Narration { get; set; }

    [XmlElement(ElementName = "Amount")]
    public double Amount { get; set; }

    [XmlElement(ElementName = "ResponseCode")]
    public int ResponseCode { get; set; }
}