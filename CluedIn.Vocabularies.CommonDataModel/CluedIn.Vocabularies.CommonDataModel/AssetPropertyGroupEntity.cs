using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetPropertyGroupEntityVocabulary : SimpleVocabulary
    {
        public AssetPropertyGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetPropertyGroupEntity";
            KeyPrefix = "commonDataModel.assetpropertygroupentity";
            KeySeparator = ".";
            Grouping = "/AssetPropertyGroupEntity";

            AddGroup("Common Data Model AssetPropertyGroupEntity Details", group =>
            {
                AssetPropertyGroupId = group.Add(new VocabularyKey(nameof(AssetPropertyGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AssetPropertyGroupId { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}