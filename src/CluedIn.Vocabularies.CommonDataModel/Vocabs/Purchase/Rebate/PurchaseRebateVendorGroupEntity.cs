using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchaseRebateVendorGroupEntityVocabulary : SimpleVocabulary
    {
        public PurchaseRebateVendorGroupEntityVocabulary()
        {
            VocabularyName = "Purchase Rebate Vendor Group Entity";
            KeyPrefix = "commonDataModel.purchaserebatevendorgroupentity";
            KeySeparator = ".";
            Grouping = "/PurchaseRebateVendorGroupEntity";

            AddGroup("PurchaseRebateVendorGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey GroupId { get; private set; }
    }
}