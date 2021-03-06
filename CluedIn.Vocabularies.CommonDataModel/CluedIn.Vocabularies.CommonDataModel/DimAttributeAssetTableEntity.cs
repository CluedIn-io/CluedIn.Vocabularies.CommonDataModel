using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeAssetTableEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeAssetTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeAssetTableEntity";
            KeyPrefix = "commonDataModel.dimattributeassettableentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeAssetTableEntity";

            AddGroup("Common Data Model DimAttributeAssetTableEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}