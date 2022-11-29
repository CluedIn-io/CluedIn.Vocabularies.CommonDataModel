using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ActivityDefinitionUseContextVocabulary : SimpleVocabulary
    {
        public ActivityDefinitionUseContextVocabulary()
        {
            VocabularyName = "Activity Definition Use Context";
            KeyPrefix = "commonDataModel.activitydefinitionusecontext.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ActivityDefinitionUseContext";

            AddGroup("ActivityDefinitionUseContext Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityDefinitionUseContextId = group.Add(new VocabularyKey(nameof(ActivityDefinitionUseContextId), "Activity Definition Use Context", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CodeType = group.Add(new VocabularyKey(nameof(CodeType), "Code Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QuantityComparator = group.Add(new VocabularyKey(nameof(QuantityComparator), "Quantity Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QuantitySystem = group.Add(new VocabularyKey(nameof(QuantitySystem), "Quantity System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QuantityUnit = group.Add(new VocabularyKey(nameof(QuantityUnit), "Quantity Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QuantityValue = group.Add(new VocabularyKey(nameof(QuantityValue), "Quantity Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Valuelowerlimit = group.Add(new VocabularyKey(nameof(Valuelowerlimit), "Lower Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueType = group.Add(new VocabularyKey(nameof(ValueType), "Value Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Valueupperlimit = group.Add(new VocabularyKey(nameof(Valueupperlimit), "Upper Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey ActivityDefinitionUseContextId { get; private set; }
        public VocabularyKey CodeType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey QuantityComparator { get; private set; }
        public VocabularyKey QuantitySystem { get; private set; }
        public VocabularyKey QuantityUnit { get; private set; }
        public VocabularyKey QuantityValue { get; private set; }
        public VocabularyKey Valuelowerlimit { get; private set; }
        public VocabularyKey ValueType { get; private set; }
        public VocabularyKey Valueupperlimit { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}