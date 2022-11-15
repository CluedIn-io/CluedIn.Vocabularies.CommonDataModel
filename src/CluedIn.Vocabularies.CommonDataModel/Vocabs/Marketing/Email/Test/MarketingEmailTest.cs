using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingEmailTestVocabulary : SimpleVocabulary
    {
        public MarketingEmailTestVocabulary()
        {
            VocabularyName = "Marketing Email Test";
            KeyPrefix = "commonDataModel.marketingemailtest";
            KeySeparator = ".";
            Grouping = "/MarketingEmailTest";

            AddGroup("MarketingEmailTest Details", group =>
            {
                MarketingEmailTestId = group.Add(new VocabularyKey(nameof(MarketingEmailTestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TestProperty = group.Add(new VocabularyKey(nameof(TestProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TestPropertyCombinationType = group.Add(new VocabularyKey(nameof(TestPropertyCombinationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Teststatus = group.Add(new VocabularyKey(nameof(Teststatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MarketingEmailTestId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey TestProperty { get; private set; }
        public VocabularyKey TestPropertyCombinationType { get; private set; }
        public VocabularyKey Teststatus { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}