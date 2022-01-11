using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorPaymentMethodEntityVocabulary : SimpleVocabulary
    {
        public VendorPaymentMethodEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendorPaymentMethodEntity";
            KeyPrefix = "commonDataModel.vendorpaymentmethodentity";
            KeySeparator = ".";
            Grouping = "/VendorPaymentMethodEntity";

            AddGroup("Common Data Model VendorPaymentMethodEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowPaymentCopies = group.Add(new VocabularyKey(nameof(AllowPaymentCopies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankTransactionType = group.Add(new VocabularyKey(nameof(BankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExportFormatClassId = group.Add(new VocabularyKey(nameof(ExportFormatClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemittanceFormatClassId = group.Add(new VocabularyKey(nameof(RemittanceFormatClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReturnFormatClassId = group.Add(new VocabularyKey(nameof(ReturnFormatClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountGracePeriodDays = group.Add(new VocabularyKey(nameof(DiscountGracePeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExportPromissoryNoteDuringInvoicePosting = group.Add(new VocabularyKey(nameof(ExportPromissoryNoteDuringInvoicePosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BridgingPostingEnabled = group.Add(new VocabularyKey(nameof(BridgingPostingEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BridgingPostingAccount = group.Add(new VocabularyKey(nameof(BridgingPostingAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LastFileNumber = group.Add(new VocabularyKey(nameof(LastFileNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LastFileDate = group.Add(new VocabularyKey(nameof(LastFileDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LastFileNumberToday = group.Add(new VocabularyKey(nameof(LastFileNumberToday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentAccount = group.Add(new VocabularyKey(nameof(PaymentAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentType = group.Add(new VocabularyKey(nameof(PaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentJournalName = group.Add(new VocabularyKey(nameof(PaymentJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreateAndDrawPromissoryNoteDuringInvoicePosting = group.Add(new VocabularyKey(nameof(CreateAndDrawPromissoryNoteDuringInvoicePosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentStatus = group.Add(new VocabularyKey(nameof(PaymentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SumByPeriod = group.Add(new VocabularyKey(nameof(SumByPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnablePostdatedCheckClearingPosting = group.Add(new VocabularyKey(nameof(EnablePostdatedCheckClearingPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PromissoryNoteDraftType = group.Add(new VocabularyKey(nameof(PromissoryNoteDraftType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BridgingPostingAccountDisplayValue = group.Add(new VocabularyKey(nameof(BridgingPostingAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentAccountDisplayValue = group.Add(new VocabularyKey(nameof(PaymentAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidateTransactionTypeIsBank = group.Add(new VocabularyKey(nameof(ValidateTransactionTypeIsBank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidateOffsetTransactionTypeIsBank = group.Add(new VocabularyKey(nameof(ValidateOffsetTransactionTypeIsBank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidateCheckNumberIsMandatory = group.Add(new VocabularyKey(nameof(ValidateCheckNumberIsMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidatePaymentSpecificationIsMandatory = group.Add(new VocabularyKey(nameof(ValidatePaymentSpecificationIsMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidatePaymentIdIsMandatory = group.Add(new VocabularyKey(nameof(ValidatePaymentIdIsMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidatePaymentNoteIsMandatory = group.Add(new VocabularyKey(nameof(ValidatePaymentNoteIsMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidatePaymentReferenceIsMandatory = group.Add(new VocabularyKey(nameof(ValidatePaymentReferenceIsMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributePaymentAccountEnabled = group.Add(new VocabularyKey(nameof(AttributePaymentAccountEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeThirdPartyBankEnabled = group.Add(new VocabularyKey(nameof(AttributeThirdPartyBankEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributePaymentIdEnabled = group.Add(new VocabularyKey(nameof(AttributePaymentIdEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeBelgianStructuredPaymentIdEnabled = group.Add(new VocabularyKey(nameof(AttributeBelgianStructuredPaymentIdEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExportFormatClassName = group.Add(new VocabularyKey(nameof(ExportFormatClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemittanceFormatClassName = group.Add(new VocabularyKey(nameof(RemittanceFormatClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReturnFormatClassName = group.Add(new VocabularyKey(nameof(ReturnFormatClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseGERConfiguration = group.Add(new VocabularyKey(nameof(UseGERConfiguration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SATPaymentType = group.Add(new VocabularyKey(nameof(SATPaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ERFormatMapping = group.Add(new VocabularyKey(nameof(ERFormatMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElectronicReportingSolution = group.Add(new VocabularyKey(nameof(ElectronicReportingSolution), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElectronicReportingVendor = group.Add(new VocabularyKey(nameof(ElectronicReportingVendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SPEDPrimaryPaymentMethodDescription = group.Add(new VocabularyKey(nameof(SPEDPrimaryPaymentMethodDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SPEDPrimaryPaymentMethod = group.Add(new VocabularyKey(nameof(SPEDPrimaryPaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GeneratePaymentOneVoucher = group.Add(new VocabularyKey(nameof(GeneratePaymentOneVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionControl = group.Add(new VocabularyKey(nameof(DimensionControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionAttributeSet = group.Add(new VocabularyKey(nameof(DimensionAttributeSet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionAttributeDisplayValue = group.Add(new VocabularyKey(nameof(DimensionAttributeDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExportLayoutGroupId = group.Add(new VocabularyKey(nameof(ExportLayoutGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReturnLayoutGroupId = group.Add(new VocabularyKey(nameof(ReturnLayoutGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryPurpose = group.Add(new VocabularyKey(nameof(CategoryPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeBearer = group.Add(new VocabularyKey(nameof(ChargeBearer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LocalInstrument = group.Add(new VocabularyKey(nameof(LocalInstrument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceLevel = group.Add(new VocabularyKey(nameof(ServiceLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeBearerValue = group.Add(new VocabularyKey(nameof(ChargeBearerValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirectDebit = group.Add(new VocabularyKey(nameof(DirectDebit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingProfileRemitNotes = group.Add(new VocabularyKey(nameof(PostingProfileRemitNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountType { get; private set; }
public VocabularyKey AllowPaymentCopies { get; private set; }
public VocabularyKey BankTransactionType { get; private set; }
public VocabularyKey ExportFormatClassId { get; private set; }
public VocabularyKey RemittanceFormatClassId { get; private set; }
public VocabularyKey ReturnFormatClassId { get; private set; }
public VocabularyKey DiscountGracePeriodDays { get; private set; }
public VocabularyKey ExportPromissoryNoteDuringInvoicePosting { get; private set; }
public VocabularyKey BridgingPostingEnabled { get; private set; }
public VocabularyKey BridgingPostingAccount { get; private set; }
public VocabularyKey LastFileNumber { get; private set; }
public VocabularyKey LastFileDate { get; private set; }
public VocabularyKey LastFileNumberToday { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey PaymentAccount { get; private set; }
public VocabularyKey PaymentType { get; private set; }
public VocabularyKey PaymentJournalName { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey CreateAndDrawPromissoryNoteDuringInvoicePosting { get; private set; }
public VocabularyKey PaymentStatus { get; private set; }
public VocabularyKey SumByPeriod { get; private set; }
public VocabularyKey EnablePostdatedCheckClearingPosting { get; private set; }
public VocabularyKey PromissoryNoteDraftType { get; private set; }
public VocabularyKey BridgingPostingAccountDisplayValue { get; private set; }
public VocabularyKey PaymentAccountDisplayValue { get; private set; }
public VocabularyKey ValidateTransactionTypeIsBank { get; private set; }
public VocabularyKey ValidateOffsetTransactionTypeIsBank { get; private set; }
public VocabularyKey ValidateCheckNumberIsMandatory { get; private set; }
public VocabularyKey ValidatePaymentSpecificationIsMandatory { get; private set; }
public VocabularyKey ValidatePaymentIdIsMandatory { get; private set; }
public VocabularyKey ValidatePaymentNoteIsMandatory { get; private set; }
public VocabularyKey ValidatePaymentReferenceIsMandatory { get; private set; }
public VocabularyKey AttributePaymentAccountEnabled { get; private set; }
public VocabularyKey AttributeThirdPartyBankEnabled { get; private set; }
public VocabularyKey AttributePaymentIdEnabled { get; private set; }
public VocabularyKey AttributeBelgianStructuredPaymentIdEnabled { get; private set; }
public VocabularyKey ExportFormatClassName { get; private set; }
public VocabularyKey RemittanceFormatClassName { get; private set; }
public VocabularyKey ReturnFormatClassName { get; private set; }
public VocabularyKey UseGERConfiguration { get; private set; }
public VocabularyKey SATPaymentType { get; private set; }
public VocabularyKey ERFormatMapping { get; private set; }
public VocabularyKey ElectronicReportingSolution { get; private set; }
public VocabularyKey ElectronicReportingVendor { get; private set; }
public VocabularyKey SPEDPrimaryPaymentMethodDescription { get; private set; }
public VocabularyKey SPEDPrimaryPaymentMethod { get; private set; }
public VocabularyKey GeneratePaymentOneVoucher { get; private set; }
public VocabularyKey DimensionControl { get; private set; }
public VocabularyKey DimensionAttributeSet { get; private set; }
public VocabularyKey DimensionAttributeDisplayValue { get; private set; }
public VocabularyKey ExportLayoutGroupId { get; private set; }
public VocabularyKey ReturnLayoutGroupId { get; private set; }
public VocabularyKey CategoryPurpose { get; private set; }
public VocabularyKey ChargeBearer { get; private set; }
public VocabularyKey LocalInstrument { get; private set; }
public VocabularyKey ServiceLevel { get; private set; }
public VocabularyKey ChargeBearerValue { get; private set; }
public VocabularyKey DirectDebit { get; private set; }
public VocabularyKey PostingProfileRemitNotes { get; private set; }


    }
}