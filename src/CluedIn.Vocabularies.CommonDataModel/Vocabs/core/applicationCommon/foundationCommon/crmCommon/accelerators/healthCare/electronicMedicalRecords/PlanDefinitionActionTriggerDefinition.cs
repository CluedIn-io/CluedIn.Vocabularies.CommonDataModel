using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class PlanDefinitionActionTriggerDefinitionVocabulary : SimpleVocabulary
    {
        public PlanDefinitionActionTriggerDefinitionVocabulary()
        {
            VocabularyName = "Plan Definition Action Trigger Definition";
            KeyPrefix = "commonDataModel.plandefinitionactiontriggerdefinition.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PlanDefinitionActionTriggerDefinition;

            AddGroup("PlanDefinitionActionTriggerDefinition Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventName = group.Add(new VocabularyKey(nameof(EventName), "Event Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventTimingType = group.Add(new VocabularyKey(nameof(EventTimingType), "Event Timing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanDefinitionActionTriggerDefinitionId = group.Add(new VocabularyKey(nameof(PlanDefinitionActionTriggerDefinitionId), "Plan Definition Action Trigger Definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timingdate = group.Add(new VocabularyKey(nameof(Timingdate), "Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timingdatetime = group.Add(new VocabularyKey(nameof(Timingdatetime), "Date Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Triggertype = group.Add(new VocabularyKey(nameof(Triggertype), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="EventDataId"/> to Vocab 'DataRequirement.cdm.json/DataRequirement' with Property 'DataRequirementId'
            ///Property <see cref="PlanDefinitionActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="EventreferenceId"/> to Vocab 'Schedule.cdm.json/Schedule' with Property 'ScheduleId'
            ///Property <see cref="EventtimingId"/> to Vocab 'Timing.cdm.json/Timing' with Property 'TimingId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey EventName { get; private set; }
        public VocabularyKey EventTimingType { get; private set; }
        public VocabularyKey PlanDefinitionActionTriggerDefinitionId { get; private set; }
        public VocabularyKey Timingdate { get; private set; }
        public VocabularyKey Timingdatetime { get; private set; }
        public VocabularyKey Triggertype { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}