using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerDefaultDescriptionsEntityVocabulary : SimpleVocabulary
    {
        public LedgerDefaultDescriptionsEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerDefaultDescriptionsEntity";
            KeyPrefix = "commonDataModel.ledgerdefaultdescriptionsentity";
            KeySeparator = ".";
            Grouping = "/LedgerDefaultDescriptionsEntity";

            AddGroup("Common Data Model LedgerDefaultDescriptionsEntity Details", group =>
            {
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Language { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Text { get; private set; }


    }
}