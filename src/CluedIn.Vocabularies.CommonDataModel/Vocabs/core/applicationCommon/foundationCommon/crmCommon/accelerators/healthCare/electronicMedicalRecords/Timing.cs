using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class TimingVocabulary : SimpleVocabulary
    {
        public TimingVocabulary()
        {
            VocabularyName = "Timing";
            KeyPrefix = "commonDataModel.timing.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Timing";

            AddGroup("Timing Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RepeatBoundDuration = group.Add(new VocabularyKey(nameof(RepeatBoundDuration), "Repeat Bound Duration", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RepeatboundsType = group.Add(new VocabularyKey(nameof(RepeatboundsType), "Repeat Bound Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RepeatboundsTypePeriodEndDate = group.Add(new VocabularyKey(nameof(RepeatboundsTypePeriodEndDate), "Bound Type Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RepeatboundsTypePeriodStartDate = group.Add(new VocabularyKey(nameof(RepeatboundsTypePeriodStartDate), "Bound Type Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RepeatboundsTypeRangeHigh = group.Add(new VocabularyKey(nameof(RepeatboundsTypeRangeHigh), "Bound Type Range High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RepeatboundsTypeRangeLow = group.Add(new VocabularyKey(nameof(RepeatboundsTypeRangeLow), "Bound Type Range Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RepeatCount = group.Add(new VocabularyKey(nameof(RepeatCount), "Repeat Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RepeatCountMax = group.Add(new VocabularyKey(nameof(RepeatCountMax), "Count Max", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RepeatDuration = group.Add(new VocabularyKey(nameof(RepeatDuration), "Duration", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RepeatDurationMax = group.Add(new VocabularyKey(nameof(RepeatDurationMax), "Duration Max", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RepeatDurationUnit = group.Add(new VocabularyKey(nameof(RepeatDurationUnit), "Duration Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RepeatFrequency = group.Add(new VocabularyKey(nameof(RepeatFrequency), "Frequency", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RepeatFrequencyMax = group.Add(new VocabularyKey(nameof(RepeatFrequencyMax), "Frequency Max", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RepeatOffset = group.Add(new VocabularyKey(nameof(RepeatOffset), "Repeat Offset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RepeatPeriod = group.Add(new VocabularyKey(nameof(RepeatPeriod), "Repeat Period", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RepeatPeriodMax = group.Add(new VocabularyKey(nameof(RepeatPeriodMax), "Repeat Period Max", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RepeatPeriodUnit = group.Add(new VocabularyKey(nameof(RepeatPeriodUnit), "Repeat Period Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimingId = group.Add(new VocabularyKey(nameof(TimingId), "Timing", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
        public VocabularyKey Code { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RepeatBoundDuration { get; private set; }
        public VocabularyKey RepeatboundsType { get; private set; }
        public VocabularyKey RepeatboundsTypePeriodEndDate { get; private set; }
        public VocabularyKey RepeatboundsTypePeriodStartDate { get; private set; }
        public VocabularyKey RepeatboundsTypeRangeHigh { get; private set; }
        public VocabularyKey RepeatboundsTypeRangeLow { get; private set; }
        public VocabularyKey RepeatCount { get; private set; }
        public VocabularyKey RepeatCountMax { get; private set; }
        public VocabularyKey RepeatDuration { get; private set; }
        public VocabularyKey RepeatDurationMax { get; private set; }
        public VocabularyKey RepeatDurationUnit { get; private set; }
        public VocabularyKey RepeatFrequency { get; private set; }
        public VocabularyKey RepeatFrequencyMax { get; private set; }
        public VocabularyKey RepeatOffset { get; private set; }
        public VocabularyKey RepeatPeriod { get; private set; }
        public VocabularyKey RepeatPeriodMax { get; private set; }
        public VocabularyKey RepeatPeriodUnit { get; private set; }
        public VocabularyKey TimingId { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}