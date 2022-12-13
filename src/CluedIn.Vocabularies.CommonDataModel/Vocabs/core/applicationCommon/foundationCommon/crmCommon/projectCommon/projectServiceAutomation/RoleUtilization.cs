using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class RoleUtilizationVocabulary : SimpleVocabulary
    {
        public RoleUtilizationVocabulary()
        {
            VocabularyName = "Role Utilization";
            KeyPrefix = "commonDataModel.roleutilization";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RoleUtilization;

            AddGroup("RoleUtilization Details for ProjectServiceAutomation", group =>
            {
                RoleUtilizationId = group.Add(new VocabularyKey(nameof(RoleUtilizationId), "Role Utilization", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetUtilizationPercent = group.Add(new VocabularyKey(nameof(TargetUtilizationPercent), "Target Utilization Percent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UtilizationPercent = group.Add(new VocabularyKey(nameof(UtilizationPercent), "Utilization Percent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UtilizationPercentDifference = group.Add(new VocabularyKey(nameof(UtilizationPercentDifference), "Utilization Percent Difference", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="Role"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
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

            #endregion
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey RoleUtilizationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TargetUtilizationPercent { get; private set; }
        public VocabularyKey UtilizationPercent { get; private set; }
        public VocabularyKey UtilizationPercentDifference { get; private set; }
    }
}