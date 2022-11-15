using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSCatchWeightItemHandlingPolicyV2EntityVocabulary : SimpleVocabulary
    {
        public WHSCatchWeightItemHandlingPolicyV2EntityVocabulary()
        {
            VocabularyName = "WHS Catch Weight Item Handling Policy V2 Entity";
            KeyPrefix = "commonDataModel.whscatchweightitemhandlingpolicyv2entity";
            KeySeparator = ".";
            Grouping = "/WHSCatchWeightItemHandlingPolicyV2Entity";

            AddGroup("WHSCatchWeightItemHandlingPolicyV2Entity Details", group =>
            {
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyDescription = group.Add(new VocabularyKey(nameof(PolicyDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InboundCatchWeightTagCapturingMethod = group.Add(new VocabularyKey(nameof(InboundCatchWeightTagCapturingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InboundWeightCapturingMethod = group.Add(new VocabularyKey(nameof(InboundWeightCapturingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightTagTracking = group.Add(new VocabularyKey(nameof(CatchWeightTagTracking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutboundCatchWeightTagCapturingMethod = group.Add(new VocabularyKey(nameof(OutboundCatchWeightTagCapturingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutboundWeightCapturingMethod = group.Add(new VocabularyKey(nameof(OutboundWeightCapturingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionPickingWeightCapturingMethod = group.Add(new VocabularyKey(nameof(ProductionPickingWeightCapturingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderWeightCapturingProcess = group.Add(new VocabularyKey(nameof(SalesOrderWeightCapturingProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferIssueWeightCapturingProcess = group.Add(new VocabularyKey(nameof(TransferIssueWeightCapturingProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionWeightCapturingProcess = group.Add(new VocabularyKey(nameof(CorrectionWeightCapturingProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutboundWeightVarianceMethod = group.Add(new VocabularyKey(nameof(OutboundWeightVarianceMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MovementWeightCapturingMethod = group.Add(new VocabularyKey(nameof(MovementWeightCapturingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountingWeightCapturingMethod = group.Add(new VocabularyKey(nameof(CountingWeightCapturingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseTransferWeightCapturingMethod = group.Add(new VocabularyKey(nameof(WarehouseTransferWeightCapturingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightTagDimensionTrackingMethod = group.Add(new VocabularyKey(nameof(CatchWeightTagDimensionTrackingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PolicyName { get; private set; }
        public VocabularyKey PolicyDescription { get; private set; }
        public VocabularyKey InboundCatchWeightTagCapturingMethod { get; private set; }
        public VocabularyKey InboundWeightCapturingMethod { get; private set; }
        public VocabularyKey CatchWeightTagTracking { get; private set; }
        public VocabularyKey OutboundCatchWeightTagCapturingMethod { get; private set; }
        public VocabularyKey OutboundWeightCapturingMethod { get; private set; }
        public VocabularyKey ProductionPickingWeightCapturingMethod { get; private set; }
        public VocabularyKey SalesOrderWeightCapturingProcess { get; private set; }
        public VocabularyKey TransferIssueWeightCapturingProcess { get; private set; }
        public VocabularyKey CorrectionWeightCapturingProcess { get; private set; }
        public VocabularyKey OutboundWeightVarianceMethod { get; private set; }
        public VocabularyKey MovementWeightCapturingMethod { get; private set; }
        public VocabularyKey CountingWeightCapturingMethod { get; private set; }
        public VocabularyKey WarehouseTransferWeightCapturingMethod { get; private set; }
        public VocabularyKey CatchWeightTagDimensionTrackingMethod { get; private set; }
    }
}