using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ExtraCurricularActivityVocabulary : SimpleVocabulary
    {
        public ExtraCurricularActivityVocabulary()
        {
            VocabularyName = "Extra Curricular Activity";
            KeyPrefix = "commonDataModel.extracurricularactivity";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ExtraCurricularActivity;

            AddGroup("ExtraCurricularActivity Details for HigherEducation", group =>
            {
                ExtracurricularActivitiesId = group.Add(new VocabularyKey(nameof(ExtracurricularActivitiesId), "Extra Curricular Activity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Extra Curricular Activity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateofOrganizationFormed = group.Add(new VocabularyKey(nameof(DateofOrganizationFormed), "Date of Organization Formed", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralEmail = group.Add(new VocabularyKey(nameof(GeneralEmail), "General Email", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                OrganizationMissionStatement = group.Add(new VocabularyKey(nameof(OrganizationMissionStatement), "Organization Mission Statement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryPurpose = group.Add(new VocabularyKey(nameof(PrimaryPurpose), "Primary Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Website = group.Add(new VocabularyKey(nameof(Website), "Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="SchoolId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="ExtracurricularActivitiesId"/> from Vocab 'ExtraCurricularParticipant.cdm.json/ExtraCurricularParticipant' with Property 'ExtraCurricularActivityId'
            #endregion
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey DateofOrganizationFormed { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
        public VocabularyKey ExtracurricularActivitiesId { get; private set; }
        public VocabularyKey GeneralEmail { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OrganizationMissionStatement { get; private set; }
        public VocabularyKey PrimaryPurpose { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Website { get; private set; }
    }
}