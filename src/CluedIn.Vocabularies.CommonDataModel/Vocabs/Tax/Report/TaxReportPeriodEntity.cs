using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxReportPeriodEntityVocabulary : SimpleVocabulary
    {
        public TaxReportPeriodEntityVocabulary()
        {
            VocabularyName = "TaxReportPeriodEntity";
            KeyPrefix = "commonDataModel.taxreportperiodentity";
            KeySeparator = ".";
            Grouping = "/TaxReportPeriodEntity";

            AddGroup("TaxReportPeriodEntity Details", group =>
            {
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxReporting = group.Add(new VocabularyKey(nameof(SalesTaxReporting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Approved = group.Add(new VocabularyKey(nameof(Approved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodStart = group.Add(new VocabularyKey(nameof(PeriodStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodEnd = group.Add(new VocabularyKey(nameof(PeriodEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingDate = group.Add(new VocabularyKey(nameof(ReportingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseTax = group.Add(new VocabularyKey(nameof(UseTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettlementPeriod = group.Add(new VocabularyKey(nameof(SettlementPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdVersion = group.Add(new VocabularyKey(nameof(TaxWithholdVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey SalesTaxReporting { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey Approved { get; private set; }
        public VocabularyKey PeriodStart { get; private set; }
        public VocabularyKey PeriodEnd { get; private set; }
        public VocabularyKey ReportingDate { get; private set; }
        public VocabularyKey UseTax { get; private set; }
        public VocabularyKey SettlementPeriod { get; private set; }
        public VocabularyKey TaxWithholdVersion { get; private set; }


    }
}