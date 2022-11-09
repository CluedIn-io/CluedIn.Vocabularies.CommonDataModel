using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManRiskScoreGroupEntityVocabulary : SimpleVocabulary
    {
        public CredManRiskScoreGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model CredManRiskScoreGroupEntity";
            KeyPrefix = "commonDataModel.credmanriskscoregroupentity";
            KeySeparator = ".";
            Grouping = "/CredManRiskScoreGroupEntity";

            AddGroup("Common Data Model CredManRiskScoreGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RiskScoreType = group.Add(new VocabularyKey(nameof(RiskScoreType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupType = group.Add(new VocabularyKey(nameof(GroupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey GroupId { get; private set; }
public VocabularyKey RiskScoreType { get; private set; }
public VocabularyKey GroupType { get; private set; }


    }
}