using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MatchingStrategyAttributeVocabulary : SimpleVocabulary
    {
        public MatchingStrategyAttributeVocabulary()
        {
            VocabularyName = "Common Data Model MatchingStrategyAttribute";
            KeyPrefix = "commonDataModel.matchingstrategyattribute";
            KeySeparator = ".";
            Grouping = "/MatchingStrategyAttribute";

            AddGroup("Common Data Model MatchingStrategyAttribute Details", group =>
            {
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
matchingstrategyattributeId = group.Add(new VocabularyKey(nameof(matchingstrategyattributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey name { get; private set; }
public VocabularyKey matchingstrategyattributeId { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}