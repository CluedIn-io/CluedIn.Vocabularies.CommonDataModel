using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdReportSetupEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdReportSetupEntityVocabulary()
        {
            VocabularyName = "TaxWithholdReportSetupEntity";
            KeyPrefix = "commonDataModel.taxwithholdreportsetupentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdReportSetupEntity";

            AddGroup("TaxWithholdReportSetupEntity Details", group =>
            {
                TaxWithholdReportLayout_TH = group.Add(new VocabularyKey(nameof(TaxWithholdReportLayout_TH), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdVendorType_TH = group.Add(new VocabularyKey(nameof(TaxWithholdVendorType_TH), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdItemGroupHeading_TH = group.Add(new VocabularyKey(nameof(TaxWithholdItemGroupHeading_TH), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaxWithholdReportLayout_TH { get; private set; }
        public VocabularyKey TaxWithholdVendorType_TH { get; private set; }
        public VocabularyKey TaxWithholdItemGroupHeading_TH { get; private set; }


    }
}