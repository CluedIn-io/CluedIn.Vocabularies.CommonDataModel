using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchaseRebateVendorGroupEntityVocabulary : SimpleVocabulary
    {
        public PurchaseRebateVendorGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchaseRebateVendorGroupEntity";
            KeyPrefix = "commonDataModel.purchaserebatevendorgroupentity";
            KeySeparator = ".";
            Grouping = "/PurchaseRebateVendorGroupEntity";

            AddGroup("Common Data Model PurchaseRebateVendorGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupDescription { get; private set; }
public VocabularyKey GroupId { get; private set; }


    }
}