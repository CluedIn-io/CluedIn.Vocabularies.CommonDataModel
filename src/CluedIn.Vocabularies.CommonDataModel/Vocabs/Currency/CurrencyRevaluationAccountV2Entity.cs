using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CurrencyRevaluationAccountV2EntityVocabulary : SimpleVocabulary
    {
        public CurrencyRevaluationAccountV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model CurrencyRevaluationAccountV2Entity";
            KeyPrefix = "commonDataModel.currencyrevaluationaccountv2entity";
            KeySeparator = ".";
            Grouping = "/CurrencyRevaluationAccountV2Entity";

            AddGroup("Common Data Model CurrencyRevaluationAccountV2Entity Details", group =>
            {
                Posting = group.Add(new VocabularyKey(nameof(Posting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerName = group.Add(new VocabularyKey(nameof(LedgerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchAdjTaxableType = group.Add(new VocabularyKey(nameof(ExchAdjTaxableType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedTaxMainAccountId = group.Add(new VocabularyKey(nameof(RealizedTaxMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedTaxMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(RealizedTaxMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Posting { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey MainAccountIdDisplayValue { get; private set; }
        public VocabularyKey LedgerName { get; private set; }
        public VocabularyKey ExchAdjTaxableType { get; private set; }
        public VocabularyKey RealizedTaxMainAccountId { get; private set; }
        public VocabularyKey RealizedTaxMainAccountIdDisplayValue { get; private set; }


    }
}