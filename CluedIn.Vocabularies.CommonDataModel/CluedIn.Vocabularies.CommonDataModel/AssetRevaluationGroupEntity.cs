using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetRevaluationGroupEntityVocabulary : SimpleVocabulary
    {
        public AssetRevaluationGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetRevaluationGroupEntity";
            KeyPrefix = "commonDataModel.assetrevaluationgroupentity";
            KeySeparator = ".";
            Grouping = "/AssetRevaluationGroupEntity";

            AddGroup("Common Data Model AssetRevaluationGroupEntity Details", group =>
            {
                Id = group.Add(new VocabularyKey(nameof(Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Factor = group.Add(new VocabularyKey(nameof(Factor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Id { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey Factor { get; private set; }
public VocabularyKey TransDate { get; private set; }


    }
}