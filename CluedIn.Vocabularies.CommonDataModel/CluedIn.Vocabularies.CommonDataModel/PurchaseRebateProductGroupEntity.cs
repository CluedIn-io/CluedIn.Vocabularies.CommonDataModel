using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchaseRebateProductGroupEntityVocabulary : SimpleVocabulary
    {
        public PurchaseRebateProductGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchaseRebateProductGroupEntity";
            KeyPrefix = "commonDataModel.purchaserebateproductgroupentity";
            KeySeparator = ".";
            Grouping = "/PurchaseRebateProductGroupEntity";

            AddGroup("Common Data Model PurchaseRebateProductGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupDescription { get; private set; }
public VocabularyKey GroupId { get; private set; }


    }
}