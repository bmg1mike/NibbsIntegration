namespace NibbsIntegration.Domain;

[XmlRoot(ElementName = "TSQuerySingleResponse")]
public class TransactionStatusQueryResponse
{
    [XmlElement(ElementName = "SourceInstitutionCode")]
    public string? SourceInstitutionCode { get; set; }

    [XmlElement(ElementName = "ChannelCode")]
    public int ChannelCode { get; set; }

    [XmlElement(ElementName = "SessionID")]
    public string? SessionID { get; set; }

    [XmlElement(ElementName = "ResponseCode")]
    public string? ResponseCode { get; set; }
}