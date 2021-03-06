using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetConditionEntityVocabulary : SimpleVocabulary
    {
        public AssetConditionEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetConditionEntity";
            KeyPrefix = "commonDataModel.assetconditionentity";
            KeySeparator = ".";
            Grouping = "/AssetConditionEntity";

            AddGroup("Common Data Model AssetConditionEntity Details", group =>
            {
                ConditionCode = group.Add(new VocabularyKey(nameof(ConditionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ConditionCode { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}