using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvExchSetupEntityVocabulary : SimpleVocabulary
    {
        public TrvExchSetupEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvExchSetupEntity";
            KeyPrefix = "commonDataModel.trvexchsetupentity";
            KeySeparator = ".";
            Grouping = "/TrvExchSetupEntity";

            AddGroup("Common Data Model TrvExchSetupEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvanceAccountLedgerDimension = group.Add(new VocabularyKey(nameof(AdvanceAccountLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeCode = group.Add(new VocabularyKey(nameof(ExchangeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvanceAccountLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(AdvanceAccountLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey AdvanceAccountLedgerDimension { get; private set; }
        public VocabularyKey ExchangeCode { get; private set; }
        public VocabularyKey AdvanceAccountLedgerDimensionDisplayValue { get; private set; }


    }
}