using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqPlannedOrderRouteOperationEntityVocabulary : SimpleVocabulary
    {
        public ReqPlannedOrderRouteOperationEntityVocabulary()
        {
            VocabularyName = "Req Planned Order Route Operation Entity";
            KeyPrefix = "commonDataModel.reqplannedorderrouteoperationentity";
            KeySeparator = ".";
            Grouping = "/ReqPlannedOrderRouteOperationEntity";

            AddGroup("ReqPlannedOrderRouteOperationEntity Details", group =>
            {
                AccumulatedScrapPercentage = group.Add(new VocabularyKey(nameof(AccumulatedScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScrapPercentage = group.Add(new VocabularyKey(nameof(ScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledStartDate = group.Add(new VocabularyKey(nameof(ScheduledStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledStartTime = group.Add(new VocabularyKey(nameof(ScheduledStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEndDate = group.Add(new VocabularyKey(nameof(ScheduledEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEndTime = group.Add(new VocabularyKey(nameof(ScheduledEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationSequence = group.Add(new VocabularyKey(nameof(RouteOperationSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextOperationLinkType = group.Add(new VocabularyKey(nameof(NextOperationLinkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationId = group.Add(new VocabularyKey(nameof(OperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationNumber = group.Add(new VocabularyKey(nameof(OperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextRouteOperationNumber = group.Add(new VocabularyKey(nameof(NextRouteOperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationPriority = group.Add(new VocabularyKey(nameof(OperationPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRouteSequencingAccepted = group.Add(new VocabularyKey(nameof(IsRouteSequencingAccepted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderNumber = group.Add(new VocabularyKey(nameof(PlannedOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementPlanId = group.Add(new VocabularyKey(nameof(RequirementPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WrkCtrActivityRequirementSet = group.Add(new VocabularyKey(nameof(WrkCtrActivityRequirementSet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceGroupId = group.Add(new VocabularyKey(nameof(OperationsResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIndividualResource = group.Add(new VocabularyKey(nameof(IsIndividualResource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionUnitId = group.Add(new VocabularyKey(nameof(ProductionUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceType = group.Add(new VocabularyKey(nameof(OperationsResourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationDataAreaId = group.Add(new VocabularyKey(nameof(RouteOperationDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccumulatedScrapPercentage { get; private set; }
        public VocabularyKey ScrapPercentage { get; private set; }
        public VocabularyKey ScheduledStartDate { get; private set; }
        public VocabularyKey ScheduledStartTime { get; private set; }
        public VocabularyKey ScheduledEndDate { get; private set; }
        public VocabularyKey ScheduledEndTime { get; private set; }
        public VocabularyKey RouteOperationSequence { get; private set; }
        public VocabularyKey NextOperationLinkType { get; private set; }
        public VocabularyKey OperationId { get; private set; }
        public VocabularyKey OperationNumber { get; private set; }
        public VocabularyKey NextRouteOperationNumber { get; private set; }
        public VocabularyKey OperationPriority { get; private set; }
        public VocabularyKey IsRouteSequencingAccepted { get; private set; }
        public VocabularyKey PlannedOrderNumber { get; private set; }
        public VocabularyKey RequirementPlanId { get; private set; }
        public VocabularyKey WrkCtrActivityRequirementSet { get; private set; }
        public VocabularyKey OperationsResourceId { get; private set; }
        public VocabularyKey OperationsResourceGroupId { get; private set; }
        public VocabularyKey IsIndividualResource { get; private set; }
        public VocabularyKey ProductionUnitId { get; private set; }
        public VocabularyKey OperationsResourceType { get; private set; }
        public VocabularyKey RouteOperationDataAreaId { get; private set; }
    }
}