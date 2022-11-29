using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ResourceCategoryPriceLevelVocabulary : SimpleVocabulary
    {
        public ResourceCategoryPriceLevelVocabulary()
        {
            VocabularyName = "Resource Category Price Level";
            KeyPrefix = "commonDataModel.resourcecategorypricelevel.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ResourceCategoryPriceLevel";

            AddGroup("ResourceCategoryPriceLevel Details for ProjectServiceAutomation", group =>
            {
			    ResourceCategoryPriceLevelId = group.Add(new VocabularyKey(nameof(ResourceCategoryPriceLevelId), "Resource Category Price", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Percent = group.Add(new VocabularyKey(nameof(Percent), "Percent", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Price = group.Add(new VocabularyKey(nameof(Price), "Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PriceBase = group.Add(new VocabularyKey(nameof(PriceBase), "Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PriceCalculation = group.Add(new VocabularyKey(nameof(PriceCalculation), "Price Calculation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PriceInPrimaryUnit = group.Add(new VocabularyKey(nameof(PriceInPrimaryUnit), "Price In Primary Unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceInPrimaryUnitBase = group.Add(new VocabularyKey(nameof(PriceInPrimaryUnitBase), "Price In Primary Unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ResourceCategoryPriceLevelId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Percent { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey PriceBase { get; private set; }
        public VocabularyKey PriceCalculation { get; private set; }
        public VocabularyKey PriceInPrimaryUnit { get; private set; }
        public VocabularyKey PriceInPrimaryUnitBase { get; private set; }
    }
}