using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class RequestGroupActionVocabulary : SimpleVocabulary
    {
        public RequestGroupActionVocabulary()
        {
            VocabularyName = "Request Group Action";
            KeyPrefix = "commonDataModel.requestgroupaction.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RequestGroupAction;

            AddGroup("RequestGroupAction Details for ElectronicMedicalRecords", group =>
            {
			    ActionCardinalityBehavior = group.Add(new VocabularyKey(nameof(ActionCardinalityBehavior), "Cardinality Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionDescription = group.Add(new VocabularyKey(nameof(ActionDescription), "Action Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionGroupingBehavior = group.Add(new VocabularyKey(nameof(ActionGroupingBehavior), "Grouping Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionLabel = group.Add(new VocabularyKey(nameof(ActionLabel), "Action Label", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionPrecheckBehavior = group.Add(new VocabularyKey(nameof(ActionPrecheckBehavior), "Pre check Behavior", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ActionRequiredBehavior = group.Add(new VocabularyKey(nameof(ActionRequiredBehavior), "Required Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionResource = group.Add(new VocabularyKey(nameof(ActionResource), "Action Resource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionSelectionBehavior = group.Add(new VocabularyKey(nameof(ActionSelectionBehavior), "Selection Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionTextEquivalent = group.Add(new VocabularyKey(nameof(ActionTextEquivalent), "Action Text Equivalent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionTimingDateTime = group.Add(new VocabularyKey(nameof(ActionTimingDateTime), "Timing DateTime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionTimingDuration = group.Add(new VocabularyKey(nameof(ActionTimingDuration), "Timing Duration", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActionTimingPeriodEnd = group.Add(new VocabularyKey(nameof(ActionTimingPeriodEnd), "Timing Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionTimingPeriodStart = group.Add(new VocabularyKey(nameof(ActionTimingPeriodStart), "Timing Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionTimingRangeHigh = group.Add(new VocabularyKey(nameof(ActionTimingRangeHigh), "Timing Range High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ActionTimingRangeLow = group.Add(new VocabularyKey(nameof(ActionTimingRangeLow), "Timing Range Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ActionTimingType = group.Add(new VocabularyKey(nameof(ActionTimingType), "Timing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionTitle = group.Add(new VocabularyKey(nameof(ActionTitle), "Action Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionType = group.Add(new VocabularyKey(nameof(ActionType), "Action Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupActionId = group.Add(new VocabularyKey(nameof(RequestGroupActionId), "Request Group Action", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ActionParticipantTypePatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ActionParticipantTypePersonId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ActionParticipantTypePractitionerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ActionParticipantTypeRelatedPersonId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ActionCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="RequestGroupId"/> to Vocab 'RequestGroup.cdm.json/RequestGroup' with Property 'RequestGroupId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ActionTimingId"/> to Vocab 'Timing.cdm.json/Timing' with Property 'TimingId'
            ///Property <see cref="RequestGroupActionId"/> to Vocab 'RequestGroupAction.cdm.json/RequestGroupAction' with Property 'RequestGroupActionId'
            ///Property <see cref="RequestGroupActionId"/> to Vocab 'RequestGroupAction.cdm.json/RequestGroupAction' with Property 'RequestGroupActionId'
            ///Property <see cref="RequestGroupActionId"/> to Vocab 'RequestGroupAction.cdm.json/RequestGroupAction' with Property 'RequestGroupActionId'
            ///Property <see cref="RequestGroupActionId"/> to Vocab 'RequestGroupAction.cdm.json/RequestGroupAction' with Property 'RequestGroupActionId'
            ///Property <see cref="RequestGroupActionId"/> to Vocab 'RequestGroupAction.cdm.json/RequestGroupAction' with Property 'RequestGroupActionId'
            ///Property <see cref="RequestGroupActionId"/> to Vocab 'RequestGroupAction.cdm.json/RequestGroupAction' with Property 'RequestGroupActionId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="RequestGroupActionId"/> from Vocab 'RequestGroupActionAction.cdm.json/RequestGroupActionAction' with Property 'RequestGroupActionId'
            ///Property <see cref="RequestGroupActionId"/> from Vocab 'RequestGroupActionCode.cdm.json/RequestGroupActionCode' with Property 'RequestGroupActionId'
            ///Property <see cref="RequestGroupActionId"/> from Vocab 'RequestGroupActionCondition.cdm.json/RequestGroupActionCondition' with Property 'RequestGroupActionId'
            ///Property <see cref="RequestGroupActionId"/> from Vocab 'RequestGroupActionDocumentation.cdm.json/RequestGroupActionDocumentation' with Property 'RequestGroupActionId'
            ///Property <see cref="RequestGroupActionId"/> from Vocab 'RequestGroupActionParticipant.cdm.json/RequestGroupActionParticipant' with Property 'RequestGroupActionId'
            ///Property <see cref="RequestGroupActionId"/> from Vocab 'RequestGroupActionRelatedAction.cdm.json/RequestGroupActionRelatedAction' with Property 'RequestGroupActionId'
            #endregion
        }

        public VocabularyKey ActionCardinalityBehavior { get; private set; }
        public VocabularyKey ActionDescription { get; private set; }
        public VocabularyKey ActionGroupingBehavior { get; private set; }
        public VocabularyKey ActionLabel { get; private set; }
        public VocabularyKey ActionPrecheckBehavior { get; private set; }
        public VocabularyKey ActionRequiredBehavior { get; private set; }
        public VocabularyKey ActionResource { get; private set; }
        public VocabularyKey ActionSelectionBehavior { get; private set; }
        public VocabularyKey ActionTextEquivalent { get; private set; }
        public VocabularyKey ActionTimingDateTime { get; private set; }
        public VocabularyKey ActionTimingDuration { get; private set; }
        public VocabularyKey ActionTimingPeriodEnd { get; private set; }
        public VocabularyKey ActionTimingPeriodStart { get; private set; }
        public VocabularyKey ActionTimingRangeHigh { get; private set; }
        public VocabularyKey ActionTimingRangeLow { get; private set; }
        public VocabularyKey ActionTimingType { get; private set; }
        public VocabularyKey ActionTitle { get; private set; }
        public VocabularyKey ActionType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequestGroupActionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}