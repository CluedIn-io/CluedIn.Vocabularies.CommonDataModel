using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class RequirementRelationshipVocabulary : SimpleVocabulary
    {
        public RequirementRelationshipVocabulary()
        {
            VocabularyName = "Requirement Relationship";
            KeyPrefix = "commonDataModel.requirementrelationship";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RequirementRelationship;

            AddGroup("RequirementRelationship Details for Scheduling", group =>
            {
                RequirementrelationshipId = group.Add(new VocabularyKey(nameof(RequirementrelationshipId), "Requirement Relationship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinConditionCount = group.Add(new VocabularyKey(nameof(MinConditionCount), "Min Condition Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Operator = group.Add(new VocabularyKey(nameof(Operator), "Operator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceGroupings = group.Add(new VocabularyKey(nameof(ResourceGroupings), "Part of Same", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementGroupControlViewId = group.Add(new VocabularyKey(nameof(RequirementGroupControlViewId), "Requirement Group Control View Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="RequirementGroup"/> to Vocab 'RequirementGroup.cdm.json/RequirementGroup' with Property 'RequirementgroupId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ParentRequirementRelationship"/> to Vocab 'RequirementRelationship.cdm.json/RequirementRelationship' with Property 'RequirementrelationshipId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="RequirementrelationshipId"/> from Vocab 'RequirementRelationship.cdm.json/RequirementRelationship' with Property 'ParentRequirementRelationship'
            ///Property <see cref="RequirementrelationshipId"/> from Vocab 'ResourceRequirement.cdm.json/ResourceRequirement' with Property 'RequirementRelationship'
            #endregion
        }

        public VocabularyKey MinConditionCount { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Operator { get; private set; }
        public VocabularyKey RequirementGroupControlViewId { get; private set; }
        public VocabularyKey RequirementrelationshipId { get; private set; }
        public VocabularyKey ResourceGroupings { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}