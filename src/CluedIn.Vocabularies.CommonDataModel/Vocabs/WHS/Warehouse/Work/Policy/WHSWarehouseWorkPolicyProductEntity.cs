using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkPolicyProductEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkPolicyProductEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Work Policy Product Entity";
            KeyPrefix = "commonDataModel.whswarehouseworkpolicyproductentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkPolicyProductEntity";

            AddGroup("WHSWarehouseWorkPolicyProductEntity Details", group =>
            {
                WHSPolicyRecId = group.Add(new VocabularyKey(nameof(WHSPolicyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPolicyName = group.Add(new VocabularyKey(nameof(WorkPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WHSPolicyRecId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey WorkPolicyName { get; private set; }
    }
}