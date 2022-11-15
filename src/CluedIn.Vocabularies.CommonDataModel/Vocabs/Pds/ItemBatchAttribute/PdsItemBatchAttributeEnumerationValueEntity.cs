using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsItemBatchAttributeEnumerationValueEntityVocabulary : SimpleVocabulary
    {
        public PdsItemBatchAttributeEnumerationValueEntityVocabulary()
        {
            VocabularyName = "Pds Item Batch Attribute Enumeration Value Entity";
            KeyPrefix = "commonDataModel.pdsitembatchattributeenumerationvalueentity";
            KeySeparator = ".";
            Grouping = "/PdsItemBatchAttributeEnumerationValueEntity";

            AddGroup("PdsItemBatchAttributeEnumerationValueEntity Details", group =>
            {
                ItemBatchAttributeId = group.Add(new VocabularyKey(nameof(ItemBatchAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Sequence = group.Add(new VocabularyKey(nameof(Sequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnumerationValue = group.Add(new VocabularyKey(nameof(EnumerationValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAttributeTarget = group.Add(new VocabularyKey(nameof(IsAttributeTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ItemBatchAttributeId { get; private set; }
        public VocabularyKey Sequence { get; private set; }
        public VocabularyKey EnumerationValue { get; private set; }
        public VocabularyKey IsAttributeTarget { get; private set; }
    }
}