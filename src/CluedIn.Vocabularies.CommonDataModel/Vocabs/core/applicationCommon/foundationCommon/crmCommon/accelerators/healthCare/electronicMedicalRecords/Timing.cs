using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class TimingVocabulary : SimpleVocabulary
    {
        public TimingVocabulary()
        {
            VocabularyName = "Timing";
            KeyPrefix = "commonDataModel.timing";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Timing;

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
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="TimingId"/> to Vocab 'Timing.cdm.json/Timing' with Property 'TimingId'
            ///Property <see cref="TimingId"/> to Vocab 'Timing.cdm.json/Timing' with Property 'TimingId'
            ///Property <see cref="TimingId"/> to Vocab 'Timing.cdm.json/Timing' with Property 'TimingId'
            ///Property <see cref="TimingId"/> to Vocab 'Timing.cdm.json/Timing' with Property 'TimingId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="TimingId"/> from Vocab 'DeviceMetric.cdm.json/DeviceMetric' with Property 'MeasurementPeriodId'
            ///Property <see cref="TimingId"/> from Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'OccurrenceTimingId'
            ///Property <see cref="TimingId"/> from Vocab 'Dosage.cdm.json/Dosage' with Property 'TimingId'
            ///Property <see cref="TimingId"/> from Vocab 'ActivityDefinition.cdm.json/ActivityDefinition' with Property 'ActivityTimingId'
            ///Property <see cref="TimingId"/> from Vocab 'NutritionOrderEnteralFormulaAdministration.cdm.json/NutritionOrderEnteralFormulaAdministration' with Property 'AdministrationScheduleId'
            ///Property <see cref="TimingId"/> from Vocab 'NutritionOrderOralDietSchedule.cdm.json/NutritionOrderOralDietSchedule' with Property 'OralDietScheduleId'
            ///Property <see cref="TimingId"/> from Vocab 'NutritionOrderSupplementSchedule.cdm.json/NutritionOrderSupplementSchedule' with Property 'ScheduleId'
            ///Property <see cref="TimingId"/> from Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'TimingtimingId'
            ///Property <see cref="TimingId"/> from Vocab 'PlanDefinitionActionTriggerDefinition.cdm.json/PlanDefinitionActionTriggerDefinition' with Property 'EventtimingId'
            ///Property <see cref="TimingId"/> from Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'OccurenceTimingId'
            ///Property <see cref="TimingId"/> from Vocab 'RequestGroupAction.cdm.json/RequestGroupAction' with Property 'ActionTimingId'
            ///Property <see cref="TimingId"/> from Vocab 'TimingDayOfWeek.cdm.json/TimingDayOfWeek' with Property 'TimingId'
            ///Property <see cref="TimingId"/> from Vocab 'TimingEvent.cdm.json/TimingEvent' with Property 'TimingId'
            ///Property <see cref="TimingId"/> from Vocab 'TimingTimeOfDay.cdm.json/TimingTimeOfDay' with Property 'TimingId'
            ///Property <see cref="TimingId"/> from Vocab 'TimingWhen.cdm.json/TimingWhen' with Property 'TimingId'
            #endregion
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
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
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey TimingId { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}