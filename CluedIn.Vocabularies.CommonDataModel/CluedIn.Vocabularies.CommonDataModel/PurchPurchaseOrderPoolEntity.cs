using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseOrderPoolEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseOrderPoolEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseOrderPoolEntity";
            KeyPrefix = "commonDataModel.purchpurchaseorderpoolentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseOrderPoolEntity";

            AddGroup("Common Data Model PurchPurchaseOrderPoolEntity Details", group =>
            {
                PoolName = group.Add(new VocabularyKey(nameof(PoolName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PoolId = group.Add(new VocabularyKey(nameof(PoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PoolName { get; private set; }
public VocabularyKey PoolId { get; private set; }


    }
}