using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerSalesTaxExchangeRateTypeCurrencyEntityVocabulary : SimpleVocabulary
    {
        public LedgerSalesTaxExchangeRateTypeCurrencyEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerSalesTaxExchangeRateTypeCurrencyEntity";
            KeyPrefix = "commonDataModel.ledgersalestaxexchangeratetypecurrencyentity";
            KeySeparator = ".";
            Grouping = "/LedgerSalesTaxExchangeRateTypeCurrencyEntity";

            AddGroup("Common Data Model LedgerSalesTaxExchangeRateTypeCurrencyEntity Details", group =>
            {
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRateTypeRecId = group.Add(new VocabularyKey(nameof(ExchangeRateTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerRecId = group.Add(new VocabularyKey(nameof(LedgerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Ledger = group.Add(new VocabularyKey(nameof(Ledger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRateType = group.Add(new VocabularyKey(nameof(ExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Currency { get; private set; }
public VocabularyKey ExchangeRateTypeRecId { get; private set; }
public VocabularyKey LedgerRecId { get; private set; }
public VocabularyKey TransactionType { get; private set; }
public VocabularyKey Ledger { get; private set; }
public VocabularyKey ExchangeRateType { get; private set; }


    }
}