namespace NibbsIntegration.Domain;

[XmlRoot(ElementName="FTAckCredit")]
public class TransactionResponseAcknowledgement
{
    [XmlElement(ElementName = "SessionID")]
    public string? SessionID { get; set; }

    [XmlElement(ElementName = "NameEnquiryRef")]
    public string? NameEnquiryRef { get; set; }

    [XmlElement(ElementName = "DestinationInstitutionCode")]
    public string? DestinationInstitutionCode { get; set; }

    [XmlElement(ElementName = "ChannelCode")]
    public int ChannelCode { get; set; }

    [XmlElement(ElementName = "BeneficiaryAccountName")]
    public string? BeneficiaryAccountName { get; set; }

    [XmlElement(ElementName = "BeneficiaryAccountNumber")]
    public string? BeneficiaryAccountNumber { get; set; }

    [XmlElement(ElementName = "BeneficiaryBankVerificationNumber")]
    public string? BeneficiaryBankVerificationNumber { get; set; }

    [XmlElement(ElementName = "BeneficiaryKYCLevel")]
    public int BeneficiaryKYCLevel { get; set; }

    [XmlElement(ElementName = "OriginatorAccountName")]
    public string? OriginatorAccountName { get; set; }

    [XmlElement(ElementName = "OriginatorAccountNumber")]
    public string? OriginatorAccountNumber { get; set; }

    [XmlElement(ElementName = "OriginatorBankVerificationNumber")]
    public string? OriginatorBankVerificationNumber { get; set; }

    [XmlElement(ElementName = "OriginatorKYCLevel")]
    public int OriginatorKYCLevel { get; set; }

    [XmlElement(ElementName = "TransactionLocation")]
    public string? TransactionLocation { get; set; }

    [XmlElement(ElementName = "Narration")]
    public string? Narration { get; set; }

    [XmlElement(ElementName = "PaymentReference")]
    public string? PaymentReference { get; set; }

    [XmlElement(ElementName = "Amount")]
    public decimal Amount { get; set; }

    [XmlElement(ElementName = "ResponseCode")]
    public string? ResponseCode { get; set; }
}