using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class RequirementStatusVocabulary : SimpleVocabulary
    {
        public RequirementStatusVocabulary()
        {
            VocabularyName = "Requirement Status";
            KeyPrefix = "commonDataModel.requirementstatus";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RequirementStatus;

            AddGroup("RequirementStatus Details for Scheduling", group =>
            {
                RequirementStatusId = group.Add(new VocabularyKey(nameof(RequirementStatusId), "Requirement Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="RequirementStatusId"/> from Vocab 'BookingSetupMetadata.cdm.json/BookingSetupMetadata' with Property 'DefaultRequirementActiveStatus'
            ///Property <see cref="RequirementStatusId"/> from Vocab 'BookingSetupMetadata.cdm.json/BookingSetupMetadata' with Property 'DefaultRequirementCanceledStatus'
            ///Property <see cref="RequirementStatusId"/> from Vocab 'BookingSetupMetadata.cdm.json/BookingSetupMetadata' with Property 'DefaultRequirementCompletedStatus'
            ///Property <see cref="RequirementStatusId"/> from Vocab 'ResourceRequirement.cdm.json/ResourceRequirement' with Property 'Status'
            #endregion
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequirementStatusId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}