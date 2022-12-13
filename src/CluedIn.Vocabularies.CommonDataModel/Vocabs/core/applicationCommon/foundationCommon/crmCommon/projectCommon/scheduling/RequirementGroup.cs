using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class RequirementGroupVocabulary : SimpleVocabulary
    {
        public RequirementGroupVocabulary()
        {
            VocabularyName = "Requirement Group";
            KeyPrefix = "commonDataModel.requirementgroup";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RequirementGroup;

            AddGroup("RequirementGroup Details for Scheduling", group =>
            {
                RequirementgroupId = group.Add(new VocabularyKey(nameof(RequirementgroupId), "Requirement Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTemplate = group.Add(new VocabularyKey(nameof(IsTemplate), "Is Template", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AutoGroupType = group.Add(new VocabularyKey(nameof(AutoGroupType), "Auto Group Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
            ///Property <see cref="RequirementGroupTemplate"/> to Vocab 'RequirementGroup.cdm.json/RequirementGroup' with Property 'RequirementgroupId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="RequirementgroupId"/> from Vocab 'RequirementGroup.cdm.json/RequirementGroup' with Property 'RequirementGroupTemplate'
            ///Property <see cref="RequirementgroupId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'RequirementGroup'
            ///Property <see cref="RequirementgroupId"/> from Vocab 'RequirementRelationship.cdm.json/RequirementRelationship' with Property 'RequirementGroup'
            ///Property <see cref="RequirementgroupId"/> from Vocab 'ResourceRequirement.cdm.json/ResourceRequirement' with Property 'RequirementGroup'
            #endregion
        }

        public VocabularyKey AutoGroupType { get; private set; }
        public VocabularyKey IsTemplate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequirementgroupId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}