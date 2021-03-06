using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxZakatAssetGroupEntityVocabulary : SimpleVocabulary
    {
        public TaxZakatAssetGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxZakatAssetGroupEntity";
            KeyPrefix = "commonDataModel.taxzakatassetgroupentity";
            KeySeparator = ".";
            Grouping = "/TaxZakatAssetGroupEntity";

            AddGroup("Common Data Model TaxZakatAssetGroupEntity Details", group =>
            {
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupType = group.Add(new VocabularyKey(nameof(GroupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupName { get; private set; }
public VocabularyKey GroupType { get; private set; }


    }
}