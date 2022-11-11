using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollTaxAccountingRuleEntityVocabulary : SimpleVocabulary
    {
        public PayrollTaxAccountingRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollTaxAccountingRuleEntity";
            KeyPrefix = "commonDataModel.payrolltaxaccountingruleentity";
            KeySeparator = ".";
            Grouping = "/PayrollTaxAccountingRuleEntity";

            AddGroup("Common Data Model PayrollTaxAccountingRuleEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeCountryRegionId = group.Add(new VocabularyKey(nameof(TaxCodeCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey TaxCodeId { get; private set; }
        public VocabularyKey TaxCodeCountryRegionId { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey MainAccountDisplayValue { get; private set; }


    }
}