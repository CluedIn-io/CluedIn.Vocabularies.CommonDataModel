using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdReportingCodesEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdReportingCodesEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdReportingCodesEntity";
            KeyPrefix = "commonDataModel.taxwithholdreportingcodesentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdReportingCodesEntity";

            AddGroup("Common Data Model TaxWithholdReportingCodesEntity Details", group =>
            {
                ReportingCode = group.Add(new VocabularyKey(nameof(ReportingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxComponentGroup = group.Add(new VocabularyKey(nameof(WithholdingTaxComponentGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxComponent = group.Add(new VocabularyKey(nameof(WithholdingTaxComponent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComponentGroupForComponent = group.Add(new VocabularyKey(nameof(ComponentGroupForComponent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReportingCode { get; private set; }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey WithholdingTaxComponentGroup { get; private set; }
        public VocabularyKey WithholdingTaxComponent { get; private set; }
        public VocabularyKey ComponentGroupForComponent { get; private set; }


    }
}