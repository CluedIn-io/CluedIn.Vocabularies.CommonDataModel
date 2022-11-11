using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxReportingCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxReportingCodeEntityVocabulary()
        {
            VocabularyName = "TaxReportingCodeEntity";
            KeyPrefix = "commonDataModel.taxreportingcodeentity";
            KeySeparator = ".";
            Grouping = "/TaxReportingCodeEntity";

            AddGroup("TaxReportingCodeEntity Details", group =>
            {
                TaxReportingCode = group.Add(new VocabularyKey(nameof(TaxReportingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportLayout = group.Add(new VocabularyKey(nameof(ReportLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportText = group.Add(new VocabularyKey(nameof(ReportText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxCorrections = group.Add(new VocabularyKey(nameof(SalesTaxCorrections), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaxReportingCode { get; private set; }
        public VocabularyKey ReportLayout { get; private set; }
        public VocabularyKey ReportText { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey SalesTaxCorrections { get; private set; }


    }
}