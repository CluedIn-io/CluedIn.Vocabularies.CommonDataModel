using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchaseOrderSummaryUpdateCriteriaEntityVocabulary : SimpleVocabulary
    {
        public PurchaseOrderSummaryUpdateCriteriaEntityVocabulary()
        {
            VocabularyName = "PurchaseOrderSummaryUpdateCriteriaEntity";
            KeyPrefix = "commonDataModel.purchaseordersummaryupdatecriteriaentity";
            KeySeparator = ".";
            Grouping = "/PurchaseOrderSummaryUpdateCriteriaEntity";

            AddGroup("PurchaseOrderSummaryUpdateCriteriaEntity Details", group =>
            {
                DocumentStatus = group.Add(new VocabularyKey(nameof(DocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalFieldId = group.Add(new VocabularyKey(nameof(InternalFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DocumentStatus { get; private set; }
        public VocabularyKey TableName { get; private set; }
        public VocabularyKey FieldName { get; private set; }
        public VocabularyKey InternalFieldId { get; private set; }


    }
}