using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeAssetGroupEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeAssetGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeAssetGroupEntity";
            KeyPrefix = "commonDataModel.dimattributeassetgroupentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeAssetGroupEntity";

            AddGroup("Common Data Model DimAttributeAssetGroupEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}