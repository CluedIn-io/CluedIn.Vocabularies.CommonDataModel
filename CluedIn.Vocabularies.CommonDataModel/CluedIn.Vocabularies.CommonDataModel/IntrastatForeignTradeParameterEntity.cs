using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntrastatForeignTradeParameterEntityVocabulary : SimpleVocabulary
    {
        public IntrastatForeignTradeParameterEntityVocabulary()
        {
            VocabularyName = "Common Data Model IntrastatForeignTradeParameterEntity";
            KeyPrefix = "commonDataModel.intrastatforeigntradeparameterentity";
            KeySeparator = ".";
            Grouping = "/IntrastatForeignTradeParameterEntity";

            AddGroup("Common Data Model IntrastatForeignTradeParameterEntity Details", group =>
            {
                AdditionalUnits = group.Add(new VocabularyKey(nameof(AdditionalUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgentBranchId = group.Add(new VocabularyKey(nameof(AgentBranchId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgentLocation = group.Add(new VocabularyKey(nameof(AgentLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgentName = group.Add(new VocabularyKey(nameof(AgentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgentPhone = group.Add(new VocabularyKey(nameof(AgentPhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgentFax = group.Add(new VocabularyKey(nameof(AgentFax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgentTaxExemptNumber = group.Add(new VocabularyKey(nameof(AgentTaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactEmail = group.Add(new VocabularyKey(nameof(ContactEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactName = group.Add(new VocabularyKey(nameof(ContactName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPhone = group.Add(new VocabularyKey(nameof(ContactPhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactFax = group.Add(new VocabularyKey(nameof(ContactFax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactURL = group.Add(new VocabularyKey(nameof(ContactURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditNote = group.Add(new VocabularyKey(nameof(CreditNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatLowWeightRounding = group.Add(new VocabularyKey(nameof(IntrastatLowWeightRounding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransferOrder = group.Add(new VocabularyKey(nameof(TransferOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionCode = group.Add(new VocabularyKey(nameof(TransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TermsOfDelivery = group.Add(new VocabularyKey(nameof(TermsOfDelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommodityCode = group.Add(new VocabularyKey(nameof(CommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatAmountRoundingMethod = group.Add(new VocabularyKey(nameof(IntrastatAmountRoundingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatAmountRoundingRule = group.Add(new VocabularyKey(nameof(IntrastatAmountRoundingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatAmountDecimals = group.Add(new VocabularyKey(nameof(IntrastatAmountDecimals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatWeightRoundingRule = group.Add(new VocabularyKey(nameof(IntrastatWeightRoundingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatWeightRoundingMethod = group.Add(new VocabularyKey(nameof(IntrastatWeightRoundingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatWeightDecimals = group.Add(new VocabularyKey(nameof(IntrastatWeightDecimals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatAmountRoundOffUseMinimumValue = group.Add(new VocabularyKey(nameof(IntrastatAmountRoundOffUseMinimumValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Commodity = group.Add(new VocabularyKey(nameof(Commodity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaxAmount = group.Add(new VocabularyKey(nameof(MaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaxWeight = group.Add(new VocabularyKey(nameof(MaxWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransferWhenMeetingCriterionFor = group.Add(new VocabularyKey(nameof(TransferWhenMeetingCriterionFor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Origin = group.Add(new VocabularyKey(nameof(Origin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Port = group.Add(new VocabularyKey(nameof(Port), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PortParm = group.Add(new VocabularyKey(nameof(PortParm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportLevelExport = group.Add(new VocabularyKey(nameof(ReportLevelExport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportLevelImport = group.Add(new VocabularyKey(nameof(ReportLevelImport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StateOrProvince = group.Add(new VocabularyKey(nameof(StateOrProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionCodes = group.Add(new VocabularyKey(nameof(TransactionCodes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NonserviceItems = group.Add(new VocabularyKey(nameof(NonserviceItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemsWithCommodityCode = group.Add(new VocabularyKey(nameof(ItemsWithCommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemsWithAdditionalUnits = group.Add(new VocabularyKey(nameof(ItemsWithAdditionalUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemsWithWeight = group.Add(new VocabularyKey(nameof(ItemsWithWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Transport = group.Add(new VocabularyKey(nameof(Transport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportModeCode = group.Add(new VocabularyKey(nameof(TransportModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryTerms = group.Add(new VocabularyKey(nameof(DeliveryTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRateType = group.Add(new VocabularyKey(nameof(ExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Weight = group.Add(new VocabularyKey(nameof(Weight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CheckStatisticProcedure = group.Add(new VocabularyKey(nameof(CheckStatisticProcedure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StatisticProcedure = group.Add(new VocabularyKey(nameof(StatisticProcedure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommodityHierarchyName = group.Add(new VocabularyKey(nameof(CommodityHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrintExportStatisticalReport = group.Add(new VocabularyKey(nameof(PrintExportStatisticalReport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CheckQty = group.Add(new VocabularyKey(nameof(CheckQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CheckCountryRegionSenderReceiver = group.Add(new VocabularyKey(nameof(CheckCountryRegionSenderReceiver), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CheckStateSenderReceiver = group.Add(new VocabularyKey(nameof(CheckStateSenderReceiver), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountyOriginDestination = group.Add(new VocabularyKey(nameof(CountyOriginDestination), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseReportingPeriod = group.Add(new VocabularyKey(nameof(PurchaseReportingPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesReportingPeriod = group.Add(new VocabularyKey(nameof(SalesReportingPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompanyInfoLocationId = group.Add(new VocabularyKey(nameof(CompanyInfoLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompanyInfoDataAreaId = group.Add(new VocabularyKey(nameof(CompanyInfoDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatFileERVendorUrl = group.Add(new VocabularyKey(nameof(IntrastatFileERVendorUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatFileERSolutionName = group.Add(new VocabularyKey(nameof(IntrastatFileERSolutionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatFileERFormatName = group.Add(new VocabularyKey(nameof(IntrastatFileERFormatName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatReportERVendorUrl = group.Add(new VocabularyKey(nameof(IntrastatReportERVendorUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatReportERSolutionName = group.Add(new VocabularyKey(nameof(IntrastatReportERSolutionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatReportERFormatName = group.Add(new VocabularyKey(nameof(IntrastatReportERFormatName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLTransferCashDiscount = group.Add(new VocabularyKey(nameof(ESLTransferCashDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLTransferPurchases = group.Add(new VocabularyKey(nameof(ESLTransferPurchases), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLAmountDecimals = group.Add(new VocabularyKey(nameof(ESLAmountDecimals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLAmountRoundOff = group.Add(new VocabularyKey(nameof(ESLAmountRoundOff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLAmountRoundOffType = group.Add(new VocabularyKey(nameof(ESLAmountRoundOffType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLAmountRoundOffUseMinimumValue = group.Add(new VocabularyKey(nameof(ESLAmountRoundOffUseMinimumValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLAuthorizedByRole = group.Add(new VocabularyKey(nameof(ESLAuthorizedByRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLAuthorizedByWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(ESLAuthorizedByWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLCompanyBuildingNumber = group.Add(new VocabularyKey(nameof(ESLCompanyBuildingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLCompanyDoorNumber = group.Add(new VocabularyKey(nameof(ESLCompanyDoorNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLCompanyFloorNumber = group.Add(new VocabularyKey(nameof(ESLCompanyFloorNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLCompanyStairwayNumber = group.Add(new VocabularyKey(nameof(ESLCompanyStairwayNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLCompanyNameAppendix = group.Add(new VocabularyKey(nameof(ESLCompanyNameAppendix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLFilledByWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(ESLFilledByWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLTaxAuthority = group.Add(new VocabularyKey(nameof(ESLTaxAuthority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLFileERVendorUrl = group.Add(new VocabularyKey(nameof(ESLFileERVendorUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLFileERSolutionName = group.Add(new VocabularyKey(nameof(ESLFileERSolutionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLFileERFormatName = group.Add(new VocabularyKey(nameof(ESLFileERFormatName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLReportERVendorUrl = group.Add(new VocabularyKey(nameof(ESLReportERVendorUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLReportERSolutionName = group.Add(new VocabularyKey(nameof(ESLReportERSolutionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESLReportERFormatName = group.Add(new VocabularyKey(nameof(ESLReportERFormatName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatCheckFulfillmentDate = group.Add(new VocabularyKey(nameof(IntrastatCheckFulfillmentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatCalcMethod = group.Add(new VocabularyKey(nameof(IntrastatCalcMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatFulfillmentDateEmptyWarning = group.Add(new VocabularyKey(nameof(IntrastatFulfillmentDateEmptyWarning), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatSpecMove = group.Add(new VocabularyKey(nameof(IntrastatSpecMove), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatSpecificMovement = group.Add(new VocabularyKey(nameof(IntrastatSpecificMovement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AdditionalUnits { get; private set; }
public VocabularyKey AgentBranchId { get; private set; }
public VocabularyKey AgentLocation { get; private set; }
public VocabularyKey AgentName { get; private set; }
public VocabularyKey AgentPhone { get; private set; }
public VocabularyKey AgentFax { get; private set; }
public VocabularyKey AgentTaxExemptNumber { get; private set; }
public VocabularyKey ContactEmail { get; private set; }
public VocabularyKey ContactName { get; private set; }
public VocabularyKey ContactPhone { get; private set; }
public VocabularyKey ContactFax { get; private set; }
public VocabularyKey ContactURL { get; private set; }
public VocabularyKey CountryRegion { get; private set; }
public VocabularyKey CreditNote { get; private set; }
public VocabularyKey IntrastatLowWeightRounding { get; private set; }
public VocabularyKey TransferOrder { get; private set; }
public VocabularyKey TransactionCode { get; private set; }
public VocabularyKey TermsOfDelivery { get; private set; }
public VocabularyKey Worker { get; private set; }
public VocabularyKey CommodityCode { get; private set; }
public VocabularyKey IntrastatAmountRoundingMethod { get; private set; }
public VocabularyKey IntrastatAmountRoundingRule { get; private set; }
public VocabularyKey IntrastatAmountDecimals { get; private set; }
public VocabularyKey IntrastatWeightRoundingRule { get; private set; }
public VocabularyKey IntrastatWeightRoundingMethod { get; private set; }
public VocabularyKey IntrastatWeightDecimals { get; private set; }
public VocabularyKey IntrastatAmountRoundOffUseMinimumValue { get; private set; }
public VocabularyKey Commodity { get; private set; }
public VocabularyKey ID { get; private set; }
public VocabularyKey MaxAmount { get; private set; }
public VocabularyKey MaxWeight { get; private set; }
public VocabularyKey TransferWhenMeetingCriterionFor { get; private set; }
public VocabularyKey Origin { get; private set; }
public VocabularyKey Port { get; private set; }
public VocabularyKey PortParm { get; private set; }
public VocabularyKey ReportLevelExport { get; private set; }
public VocabularyKey ReportLevelImport { get; private set; }
public VocabularyKey StateOrProvince { get; private set; }
public VocabularyKey TransactionCodes { get; private set; }
public VocabularyKey NonserviceItems { get; private set; }
public VocabularyKey ItemsWithCommodityCode { get; private set; }
public VocabularyKey ItemsWithAdditionalUnits { get; private set; }
public VocabularyKey ItemsWithWeight { get; private set; }
public VocabularyKey Transport { get; private set; }
public VocabularyKey TransportModeCode { get; private set; }
public VocabularyKey DeliveryTerms { get; private set; }
public VocabularyKey Amount { get; private set; }
public VocabularyKey ExchangeRateType { get; private set; }
public VocabularyKey Weight { get; private set; }
public VocabularyKey CheckStatisticProcedure { get; private set; }
public VocabularyKey StatisticProcedure { get; private set; }
public VocabularyKey TaxExemptNumber { get; private set; }
public VocabularyKey CommodityHierarchyName { get; private set; }
public VocabularyKey PrintExportStatisticalReport { get; private set; }
public VocabularyKey County { get; private set; }
public VocabularyKey CheckQty { get; private set; }
public VocabularyKey CheckCountryRegionSenderReceiver { get; private set; }
public VocabularyKey CheckStateSenderReceiver { get; private set; }
public VocabularyKey CountyOriginDestination { get; private set; }
public VocabularyKey PurchaseReportingPeriod { get; private set; }
public VocabularyKey SalesReportingPeriod { get; private set; }
public VocabularyKey CompanyInfoLocationId { get; private set; }
public VocabularyKey CompanyInfoDataAreaId { get; private set; }
public VocabularyKey IntrastatFileERVendorUrl { get; private set; }
public VocabularyKey IntrastatFileERSolutionName { get; private set; }
public VocabularyKey IntrastatFileERFormatName { get; private set; }
public VocabularyKey IntrastatReportERVendorUrl { get; private set; }
public VocabularyKey IntrastatReportERSolutionName { get; private set; }
public VocabularyKey IntrastatReportERFormatName { get; private set; }
public VocabularyKey ESLTransferCashDiscount { get; private set; }
public VocabularyKey ESLTransferPurchases { get; private set; }
public VocabularyKey ESLAmountDecimals { get; private set; }
public VocabularyKey ESLAmountRoundOff { get; private set; }
public VocabularyKey ESLAmountRoundOffType { get; private set; }
public VocabularyKey ESLAmountRoundOffUseMinimumValue { get; private set; }
public VocabularyKey ESLAuthorizedByRole { get; private set; }
public VocabularyKey ESLAuthorizedByWorkerPersonnelNumber { get; private set; }
public VocabularyKey ESLCompanyBuildingNumber { get; private set; }
public VocabularyKey ESLCompanyDoorNumber { get; private set; }
public VocabularyKey ESLCompanyFloorNumber { get; private set; }
public VocabularyKey ESLCompanyStairwayNumber { get; private set; }
public VocabularyKey ESLCompanyNameAppendix { get; private set; }
public VocabularyKey ESLFilledByWorkerPersonnelNumber { get; private set; }
public VocabularyKey ESLTaxAuthority { get; private set; }
public VocabularyKey ESLFileERVendorUrl { get; private set; }
public VocabularyKey ESLFileERSolutionName { get; private set; }
public VocabularyKey ESLFileERFormatName { get; private set; }
public VocabularyKey ESLReportERVendorUrl { get; private set; }
public VocabularyKey ESLReportERSolutionName { get; private set; }
public VocabularyKey ESLReportERFormatName { get; private set; }
public VocabularyKey IntrastatCheckFulfillmentDate { get; private set; }
public VocabularyKey IntrastatCalcMethod { get; private set; }
public VocabularyKey IntrastatFulfillmentDateEmptyWarning { get; private set; }
public VocabularyKey IntrastatSpecMove { get; private set; }
public VocabularyKey IntrastatSpecificMovement { get; private set; }


    }
}