using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEarningExternalReportingEntityVocabulary : SimpleVocabulary
    {
        public PayrollEarningExternalReportingEntityVocabulary()
        {
            VocabularyName = "PayrollEarningExternalReportingEntity";
            KeyPrefix = "commonDataModel.payrollearningexternalreportingentity";
            KeySeparator = ".";
            Grouping = "/PayrollEarningExternalReportingEntity";

            AddGroup("PayrollEarningExternalReportingEntity Details", group =>
            {
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                W2BoxLabel = group.Add(new VocabularyKey(nameof(W2BoxLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                W2BoxNumber = group.Add(new VocabularyKey(nameof(W2BoxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey W2BoxLabel { get; private set; }
        public VocabularyKey W2BoxNumber { get; private set; }
        public VocabularyKey EarningCodeId { get; private set; }


    }
}