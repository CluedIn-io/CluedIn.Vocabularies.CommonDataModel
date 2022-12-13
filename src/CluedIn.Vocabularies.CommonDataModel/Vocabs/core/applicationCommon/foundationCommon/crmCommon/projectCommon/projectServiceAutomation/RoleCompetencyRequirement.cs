using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class RoleCompetencyRequirementVocabulary : SimpleVocabulary
    {
        public RoleCompetencyRequirementVocabulary()
        {
            VocabularyName = "Role Competency Requirement";
            KeyPrefix = "commonDataModel.rolecompetencyrequirement";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RoleCompetencyRequirement;

            AddGroup("RoleCompetencyRequirement Details for ProjectServiceAutomation", group =>
            {
                RoleCompetencyRequirementId = group.Add(new VocabularyKey(nameof(RoleCompetencyRequirementId), "Role competency requirement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BookableCharacteristicType = group.Add(new VocabularyKey(nameof(BookableCharacteristicType), "Bookable Characteristic Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="ResourceCategory"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="Characteristic"/> to Vocab 'Characteristic.cdm.json/Characteristic' with Property 'CharacteristicId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="RatingValue"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/RatingValue.cdm.json/RatingValue' with Property 'RatingValueId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey BookableCharacteristicType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RoleCompetencyRequirementId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}