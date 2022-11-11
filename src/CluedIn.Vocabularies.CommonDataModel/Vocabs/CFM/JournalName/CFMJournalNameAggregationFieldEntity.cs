using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFMJournalNameAggregationFieldEntityVocabulary : SimpleVocabulary
    {
        public CFMJournalNameAggregationFieldEntityVocabulary()
        {
            VocabularyName = "CFMJournalNameAggregationFieldEntity";
            KeyPrefix = "commonDataModel.cfmjournalnameaggregationfieldentity";
            KeySeparator = ".";
            Grouping = "/CFMJournalNameAggregationFieldEntity";

            AddGroup("CFMJournalNameAggregationFieldEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeName = group.Add(new VocabularyKey(nameof(DimensionAttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttribute = group.Add(new VocabularyKey(nameof(DimensionAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DimensionAttributeName { get; private set; }
        public VocabularyKey DimensionAttribute { get; private set; }


    }
}