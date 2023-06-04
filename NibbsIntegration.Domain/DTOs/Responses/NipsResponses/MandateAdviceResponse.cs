namespace NibbsIntegration.Domain;

[XmlRoot(ElementName = "MandateAdviceResponse")]
public class MandateAdviceResponse
{

    [XmlElement(ElementName = "SessionID")]
    public string? SessionID { get; set; }

    [XmlElement(ElementName = "DestinationInstitutionCode")]
    public string? DestinationInstitutionCode { get; set; }

    [XmlElement(ElementName = "ChannelCode")]
    public int ChannelCode { get; set; }

    [XmlElement(ElementName = "MandateReferenceNumber")]
    public string? MandateReferenceNumber { get; set; }

    [XmlElement(ElementName = "Amount")]
    public decimal Amount { get; set; }

    [XmlElement(ElementName = "DebitAccountName")]
    public string? DebitAccountName { get; set; }

    [XmlElement(ElementName = "DebitAccountNumber")]
    public string? DebitAccountNumber { get; set; }

    [XmlElement(ElementName = "DebitBankVerificationNumber")]
    public string? DebitBankVerificationNumber { get; set; }

    [XmlElement(ElementName = "DebitKYCLevel")]
    public int DebitKYCLevel { get; set; }

    [XmlElement(ElementName = "BeneficiaryAccountName")]
    public string? BeneficiaryAccountName { get; set; }

    [XmlElement(ElementName = "BeneficiaryAccountNumber")]
    public string? BeneficiaryAccountNumber { get; set; }

    [XmlElement(ElementName = "BeneficiaryBankVerificationNumber")]
    public string? BeneficiaryBankVerificationNumber { get; set; }

    [XmlElement(ElementName = "BeneficiaryKYCLevel")]
    public int BeneficiaryKYCLevel { get; set; }

    [XmlElement(ElementName = "ResponseCode")]
    public string? ResponseCode { get; set; }
}