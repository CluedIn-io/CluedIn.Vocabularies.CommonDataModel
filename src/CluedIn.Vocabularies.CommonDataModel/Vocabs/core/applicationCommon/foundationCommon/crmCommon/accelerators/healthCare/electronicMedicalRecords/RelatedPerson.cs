using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class RelatedPersonVocabulary : SimpleVocabulary
    {
        public RelatedPersonVocabulary()
        {
            VocabularyName = "Related Person";
            KeyPrefix = "commonDataModel.relatedperson";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RelatedPerson;

            AddGroup("RelatedPerson Details for ElectronicMedicalRecords", group =>
            {
                Active = group.Add(new VocabularyKey(nameof(Active), "Active", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelatedPersonId = group.Add(new VocabularyKey(nameof(RelatedPersonId), "Related Person", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelatedPersonPeriodEndDate = group.Add(new VocabularyKey(nameof(RelatedPersonPeriodEndDate), "Related Person Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelatedPersonPeriodStartDate = group.Add(new VocabularyKey(nameof(RelatedPersonPeriodStartDate), "Related Person Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="PatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RelationshipId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
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
            ///Property <see cref="RelatedPersonId"/> from Vocab 'Schedule.cdm.json/Schedule' with Property 'ActorRelatedPersonId'
            ///Property <see cref="RelatedPersonId"/> from Vocab 'ScheduleActor.cdm.json/ScheduleActor' with Property 'ActorRelatedPersonId'
            #endregion
        }

        public VocabularyKey Active { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RelatedPersonId { get; private set; }
        public VocabularyKey RelatedPersonPeriodEndDate { get; private set; }
        public VocabularyKey RelatedPersonPeriodStartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}