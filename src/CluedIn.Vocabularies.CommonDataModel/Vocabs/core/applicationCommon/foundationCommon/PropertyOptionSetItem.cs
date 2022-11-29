using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class PropertyOptionSetItemVocabulary : SimpleVocabulary
    {
        public PropertyOptionSetItemVocabulary()
        {
            VocabularyName = "Property Option Set Item";
            KeyPrefix = "commonDataModel.propertyoptionsetitem.foundationcommon";
            KeySeparator = ".";
            Grouping = "/PropertyOptionSetItem";

            AddGroup("PropertyOptionSetItem Details for FoundationCommon", group =>
            {
			    DynamicPropertyOptionSetValueId = group.Add(new VocabularyKey(nameof(DynamicPropertyOptionSetValueId), "Property Option Set ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DynamicPropertyOptionName = group.Add(new VocabularyKey(nameof(DynamicPropertyOptionName), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DynamicPropertyOptionValue = group.Add(new VocabularyKey(nameof(DynamicPropertyOptionValue), "Value", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DynamicPropertyOptionDescription = group.Add(new VocabularyKey(nameof(DynamicPropertyOptionDescription), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DynamicPropertyOptionSetValueSequenceNumber = group.Add(new VocabularyKey(nameof(DynamicPropertyOptionSetValueSequenceNumber), "Internal Use Only", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DynamicPropertyOptionSetValueId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey DynamicPropertyOptionName { get; private set; }
        public VocabularyKey DynamicPropertyOptionValue { get; private set; }
        public VocabularyKey DynamicPropertyOptionDescription { get; private set; }
        public VocabularyKey DynamicPropertyOptionSetValueSequenceNumber { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}