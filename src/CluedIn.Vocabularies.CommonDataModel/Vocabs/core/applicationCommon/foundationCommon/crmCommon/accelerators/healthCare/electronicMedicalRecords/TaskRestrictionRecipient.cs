using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class TaskRestrictionRecipientVocabulary : SimpleVocabulary
    {
        public TaskRestrictionRecipientVocabulary()
        {
            VocabularyName = "Task Restriction Recipient";
            KeyPrefix = "commonDataModel.taskrestrictionrecipient.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.TaskRestrictionRecipient;

            AddGroup("TaskRestrictionRecipient Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RestrictionRecipientType = group.Add(new VocabularyKey(nameof(RestrictionRecipientType), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TaskRestrictionRecipientId = group.Add(new VocabularyKey(nameof(TaskRestrictionRecipientId), "Task Restriction Recipient", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="RestrictionRecipientOrganizationId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RestrictionRecipientPatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RestrictionRecipientPractitionerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RestrictionRecipientRelatedPersonId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RestrictionRecipientGroupId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
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
            ///Property <see cref="TaskId"/> to Vocab 'Task.cdm.json/Task' with Property 'ActivityId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey RestrictionRecipientType { get; private set; }
        public VocabularyKey TaskRestrictionRecipientId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}