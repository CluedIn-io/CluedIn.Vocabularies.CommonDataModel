using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventItemGTDEntityVocabulary : SimpleVocabulary
    {
        public InventItemGTDEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventItemGTDEntity";
            KeyPrefix = "commonDataModel.inventitemgtdentity";
            KeySeparator = ".";
            Grouping = "/InventItemGTDEntity";

            AddGroup("Common Data Model InventItemGTDEntity Details", group =>
            {
                GTDNumber = group.Add(new VocabularyKey(nameof(GTDNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemOriginCountryRegionId = group.Add(new VocabularyKey(nameof(ItemOriginCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GTDNumber { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ItemOriginCountryRegionId { get; private set; }


    }
}