using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSNCashControlConfigurationEntityVocabulary : SimpleVocabulary
    {
        public PSNCashControlConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model PSNCashControlConfigurationEntity";
            KeyPrefix = "commonDataModel.psncashcontrolconfigurationentity";
            KeySeparator = ".";
            Grouping = "/PSNCashControlConfigurationEntity";

            AddGroup("Common Data Model PSNCashControlConfigurationEntity Details", group =>
            {
                AccountsPayableAccountLedgerDimension = group.Add(new VocabularyKey(nameof(AccountsPayableAccountLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashAccountLedgerDimension = group.Add(new VocabularyKey(nameof(CashAccountLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParticipateInCashControl = group.Add(new VocabularyKey(nameof(ParticipateInCashControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThresholdAmount = group.Add(new VocabularyKey(nameof(ThresholdAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountsPayableAccountLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(AccountsPayableAccountLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashAccountLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(CashAccountLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountsPayableAccountLedgerDimension { get; private set; }
        public VocabularyKey CashAccountLedgerDimension { get; private set; }
        public VocabularyKey ParticipateInCashControl { get; private set; }
        public VocabularyKey ThresholdAmount { get; private set; }
        public VocabularyKey AccountsPayableAccountLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey CashAccountLedgerDimensionDisplayValue { get; private set; }


    }
}