using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchaseRebateProductGroupEntityVocabulary : SimpleVocabulary
    {
        public PurchaseRebateProductGroupEntityVocabulary()
        {
            VocabularyName = "Purchase Rebate Product Group Entity";
            KeyPrefix = "commonDataModel.purchaserebateproductgroupentity";
            KeySeparator = ".";
            Grouping = "/PurchaseRebateProductGroupEntity";

            AddGroup("PurchaseRebateProductGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey GroupId { get; private set; }
    }
}