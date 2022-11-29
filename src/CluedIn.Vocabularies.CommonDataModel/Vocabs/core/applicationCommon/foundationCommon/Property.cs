using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class PropertyVocabulary : SimpleVocabulary
    {
        public PropertyVocabulary()
        {
            VocabularyName = "Property";
            KeyPrefix = "commonDataModel.property.foundationcommon";
            KeySeparator = ".";
            Grouping = "/Property";

            AddGroup("Property Details for FoundationCommon", group =>
            {
			    DynamicPropertyId = group.Add(new VocabularyKey(nameof(DynamicPropertyId), "Property ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataType = group.Add(new VocabularyKey(nameof(DataType), "Data Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefaultValueInteger = group.Add(new VocabularyKey(nameof(DefaultValueInteger), "Default Whole Number Value", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DefaultValueString = group.Add(new VocabularyKey(nameof(DefaultValueString), "Default String Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefaultValueDecimal = group.Add(new VocabularyKey(nameof(DefaultValueDecimal), "Default Decimal Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    OverwrittenDynamicPropertyId = group.Add(new VocabularyKey(nameof(OverwrittenDynamicPropertyId), "Overwritten Property", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    RootDynamicPropertyId = group.Add(new VocabularyKey(nameof(RootDynamicPropertyId), "Root Property", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    MinValueDecimal = group.Add(new VocabularyKey(nameof(MinValueDecimal), "Minimum Decimal Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    MaxValueDecimal = group.Add(new VocabularyKey(nameof(MaxValueDecimal), "Maximum Decimal Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Precision = group.Add(new VocabularyKey(nameof(Precision), "Precision", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefaultValueDouble = group.Add(new VocabularyKey(nameof(DefaultValueDouble), "Default Double Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    MinValueDouble = group.Add(new VocabularyKey(nameof(MinValueDouble), "Minimum Double Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    MaxValueDouble = group.Add(new VocabularyKey(nameof(MaxValueDouble), "Maximum Double Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    MinValueInteger = group.Add(new VocabularyKey(nameof(MinValueInteger), "Minimum Whole Number Value", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    MaxValueInteger = group.Add(new VocabularyKey(nameof(MaxValueInteger), "Maximum Whole Number Value", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IsReadOnly = group.Add(new VocabularyKey(nameof(IsReadOnly), "Read-Only", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsHidden = group.Add(new VocabularyKey(nameof(IsHidden), "Hidden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsRequired = group.Add(new VocabularyKey(nameof(IsRequired), "Required", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MaxLengthString = group.Add(new VocabularyKey(nameof(MaxLengthString), "Maximum String Length", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DynamicPropertyId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DataType { get; private set; }
        public VocabularyKey DefaultValueInteger { get; private set; }
        public VocabularyKey DefaultValueString { get; private set; }
        public VocabularyKey DefaultValueDecimal { get; private set; }
        public VocabularyKey OverwrittenDynamicPropertyId { get; private set; }
        public VocabularyKey RootDynamicPropertyId { get; private set; }
        public VocabularyKey MinValueDecimal { get; private set; }
        public VocabularyKey MaxValueDecimal { get; private set; }
        public VocabularyKey Precision { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey DefaultValueDouble { get; private set; }
        public VocabularyKey MinValueDouble { get; private set; }
        public VocabularyKey MaxValueDouble { get; private set; }
        public VocabularyKey MinValueInteger { get; private set; }
        public VocabularyKey MaxValueInteger { get; private set; }
        public VocabularyKey IsReadOnly { get; private set; }
        public VocabularyKey IsHidden { get; private set; }
        public VocabularyKey IsRequired { get; private set; }
        public VocabularyKey MaxLengthString { get; private set; }
    }
}