using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalEstablishmentEntityVocabulary : SimpleVocabulary
    {
        public FiscalEstablishmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalEstablishmentEntity";
            KeyPrefix = "commonDataModel.fiscalestablishmententity";
            KeySeparator = ".";
            Grouping = "/FiscalEstablishmentEntity";

            AddGroup("Common Data Model FiscalEstablishmentEntity Details", group =>
            {
                Accountant = group.Add(new VocabularyKey(nameof(Accountant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CCM = group.Add(new VocabularyKey(nameof(CCM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CNPJ = group.Add(new VocabularyKey(nameof(CNPJ), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Address = group.Add(new VocabularyKey(nameof(Address), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NFeAuthority = group.Add(new VocabularyKey(nameof(NFeAuthority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrintDanfeWhenAproved = group.Add(new VocabularyKey(nameof(PrintDanfeWhenAproved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BlockPostingNotValidatedNfeXml = group.Add(new VocabularyKey(nameof(BlockPostingNotValidatedNfeXml), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NFeDigitalCertificate = group.Add(new VocabularyKey(nameof(NFeDigitalCertificate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmailTemplateApprovedNFe = group.Add(new VocabularyKey(nameof(EmailTemplateApprovedNFe), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmailTemplateCanceledNFe = group.Add(new VocabularyKey(nameof(EmailTemplateCanceledNFe), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmailTemplateCorrectionLetterNFe = group.Add(new VocabularyKey(nameof(EmailTemplateCorrectionLetterNFe), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NFeEnvironment = group.Add(new VocabularyKey(nameof(NFeEnvironment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreprintedSecurityForm = group.Add(new VocabularyKey(nameof(PreprintedSecurityForm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SendDanfePdfInEmail = group.Add(new VocabularyKey(nameof(SendDanfePdfInEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidateXmlSchema = group.Add(new VocabularyKey(nameof(ValidateXmlSchema), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NFeVersion = group.Add(new VocabularyKey(nameof(NFeVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FciToIntrastateEnabled = group.Add(new VocabularyKey(nameof(FciToIntrastateEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalEstablishmentGroup = group.Add(new VocabularyKey(nameof(FiscalEstablishmentGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesIssuer = group.Add(new VocabularyKey(nameof(SalesIssuer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalOrganization = group.Add(new VocabularyKey(nameof(FiscalOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IE = group.Add(new VocabularyKey(nameof(IE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClosedWarehouse = group.Add(new VocabularyKey(nameof(ClosedWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NextFiscalPrinterDailyReportNumber = group.Add(new VocabularyKey(nameof(NextFiscalPrinterDailyReportNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NIRE = group.Add(new VocabularyKey(nameof(NIRE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SPEDContribReportingType = group.Add(new VocabularyKey(nameof(SPEDContribReportingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MatchNfeXmlOnPosting = group.Add(new VocabularyKey(nameof(MatchNfeXmlOnPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NFCeAuthority = group.Add(new VocabularyKey(nameof(NFCeAuthority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CSC = group.Add(new VocabularyKey(nameof(CSC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CSCToken = group.Add(new VocabularyKey(nameof(CSCToken), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NFCeEmailApproved = group.Add(new VocabularyKey(nameof(NFCeEmailApproved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NFCeEnvironment = group.Add(new VocabularyKey(nameof(NFCeEnvironment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NFCeSendPdfInEmail = group.Add(new VocabularyKey(nameof(NFCeSendPdfInEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NFCeVersion = group.Add(new VocabularyKey(nameof(NFCeVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountantCPF = group.Add(new VocabularyKey(nameof(AccountantCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountantCRC = group.Add(new VocabularyKey(nameof(AccountantCRC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLocation = group.Add(new VocabularyKey(nameof(AddressLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressParty = group.Add(new VocabularyKey(nameof(AddressParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressName = group.Add(new VocabularyKey(nameof(AddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalEstablishmentGroupId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalEstablishmentSalesIssuerId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentSalesIssuerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EFDocNFe402018005v110 = group.Add(new VocabularyKey(nameof(EFDocNFe402018005v110), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EFDocNFeTechNotes = group.Add(new VocabularyKey(nameof(EFDocNFeTechNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Accountant { get; private set; }
public VocabularyKey CCM { get; private set; }
public VocabularyKey CNPJ { get; private set; }
public VocabularyKey Address { get; private set; }
public VocabularyKey NFeAuthority { get; private set; }
public VocabularyKey PrintDanfeWhenAproved { get; private set; }
public VocabularyKey BlockPostingNotValidatedNfeXml { get; private set; }
public VocabularyKey NFeDigitalCertificate { get; private set; }
public VocabularyKey EmailTemplateApprovedNFe { get; private set; }
public VocabularyKey EmailTemplateCanceledNFe { get; private set; }
public VocabularyKey EmailTemplateCorrectionLetterNFe { get; private set; }
public VocabularyKey NFeEnvironment { get; private set; }
public VocabularyKey PreprintedSecurityForm { get; private set; }
public VocabularyKey SendDanfePdfInEmail { get; private set; }
public VocabularyKey ValidateXmlSchema { get; private set; }
public VocabularyKey NFeVersion { get; private set; }
public VocabularyKey FciToIntrastateEnabled { get; private set; }
public VocabularyKey FiscalEstablishmentGroup { get; private set; }
public VocabularyKey FiscalEstablishmentId { get; private set; }
public VocabularyKey SalesIssuer { get; private set; }
public VocabularyKey FiscalOrganization { get; private set; }
public VocabularyKey IE { get; private set; }
public VocabularyKey ClosedWarehouse { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey NextFiscalPrinterDailyReportNumber { get; private set; }
public VocabularyKey NIRE { get; private set; }
public VocabularyKey SPEDContribReportingType { get; private set; }
public VocabularyKey MatchNfeXmlOnPosting { get; private set; }
public VocabularyKey NFCeAuthority { get; private set; }
public VocabularyKey CSC { get; private set; }
public VocabularyKey CSCToken { get; private set; }
public VocabularyKey NFCeEmailApproved { get; private set; }
public VocabularyKey NFCeEnvironment { get; private set; }
public VocabularyKey NFCeSendPdfInEmail { get; private set; }
public VocabularyKey NFCeVersion { get; private set; }
public VocabularyKey AccountantCPF { get; private set; }
public VocabularyKey AccountantCRC { get; private set; }
public VocabularyKey AddressLocation { get; private set; }
public VocabularyKey AddressParty { get; private set; }
public VocabularyKey PartyNumber { get; private set; }
public VocabularyKey AddressName { get; private set; }
public VocabularyKey FiscalEstablishmentGroupId { get; private set; }
public VocabularyKey FiscalEstablishmentSalesIssuerId { get; private set; }
public VocabularyKey EFDocNFe402018005v110 { get; private set; }
public VocabularyKey EFDocNFeTechNotes { get; private set; }


    }
}