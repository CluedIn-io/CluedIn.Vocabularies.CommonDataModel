using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdProductionOrderRouteJobEntityVocabulary : SimpleVocabulary
    {
        public ProdProductionOrderRouteJobEntityVocabulary()
        {
            VocabularyName = "Prod Production Order Route Job Entity";
            KeyPrefix = "commonDataModel.prodproductionorderroutejobentity";
            KeySeparator = ".";
            Grouping = "/ProdProductionOrderRouteJobEntity";

            AddGroup("ProdProductionOrderRouteJobEntity Details", group =>
            {
                CalculatedJobDurationHours = group.Add(new VocabularyKey(nameof(CalculatedJobDurationHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobProcessingPercentage = group.Add(new VocabularyKey(nameof(JobProcessingPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledFromDate = group.Add(new VocabularyKey(nameof(ScheduledFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledFromTime = group.Add(new VocabularyKey(nameof(ScheduledFromTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobManagementUsed = group.Add(new VocabularyKey(nameof(IsJobManagementUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobEnded = group.Add(new VocabularyKey(nameof(IsJobEnded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobStatus = group.Add(new VocabularyKey(nameof(JobStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteJobType = group.Add(new VocabularyKey(nameof(RouteJobType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextOperationLink = group.Add(new VocabularyKey(nameof(NextOperationLink), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextOperationLinkType = group.Add(new VocabularyKey(nameof(NextOperationLinkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryJobNumber = group.Add(new VocabularyKey(nameof(PrimaryJobNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondaryJobNumber = group.Add(new VocabularyKey(nameof(SecondaryJobNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobSequence = group.Add(new VocabularyKey(nameof(JobSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationNumber = group.Add(new VocabularyKey(nameof(OperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationPriority = group.Add(new VocabularyKey(nameof(OperationPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionOrderNumber = group.Add(new VocabularyKey(nameof(ProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkingTimeSchedulingPropertyId = group.Add(new VocabularyKey(nameof(WorkingTimeSchedulingPropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualEndDate = group.Add(new VocabularyKey(nameof(ActualEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualEndTime = group.Add(new VocabularyKey(nameof(ActualEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualFromDate = group.Add(new VocabularyKey(nameof(ActualFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualFromTime = group.Add(new VocabularyKey(nameof(ActualFromTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobCancelled = group.Add(new VocabularyKey(nameof(IsJobCancelled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledJobDurationHours = group.Add(new VocabularyKey(nameof(ScheduledJobDurationHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEndDate = group.Add(new VocabularyKey(nameof(ScheduledEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEndTime = group.Add(new VocabularyKey(nameof(ScheduledEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CalculatedJobDurationHours { get; private set; }
        public VocabularyKey JobProcessingPercentage { get; private set; }
        public VocabularyKey ScheduledFromDate { get; private set; }
        public VocabularyKey ScheduledFromTime { get; private set; }
        public VocabularyKey IsJobManagementUsed { get; private set; }
        public VocabularyKey IsJobEnded { get; private set; }
        public VocabularyKey JobId { get; private set; }
        public VocabularyKey JobStatus { get; private set; }
        public VocabularyKey RouteJobType { get; private set; }
        public VocabularyKey NextOperationLink { get; private set; }
        public VocabularyKey NextOperationLinkType { get; private set; }
        public VocabularyKey PrimaryJobNumber { get; private set; }
        public VocabularyKey SecondaryJobNumber { get; private set; }
        public VocabularyKey JobSequence { get; private set; }
        public VocabularyKey OperationNumber { get; private set; }
        public VocabularyKey OperationPriority { get; private set; }
        public VocabularyKey ProductionOrderNumber { get; private set; }
        public VocabularyKey WorkingTimeSchedulingPropertyId { get; private set; }
        public VocabularyKey ActualEndDate { get; private set; }
        public VocabularyKey ActualEndTime { get; private set; }
        public VocabularyKey ActualFromDate { get; private set; }
        public VocabularyKey ActualFromTime { get; private set; }
        public VocabularyKey IsJobCancelled { get; private set; }
        public VocabularyKey ScheduledJobDurationHours { get; private set; }
        public VocabularyKey ScheduledEndDate { get; private set; }
        public VocabularyKey OperationsResourceId { get; private set; }
        public VocabularyKey ScheduledEndTime { get; private set; }
    }
}