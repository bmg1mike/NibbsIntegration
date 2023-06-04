namespace NibbsIntegration.Service.Helpers;

public static class NipsPayloads
{
    public static string NameEnquiryPayload()
    {
        var payload = $@"<?xml version=""1.0"" encoding=""UTF-8"" ?>
                        <NESingleRequest>
                            <SessionID>000001100913103301000000000001</SessionID>
                            <DestinationInstitutionCode>000002</DestinationInstitutionCode>
                            <ChannelCode>1</ChannelCode>
                            <AccountNumber>2222000000012345</AccountNumber>
                        </NESingleRequest>";
        return payload;
    }

    public static string FundTransferRequestDirectCredit()
    {
        var payload = $@"<?xml version=""1.0"" encoding=""UTF-8"" ?>
                        <FTSingleCreditRequest>
                            <SessionID>000001100913103301000000000002</SessionID>
                            <NameEnquiryRef>000001100913103301000000000001</NameEnquiryRef>
                            <DestinationInstitutionCode>000002</DestinationInstitutionCode>
                            <ChannelCode>1</ChannelCode>
                            <BeneficiaryAccountName>Ajibade Oluwasegun</BeneficiaryAccountName>
                            <BeneficiaryAccountNumber>2222002345</BeneficiaryAccountNumber>
                            <BeneficiaryBankVerificationNumber>1033000442</BeneficiaryBankVerificationNumber>
                            <BeneficiaryKYCLevel>1</BeneficiaryKYCLevel>
                            <OriginatorAccountName>Adewale Hassan</OriginatorAccountName>
                            <OriginatorAccountNumber>3333002345</OriginatorAccountNumber>
                            <OriginatorBankVerificationNumber>1033000441</OriginatorBankVerificationNumber>
                            <OriginatorKYCLevel>1</OriginatorKYCLevel>
                            <TransactionLocation>6.4300747,3.4110715</TransactionLocation>
                            <Narration>1000000001</Narration>
                            <PaymentReference>yyyyyyyyyyyyyy</PaymentReference>
                            <Amount>1000.00</Amount>
                        </FTSingleCreditRequest>";
        return payload;
    }

    public static string FundTransferRequestDirectDebit()
    {
        var payload = $@"<?xml version=""1.0"" encoding=""UTF-8"" ?>
                        <FTSingleDebitRequest>
                            <SessionID>000001100913103301000000000002</SessionID>
                            <NameEnquiryRef>000001100913103301000000000001</NameEnquiryRef>
                            <DestinationInstitutionCode>000002</DestinationInstitutionCode>
                            <ChannelCode>1</ChannelCode>
                            <DebitAccountName>Ajibade Oluwasegun</DebitAccountName>
                            <DebitAccountNumber>2222000000012345</DebitAccountNumber>
                            <DebitBankVerificationNumber>1033000442</DebitBankVerificationNumber>
                            <DebitKYCLevel>1</DebitKYCLevel>
                            <BeneficiaryAccountName>Sarah Hassan Emeka</BeneficiaryAccountName>
                            <BeneficiaryAccountNumber>2222002345</BeneficiaryAccountNumber>
                            <BeneficiaryBankVerificationNumber>1033000442</BeneficiaryBankVerificationNumber>
                            <BeneficiaryKYCLevel>1</BeneficiaryKYCLevel>
                            <TransactionLocation>6.4300747,3.4110715</TransactionLocation>
                            <Narration>Transfer from 000002 to 0YY</Narration>
                            <PaymentReference>1000000001</PaymentReference>
                            <MandateReferenceNumber>xxxxxxxxxxxxxxxxxxx</MandateReferenceNumber>
                            <TransactionFee>0.00</TransactionFee>
                            <Amount>1000.00</Amount>
                        </FTSingleDebitRequest>";
        return payload;
    }

    public static string TransactionStatusQueryRequest()
    {
        var payload = $@"<?xml version=""1.0"" encoding=""UTF-8"" ?>
                        <TSQuerySingleRequest> <SourceInstitutionCode>000002</SourceInstitutionCode>
                        <ChannelCode>1</ChannelCode>
                        <SessionID>000001100913103301000000000001</SessionID>
                        </TSQuerySingleRequest>";
        return payload;
    }

    public  static string BalanceEnquiryRequest()
    {
        var payload = $@"<?xml version=""1.0"" encoding=""UTF-8"" ?>
                        <BalanceEnquiryRequest>
                            <SessionID>000001100913103301000000000001</SessionID>
                            <DestinationInstitutionCode>000002</DestinationInstitutionCode>
                            <ChannelCode>7</ChannelCode>
                            <AuthorizationCode>xxxxxxxxxxxxxxx</AuthorizationCode>
                            <TargetAccountName>Ajibade Oluwasegun</TargetAccountName>
                            <TargetBankVerificationNumber>1033000442</TargetBankVerificationNumber>
                            <TargetAccountNumber>2222002345</TargetAccountNumber>
                        </BalanceEnquiryRequest>";
        return payload;
    }

    public static string FundTransferAdviceRequestDirectCredit()
    {
        var payload = $@"<?xml version=""1.0"" encoding=""UTF-8"" ?>
                        <FTAdviceCreditRequest>
                            <SessionID>000001100913103301000000000002</SessionID>
                            <NameEnquiryRef>000001100913103301000000000001</NameEnquiryRef>
                            <DestinationInstitutionCode>000002</DestinationInstitutionCode>
                            <ChannelCode>1</ChannelCode>
                            <BeneficiaryAccountName>Ajibade Oluwasegun</BeneficiaryAccountName>
                            <BeneficiaryAccountNumber>2222002345</BeneficiaryAccountNumber>
                            <BeneficiaryBankVerificationNumber>1033000442</BeneficiaryBankVerificationNumber>
                            <BeneficiaryKYCLevel>1</BeneficiaryKYCLevel>
                            <OriginatorAccountName>Adewale Hassan</OriginatorAccountName>
                            <OriginatorAccountNumber>3333002345</OriginatorAccountNumber>
                            <OriginatorBankVerificationNumber>1033000441</OriginatorBankVerificationNumber>
                            <OriginatorKYCLevel>1</OriginatorKYCLevel>
                            <TransactionLocation>6.4300747,3.4110715</TransactionLocation>
                            <Narration>Transfer from 000002 to 0YY</Narration>
                            <PaymentReference>1000000001</PaymentReference>
                            <Amount>1000.00</Amount>
                        </FTAdviceCreditRequest>";
        return payload;
    }

    public static string FundTransferAdviceRequestDirectDebit()
    {
        var payload = $@"<?xml version=""1.0"" encoding=""UTF-8"" ?>
                        <FTAdviceDebitRequest>
                            <SessionID>000001100913103301000000000002</SessionID>
                            <NameEnquiryRef>000001100913103301000000000001</NameEnquiryRef>
                            <DestinationInstitutionCode>000002</DestinationInstitutionCode>
                            <ChannelCode>1</ChannelCode>
                            <DebitAccountName>Ajibade Oluwasegun</DebitAccountName>
                            <DebitAccountNumber>2222000000012345</DebitAccountNumber>
                            <DebitBankVerificationNumber>1033000442</DebitBankVerificationNumber>
                            <DebitKYCLevel>1</DebitKYCLevel>
                            <BeneficiaryAccountName>Sarah Hassan Emeka</BeneficiaryAccountName>
                            <BeneficiaryAccountNumber>2222002345</BeneficiaryAccountNumber>
                            <BeneficiaryBankVerificationNumber>1033000442</BeneficiaryBankVerificationNumber>
                            <BeneficiaryKYCLevel>1</BeneficiaryKYCLevel>
                            <TransactionLocation>6.4300747,3.4110715</TransactionLocation>
                            <Narration>Transfer from 000002 to 0YY</Narration>
                            <PaymentReference>1000000001</PaymentReference>
                            <MandateReferenceNumber>xxxxxxxxxxxxxxxxxxx</MandateReferenceNumber>
                            <TransactionFee>0.00</TransactionFee>
                            <Amount>1000.00</Amount>
                        </FTAdviceDebitRequest>";
        return payload;
    }
}