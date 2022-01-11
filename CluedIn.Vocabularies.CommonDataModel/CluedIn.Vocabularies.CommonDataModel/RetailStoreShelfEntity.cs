using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailStoreShelfEntityVocabulary : SimpleVocabulary
    {
        public RetailStoreShelfEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailStoreShelfEntity";
            KeyPrefix = "commonDataModel.retailstoreshelfentity";
            KeySeparator = ".";
            Grouping = "/RetailStoreShelfEntity";

            AddGroup("Common Data Model RetailStoreShelfEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SectionNumber = group.Add(new VocabularyKey(nameof(SectionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SectionPercent = group.Add(new VocabularyKey(nameof(SectionPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShelfNumber = group.Add(new VocabularyKey(nameof(ShelfNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey SectionNumber { get; private set; }
public VocabularyKey SectionPercent { get; private set; }
public VocabularyKey ShelfNumber { get; private set; }
public VocabularyKey StoreNumber { get; private set; }


    }
}