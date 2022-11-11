using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollTaxCodeDetailEntityVocabulary : SimpleVocabulary
    {
        public PayrollTaxCodeDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollTaxCodeDetailEntity";
            KeyPrefix = "commonDataModel.payrolltaxcodedetailentity";
            KeySeparator = ".";
            Grouping = "/PayrollTaxCodeDetailEntity";

            AddGroup("Common Data Model PayrollTaxCodeDetailEntity Details", group =>
            {
                AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rate = group.Add(new VocabularyKey(nameof(Rate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportDescription = group.Add(new VocabularyKey(nameof(ReportDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WageBase = group.Add(new VocabularyKey(nameof(WageBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcludePriorStateWages = group.Add(new VocabularyKey(nameof(ExcludePriorStateWages), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeCountryRegionId = group.Add(new VocabularyKey(nameof(TaxCodeCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey Rate { get; private set; }
        public VocabularyKey ReportDescription { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey WageBase { get; private set; }
        public VocabularyKey ExcludePriorStateWages { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey TaxCodeId { get; private set; }
        public VocabularyKey TaxCodeCountryRegionId { get; private set; }


    }
}