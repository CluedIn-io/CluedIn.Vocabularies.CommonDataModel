using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFMJournalNameCashBalanceControlEntityVocabulary : SimpleVocabulary
    {
        public CFMJournalNameCashBalanceControlEntityVocabulary()
        {
            VocabularyName = "CFMJournalNameCashBalanceControlEntity";
            KeyPrefix = "commonDataModel.cfmjournalnamecashbalancecontrolentity";
            KeySeparator = ".";
            Grouping = "/CFMJournalNameCashBalanceControlEntity";

            AddGroup("CFMJournalNameCashBalanceControlEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumCashBalance = group.Add(new VocabularyKey(nameof(MinimumCashBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey MinimumCashBalance { get; private set; }
        public VocabularyKey Currency { get; private set; }


    }
}