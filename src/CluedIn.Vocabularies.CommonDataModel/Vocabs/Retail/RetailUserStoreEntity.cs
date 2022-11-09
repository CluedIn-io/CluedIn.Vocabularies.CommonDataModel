using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailUserStoreEntityVocabulary : SimpleVocabulary
    {
        public RetailUserStoreEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailUserStoreEntity";
            KeyPrefix = "commonDataModel.retailuserstoreentity";
            KeySeparator = ".";
            Grouping = "/RetailUserStoreEntity";

            AddGroup("Common Data Model RetailUserStoreEntity Details", group =>
            {
                PrimaryStore = group.Add(new VocabularyKey(nameof(PrimaryStore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StoreName = group.Add(new VocabularyKey(nameof(StoreName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
User = group.Add(new VocabularyKey(nameof(User), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PrimaryStore { get; private set; }
public VocabularyKey StoreName { get; private set; }
public VocabularyKey StoreNumber { get; private set; }
public VocabularyKey User { get; private set; }


    }
}