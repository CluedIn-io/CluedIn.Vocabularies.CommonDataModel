using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailChannelEntityVocabulary : SimpleVocabulary
    {
        public RetailChannelEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailChannelEntity";
            KeyPrefix = "commonDataModel.retailchannelentity";
            KeySeparator = ".";
            Grouping = "/RetailChannelEntity";

            AddGroup("Common Data Model RetailChannelEntity Details", group =>
            {
                RetailChannelId = group.Add(new VocabularyKey(nameof(RetailChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChannelTimeZone = group.Add(new VocabularyKey(nameof(ChannelTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChannelTimeZoneInfoId = group.Add(new VocabularyKey(nameof(ChannelTimeZoneInfoId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCustomerAccount = group.Add(new VocabularyKey(nameof(DefaultCustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCustomerLegalEntity = group.Add(new VocabularyKey(nameof(DefaultCustomerLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxGroupCode = group.Add(new VocabularyKey(nameof(TaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxGroupLegalEntity = group.Add(new VocabularyKey(nameof(TaxGroupLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChannelType = group.Add(new VocabularyKey(nameof(ChannelType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EventNotificationProfileId = group.Add(new VocabularyKey(nameof(EventNotificationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventLocation = group.Add(new VocabularyKey(nameof(InventLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventLocationDataAreaId = group.Add(new VocabularyKey(nameof(InventLocationDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OMOperatingUnitID = group.Add(new VocabularyKey(nameof(OMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Payment = group.Add(new VocabularyKey(nameof(Payment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymMode = group.Add(new VocabularyKey(nameof(PaymMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceIncludesSalesTax = group.Add(new VocabularyKey(nameof(PriceIncludesSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StoreArea = group.Add(new VocabularyKey(nameof(StoreArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionServiceProfile = group.Add(new VocabularyKey(nameof(TransactionServiceProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisplayTaxPerTaxComponent = group.Add(new VocabularyKey(nameof(DisplayTaxPerTaxComponent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MCRCustomerCreditRetailInfocodeId = group.Add(new VocabularyKey(nameof(MCRCustomerCreditRetailInfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MCREnableDirectedSelling = group.Add(new VocabularyKey(nameof(MCREnableDirectedSelling), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MCREnableOrderCompletion = group.Add(new VocabularyKey(nameof(MCREnableOrderCompletion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MCREnableOrderPriceControl = group.Add(new VocabularyKey(nameof(MCREnableOrderPriceControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MCRPriceOverrideRetailInfocodeId = group.Add(new VocabularyKey(nameof(MCRPriceOverrideRetailInfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MCRReasonCodeRetailInfocodeId = group.Add(new VocabularyKey(nameof(MCRReasonCodeRetailInfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OnlineCatalogName = group.Add(new VocabularyKey(nameof(OnlineCatalogName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
closingMethod = group.Add(new VocabularyKey(nameof(closingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createLabelsForZeroPrice = group.Add(new VocabularyKey(nameof(createLabelsForZeroPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
cultureName = group.Add(new VocabularyKey(nameof(cultureName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DatabaseName = group.Add(new VocabularyKey(nameof(DatabaseName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EFTStoreNumber = group.Add(new VocabularyKey(nameof(EFTStoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
functionalityProfile = group.Add(new VocabularyKey(nameof(functionalityProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
generatesItemLabels = group.Add(new VocabularyKey(nameof(generatesItemLabels), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
generatesShelfLabels = group.Add(new VocabularyKey(nameof(generatesShelfLabels), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
hideTrainingMode = group.Add(new VocabularyKey(nameof(hideTrainingMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventLocationIdForCustomerOrder = group.Add(new VocabularyKey(nameof(InventLocationIdForCustomerOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
inventoryLookup = group.Add(new VocabularyKey(nameof(inventoryLookup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
itemIdOnReceipt = group.Add(new VocabularyKey(nameof(itemIdOnReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maximumPostingDifference = group.Add(new VocabularyKey(nameof(maximumPostingDifference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maximumTextLengthOnReceipt = group.Add(new VocabularyKey(nameof(maximumTextLengthOnReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maxRoundingAmount = group.Add(new VocabularyKey(nameof(maxRoundingAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maxRoundingTaxAmount = group.Add(new VocabularyKey(nameof(maxRoundingTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maxShiftDifferenceAmount = group.Add(new VocabularyKey(nameof(maxShiftDifferenceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maxTransactionDifferenceAmount = group.Add(new VocabularyKey(nameof(maxTransactionDifferenceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
numberOfTopOrBottomLines = group.Add(new VocabularyKey(nameof(numberOfTopOrBottomLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OfflineProfile = group.Add(new VocabularyKey(nameof(OfflineProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
oneStatementPerDay = group.Add(new VocabularyKey(nameof(oneStatementPerDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
openFrom = group.Add(new VocabularyKey(nameof(openFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
openTo = group.Add(new VocabularyKey(nameof(openTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
phone = group.Add(new VocabularyKey(nameof(phone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
poItemFilter = group.Add(new VocabularyKey(nameof(poItemFilter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
removeAddTender = group.Add(new VocabularyKey(nameof(removeAddTender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailReqPlanIdSched = group.Add(new VocabularyKey(nameof(RetailReqPlanIdSched), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReturnTaxGroup_W = group.Add(new VocabularyKey(nameof(ReturnTaxGroup_W), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoundingAccountLedgerDimension = group.Add(new VocabularyKey(nameof(RoundingAccountLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
roundingTaxAccount = group.Add(new VocabularyKey(nameof(roundingTaxAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
separateStmtPerStaffTerminal = group.Add(new VocabularyKey(nameof(separateStmtPerStaffTerminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
serviceChargePct = group.Add(new VocabularyKey(nameof(serviceChargePct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
serviceChargePrompt = group.Add(new VocabularyKey(nameof(serviceChargePrompt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SQLServerName = group.Add(new VocabularyKey(nameof(SQLServerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statementMethod = group.Add(new VocabularyKey(nameof(statementMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stmtCalcBatchEndTime = group.Add(new VocabularyKey(nameof(stmtCalcBatchEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stmtPostAsBusinessDay = group.Add(new VocabularyKey(nameof(stmtPostAsBusinessDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxIdentificationNumber = group.Add(new VocabularyKey(nameof(TaxIdentificationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxOverrideGroup = group.Add(new VocabularyKey(nameof(TaxOverrideGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
tenderDeclarationCalculation = group.Add(new VocabularyKey(nameof(tenderDeclarationCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseCustomerBasedTax = group.Add(new VocabularyKey(nameof(UseCustomerBasedTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseDefaultCustAccount = group.Add(new VocabularyKey(nameof(UseDefaultCustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseDestinationBasedTax = group.Add(new VocabularyKey(nameof(UseDestinationBasedTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserName = group.Add(new VocabularyKey(nameof(UserName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OfflineProfileName = group.Add(new VocabularyKey(nameof(OfflineProfileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoundingAccountLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(RoundingAccountLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryHierarchy = group.Add(new VocabularyKey(nameof(CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChannelProfileName = group.Add(new VocabularyKey(nameof(ChannelProfileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LiveDatabaseConnectionProfileName = group.Add(new VocabularyKey(nameof(LiveDatabaseConnectionProfileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitPartyNumber = group.Add(new VocabularyKey(nameof(OperatingUnitPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxOverrideGroupCode = group.Add(new VocabularyKey(nameof(TaxOverrideGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ManualAccept = group.Add(new VocabularyKey(nameof(ManualAccept), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseCustomerBasedTaxExemption = group.Add(new VocabularyKey(nameof(UseCustomerBasedTaxExemption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailReturnPolicyChannel = group.Add(new VocabularyKey(nameof(RetailReturnPolicyChannel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CalcExemptTaxesForPriceInclusive = group.Add(new VocabularyKey(nameof(CalcExemptTaxesForPriceInclusive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey RetailChannelId { get; private set; }
public VocabularyKey ChannelTimeZone { get; private set; }
public VocabularyKey ChannelTimeZoneInfoId { get; private set; }
public VocabularyKey DefaultCustomerAccount { get; private set; }
public VocabularyKey DefaultCustomerLegalEntity { get; private set; }
public VocabularyKey TaxGroupCode { get; private set; }
public VocabularyKey TaxGroupLegalEntity { get; private set; }
public VocabularyKey ChannelType { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey DefaultDimension { get; private set; }
public VocabularyKey EventNotificationProfileId { get; private set; }
public VocabularyKey InventLocation { get; private set; }
public VocabularyKey InventLocationDataAreaId { get; private set; }
public VocabularyKey OMOperatingUnitID { get; private set; }
public VocabularyKey Payment { get; private set; }
public VocabularyKey PaymMode { get; private set; }
public VocabularyKey PriceIncludesSalesTax { get; private set; }
public VocabularyKey StoreArea { get; private set; }
public VocabularyKey TransactionServiceProfile { get; private set; }
public VocabularyKey DisplayTaxPerTaxComponent { get; private set; }
public VocabularyKey CategoryHierarchyName { get; private set; }
public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
public VocabularyKey MCRCustomerCreditRetailInfocodeId { get; private set; }
public VocabularyKey MCREnableDirectedSelling { get; private set; }
public VocabularyKey MCREnableOrderCompletion { get; private set; }
public VocabularyKey MCREnableOrderPriceControl { get; private set; }
public VocabularyKey MCRPriceOverrideRetailInfocodeId { get; private set; }
public VocabularyKey MCRReasonCodeRetailInfocodeId { get; private set; }
public VocabularyKey OnlineCatalogName { get; private set; }
public VocabularyKey closingMethod { get; private set; }
public VocabularyKey createLabelsForZeroPrice { get; private set; }
public VocabularyKey cultureName { get; private set; }
public VocabularyKey DatabaseName { get; private set; }
public VocabularyKey EFTStoreNumber { get; private set; }
public VocabularyKey functionalityProfile { get; private set; }
public VocabularyKey generatesItemLabels { get; private set; }
public VocabularyKey generatesShelfLabels { get; private set; }
public VocabularyKey hideTrainingMode { get; private set; }
public VocabularyKey InventLocationIdForCustomerOrder { get; private set; }
public VocabularyKey inventoryLookup { get; private set; }
public VocabularyKey itemIdOnReceipt { get; private set; }
public VocabularyKey maximumPostingDifference { get; private set; }
public VocabularyKey maximumTextLengthOnReceipt { get; private set; }
public VocabularyKey maxRoundingAmount { get; private set; }
public VocabularyKey maxRoundingTaxAmount { get; private set; }
public VocabularyKey maxShiftDifferenceAmount { get; private set; }
public VocabularyKey maxTransactionDifferenceAmount { get; private set; }
public VocabularyKey numberOfTopOrBottomLines { get; private set; }
public VocabularyKey OfflineProfile { get; private set; }
public VocabularyKey oneStatementPerDay { get; private set; }
public VocabularyKey openFrom { get; private set; }
public VocabularyKey openTo { get; private set; }
public VocabularyKey phone { get; private set; }
public VocabularyKey poItemFilter { get; private set; }
public VocabularyKey removeAddTender { get; private set; }
public VocabularyKey RetailReqPlanIdSched { get; private set; }
public VocabularyKey ReturnTaxGroup_W { get; private set; }
public VocabularyKey RoundingAccountLedgerDimension { get; private set; }
public VocabularyKey roundingTaxAccount { get; private set; }
public VocabularyKey separateStmtPerStaffTerminal { get; private set; }
public VocabularyKey serviceChargePct { get; private set; }
public VocabularyKey serviceChargePrompt { get; private set; }
public VocabularyKey SQLServerName { get; private set; }
public VocabularyKey statementMethod { get; private set; }
public VocabularyKey stmtCalcBatchEndTime { get; private set; }
public VocabularyKey stmtPostAsBusinessDay { get; private set; }
public VocabularyKey StoreNumber { get; private set; }
public VocabularyKey TaxIdentificationNumber { get; private set; }
public VocabularyKey TaxOverrideGroup { get; private set; }
public VocabularyKey tenderDeclarationCalculation { get; private set; }
public VocabularyKey UseCustomerBasedTax { get; private set; }
public VocabularyKey UseDefaultCustAccount { get; private set; }
public VocabularyKey UseDestinationBasedTax { get; private set; }
public VocabularyKey UserName { get; private set; }
public VocabularyKey OperatingUnitNumber { get; private set; }
public VocabularyKey OfflineProfileName { get; private set; }
public VocabularyKey RoundingAccountLedgerDimensionDisplayValue { get; private set; }
public VocabularyKey CategoryHierarchy { get; private set; }
public VocabularyKey ChannelProfileName { get; private set; }
public VocabularyKey LiveDatabaseConnectionProfileName { get; private set; }
public VocabularyKey OperatingUnitPartyNumber { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey TaxOverrideGroupCode { get; private set; }
public VocabularyKey ManualAccept { get; private set; }
public VocabularyKey UseCustomerBasedTaxExemption { get; private set; }
public VocabularyKey RetailReturnPolicyChannel { get; private set; }
public VocabularyKey CalcExemptTaxesForPriceInclusive { get; private set; }


    }
}