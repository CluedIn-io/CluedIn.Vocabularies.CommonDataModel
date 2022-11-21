using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MatchingStrategyAttributeVocabulary : SimpleVocabulary
    {
        public MatchingStrategyAttributeVocabulary()
        {
            VocabularyName = "Matching Strategy Attribute";
            KeyPrefix = "commonDataModel.matchingstrategyattribute";
            KeySeparator = ".";
            Grouping = "/MatchingStrategyAttribute";

            AddGroup("MatchingStrategyAttribute Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchingstrategyattributeId = group.Add(new VocabularyKey(nameof(MatchingstrategyattributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey MatchingstrategyattributeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}