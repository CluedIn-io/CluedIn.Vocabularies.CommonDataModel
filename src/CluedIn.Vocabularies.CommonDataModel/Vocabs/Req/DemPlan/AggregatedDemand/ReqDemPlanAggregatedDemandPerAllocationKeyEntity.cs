using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqDemPlanAggregatedDemandPerAllocationKeyEntityVocabulary : SimpleVocabulary
    {
        public ReqDemPlanAggregatedDemandPerAllocationKeyEntityVocabulary()
        {
            VocabularyName = "Req Dem Plan Aggregated Demand Per Allocation Key Entity";
            KeyPrefix = "commonDataModel.reqdemplanaggregateddemandperallocationkeyentity";
            KeySeparator = ".";
            Grouping = "/ReqDemPlanAggregatedDemandPerAllocationKeyEntity";

            AddGroup("ReqDemPlanAggregatedDemandPerAllocationKeyEntity Details", group =>
            {
                DemandCategory = group.Add(new VocabularyKey(nameof(DemandCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveringSiteId = group.Add(new VocabularyKey(nameof(DeliveringSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAllocationKeyId = group.Add(new VocabularyKey(nameof(ProductAllocationKeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandDate = group.Add(new VocabularyKey(nameof(DemandDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandQuantity = group.Add(new VocabularyKey(nameof(DemandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandQuantityConfidenceIntervalLowerBound = group.Add(new VocabularyKey(nameof(DemandQuantityConfidenceIntervalLowerBound), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandQuantityConfidenceIntervalUpperBound = group.Add(new VocabularyKey(nameof(DemandQuantityConfidenceIntervalUpperBound), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DemandCategory { get; private set; }
        public VocabularyKey DeliveringSiteId { get; private set; }
        public VocabularyKey ProductAllocationKeyId { get; private set; }
        public VocabularyKey DemandDate { get; private set; }
        public VocabularyKey DemandQuantity { get; private set; }
        public VocabularyKey DemandQuantityConfidenceIntervalLowerBound { get; private set; }
        public VocabularyKey DemandQuantityConfidenceIntervalUpperBound { get; private set; }
    }
}