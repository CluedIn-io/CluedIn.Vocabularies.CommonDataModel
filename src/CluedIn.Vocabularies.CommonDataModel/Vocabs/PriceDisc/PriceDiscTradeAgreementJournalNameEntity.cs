using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscTradeAgreementJournalNameEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscTradeAgreementJournalNameEntityVocabulary()
        {
            VocabularyName = "Common Data Model PriceDiscTradeAgreementJournalNameEntity";
            KeyPrefix = "commonDataModel.pricedisctradeagreementjournalnameentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscTradeAgreementJournalNameEntity";

            AddGroup("Common Data Model PriceDiscTradeAgreementJournalNameEntity Details", group =>
            {
                DefaultTradeAgreementType = group.Add(new VocabularyKey(nameof(DefaultTradeAgreementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TradeAgreementJournalNameId = group.Add(new VocabularyKey(nameof(TradeAgreementJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultJournalDescription = group.Add(new VocabularyKey(nameof(DefaultJournalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DefaultTradeAgreementType { get; private set; }
public VocabularyKey TradeAgreementJournalNameId { get; private set; }
public VocabularyKey DefaultJournalDescription { get; private set; }


    }
}