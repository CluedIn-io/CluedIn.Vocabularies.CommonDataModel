using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class PriceListItemVocabulary : SimpleVocabulary
    {
        public PriceListItemVocabulary()
        {
            VocabularyName = "Price List Item";
            KeyPrefix = "commonDataModel.pricelistitem.foundationcommon";
            KeySeparator = ".";
            Grouping = "/PriceListItem";

            AddGroup("PriceListItem Details for FoundationCommon", group =>
            {
			    ProductPriceLevelId = group.Add(new VocabularyKey(nameof(ProductPriceLevelId), "Product Price List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationId = group.Add(new VocabularyKey(nameof(OrganizationId), "Organization", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    Percentage = group.Add(new VocabularyKey(nameof(Percentage), "Percentage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PricingMethodCode = group.Add(new VocabularyKey(nameof(PricingMethodCode), "Pricing Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), "Product ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QuantitySellingCode = group.Add(new VocabularyKey(nameof(QuantitySellingCode), "Quantity Selling Option", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RoundingOptionAmount = group.Add(new VocabularyKey(nameof(RoundingOptionAmount), "Rounding Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RoundingOptionAmountBase = group.Add(new VocabularyKey(nameof(RoundingOptionAmountBase), "Rounding Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RoundingOptionCode = group.Add(new VocabularyKey(nameof(RoundingOptionCode), "Rounding Option", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RoundingPolicyCode = group.Add(new VocabularyKey(nameof(RoundingPolicyCode), "Rounding Policy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ProductPriceLevelId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
        public VocabularyKey Percentage { get; private set; }
        public VocabularyKey PricingMethodCode { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey QuantitySellingCode { get; private set; }
        public VocabularyKey RoundingOptionAmount { get; private set; }
        public VocabularyKey RoundingOptionAmountBase { get; private set; }
        public VocabularyKey RoundingOptionCode { get; private set; }
        public VocabularyKey RoundingPolicyCode { get; private set; }
    }
}