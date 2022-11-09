using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TradeOpenTradeAgreementJournalHeaderV2EntityVocabulary : SimpleVocabulary
    {
        public TradeOpenTradeAgreementJournalHeaderV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model TradeOpenTradeAgreementJournalHeaderV2Entity";
            KeyPrefix = "commonDataModel.tradeopentradeagreementjournalheaderv2entity";
            KeySeparator = ".";
            Grouping = "/TradeOpenTradeAgreementJournalHeaderV2Entity";

            AddGroup("Common Data Model TradeOpenTradeAgreementJournalHeaderV2Entity Details", group =>
            {
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTradeAgreementType = group.Add(new VocabularyKey(nameof(DefaultTradeAgreementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TradeAgreementJournalNameId = group.Add(new VocabularyKey(nameof(TradeAgreementJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalDescription = group.Add(new VocabularyKey(nameof(JournalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCurrentPriceExported = group.Add(new VocabularyKey(nameof(IsCurrentPriceExported), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey JournalNumber { get; private set; }
public VocabularyKey DefaultTradeAgreementType { get; private set; }
public VocabularyKey TradeAgreementJournalNameId { get; private set; }
public VocabularyKey JournalDescription { get; private set; }
public VocabularyKey IsCurrentPriceExported { get; private set; }


    }
}