using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqPlannedOrderRouteOperationResourceRequirementEntityVocabulary : SimpleVocabulary
    {
        public ReqPlannedOrderRouteOperationResourceRequirementEntityVocabulary()
        {
            VocabularyName = "Common Data Model ReqPlannedOrderRouteOperationResourceRequirementEntity";
            KeyPrefix = "commonDataModel.reqplannedorderrouteoperationresourcerequiremententity";
            KeySeparator = ".";
            Grouping = "/ReqPlannedOrderRouteOperationResourceRequirementEntity";

            AddGroup("Common Data Model ReqPlannedOrderRouteOperationResourceRequirementEntity Details", group =>
            {
                RelationshipType = group.Add(new VocabularyKey(nameof(RelationshipType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Capability = group.Add(new VocabularyKey(nameof(Capability), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillJobSchedulingUseRequirement = group.Add(new VocabularyKey(nameof(WillJobSchedulingUseRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillOperationSchedulingUseRequirement = group.Add(new VocabularyKey(nameof(WillOperationSchedulingUseRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationId = group.Add(new VocabularyKey(nameof(RouteOperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredCapabilityName = group.Add(new VocabularyKey(nameof(RequiredCapabilityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumRequiredCapabilityLevel = group.Add(new VocabularyKey(nameof(MinimumRequiredCapabilityLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredCertificateType = group.Add(new VocabularyKey(nameof(RequiredCertificateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredCourseId = group.Add(new VocabularyKey(nameof(RequiredCourseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredTitleId = group.Add(new VocabularyKey(nameof(RequiredTitleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredOperationsResourceGroupId = group.Add(new VocabularyKey(nameof(RequiredOperationsResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredOperationsResourceId = group.Add(new VocabularyKey(nameof(RequiredOperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredOperationsResourceType = group.Add(new VocabularyKey(nameof(RequiredOperationsResourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredSkillId = group.Add(new VocabularyKey(nameof(RequiredSkillId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredSkillLevel = group.Add(new VocabularyKey(nameof(RequiredSkillLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderNumber = group.Add(new VocabularyKey(nameof(PlannedOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationNumber = group.Add(new VocabularyKey(nameof(RouteOperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationPriority = group.Add(new VocabularyKey(nameof(RouteOperationPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementPlanId = group.Add(new VocabularyKey(nameof(RequirementPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationDataAreaId = group.Add(new VocabularyKey(nameof(RouteOperationDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RelationshipType { get; private set; }
        public VocabularyKey Capability { get; private set; }
        public VocabularyKey WillJobSchedulingUseRequirement { get; private set; }
        public VocabularyKey WillOperationSchedulingUseRequirement { get; private set; }
        public VocabularyKey RouteOperationId { get; private set; }
        public VocabularyKey RequiredCapabilityName { get; private set; }
        public VocabularyKey MinimumRequiredCapabilityLevel { get; private set; }
        public VocabularyKey RequiredCertificateType { get; private set; }
        public VocabularyKey RequiredCourseId { get; private set; }
        public VocabularyKey RequiredTitleId { get; private set; }
        public VocabularyKey RequiredOperationsResourceGroupId { get; private set; }
        public VocabularyKey RequiredOperationsResourceId { get; private set; }
        public VocabularyKey RequiredOperationsResourceType { get; private set; }
        public VocabularyKey RequiredSkillId { get; private set; }
        public VocabularyKey RequiredSkillLevel { get; private set; }
        public VocabularyKey RecordId { get; private set; }
        public VocabularyKey PlannedOrderNumber { get; private set; }
        public VocabularyKey RouteOperationNumber { get; private set; }
        public VocabularyKey RouteOperationPriority { get; private set; }
        public VocabularyKey RequirementPlanId { get; private set; }
        public VocabularyKey RouteOperationDataAreaId { get; private set; }


    }
}