using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkOperationProcessingRuleEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkOperationProcessingRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWorkOperationProcessingRuleEntity";
            KeyPrefix = "commonDataModel.whswarehouseworkoperationprocessingruleentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkOperationProcessingRuleEntity";

            AddGroup("Common Data Model WHSWarehouseWorkOperationProcessingRuleEntity Details", group =>
            {
                WarehouseWorkProcessingPolicyName = group.Add(new VocabularyKey(nameof(WarehouseWorkProcessingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkOrderType = group.Add(new VocabularyKey(nameof(WorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationType = group.Add(new VocabularyKey(nameof(OperationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessingMethod = group.Add(new VocabularyKey(nameof(ProcessingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferredProcessingThreshold = group.Add(new VocabularyKey(nameof(DeferredProcessingThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferredProcessingBatchGroupId = group.Add(new VocabularyKey(nameof(DeferredProcessingBatchGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarehouseWorkProcessingPolicyName { get; private set; }
        public VocabularyKey WorkOrderType { get; private set; }
        public VocabularyKey OperationType { get; private set; }
        public VocabularyKey ProcessingMethod { get; private set; }
        public VocabularyKey DeferredProcessingThreshold { get; private set; }
        public VocabularyKey DeferredProcessingBatchGroupId { get; private set; }


    }
}