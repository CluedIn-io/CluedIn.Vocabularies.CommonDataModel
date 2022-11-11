using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollTaxExternalReportingEntityVocabulary : SimpleVocabulary
    {
        public PayrollTaxExternalReportingEntityVocabulary()
        {
            VocabularyName = "PayrollTaxExternalReportingEntity";
            KeyPrefix = "commonDataModel.payrolltaxexternalreportingentity";
            KeySeparator = ".";
            Grouping = "/PayrollTaxExternalReportingEntity";

            AddGroup("PayrollTaxExternalReportingEntity Details", group =>
            {
                TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeCountryRegionId = group.Add(new VocabularyKey(nameof(TaxCodeCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                W2Box20Label = group.Add(new VocabularyKey(nameof(W2Box20Label), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                W2Box20Other = group.Add(new VocabularyKey(nameof(W2Box20Other), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                W2BoxLabel = group.Add(new VocabularyKey(nameof(W2BoxLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                W2BoxNumber = group.Add(new VocabularyKey(nameof(W2BoxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaxCodeId { get; private set; }
        public VocabularyKey TaxCodeCountryRegionId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey W2Box20Label { get; private set; }
        public VocabularyKey W2Box20Other { get; private set; }
        public VocabularyKey W2BoxLabel { get; private set; }
        public VocabularyKey W2BoxNumber { get; private set; }


    }
}