using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TradeAgreementJournalHeaderEntityVocabulary : SimpleVocabulary
    {
        public TradeAgreementJournalHeaderEntityVocabulary()
        {
            VocabularyName = "Trade Agreement Journal Header Entity";
            KeyPrefix = "commonDataModel.tradeagreementjournalheaderentity";
            KeySeparator = ".";
            Grouping = "/TradeAgreementJournalHeaderEntity";

            AddGroup("TradeAgreementJournalHeaderEntity Details", group =>
            {
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultTradeAgreementType = group.Add(new VocabularyKey(nameof(DefaultTradeAgreementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAgreementJournalNameId = group.Add(new VocabularyKey(nameof(TradeAgreementJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalDescription = group.Add(new VocabularyKey(nameof(JournalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCurrentPriceExported = group.Add(new VocabularyKey(nameof(IsCurrentPriceExported), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedDate = group.Add(new VocabularyKey(nameof(PostedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey DefaultTradeAgreementType { get; private set; }
        public VocabularyKey TradeAgreementJournalNameId { get; private set; }
        public VocabularyKey JournalDescription { get; private set; }
        public VocabularyKey IsCurrentPriceExported { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey PostedDate { get; private set; }
    }
}