using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustAgingEntityVocabulary : SimpleVocabulary
    {
        public CustAgingEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustAgingEntity";
            KeyPrefix = "commonDataModel.custagingentity";
            KeySeparator = ".";
            Grouping = "/CustAgingEntity";

            AddGroup("Common Data Model CustAgingEntity Details", group =>
            {
                CustName = group.Add(new VocabularyKey(nameof(CustName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAccount = group.Add(new VocabularyKey(nameof(CustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriodDefinition = group.Add(new VocabularyKey(nameof(AgingPeriodDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgedBy = group.Add(new VocabularyKey(nameof(AgedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingDate = group.Add(new VocabularyKey(nameof(AgingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SumOfAmountDueMst = group.Add(new VocabularyKey(nameof(SumOfAmountDueMst), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriodLabel1 = group.Add(new VocabularyKey(nameof(AgingPeriodLabel1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod1 = group.Add(new VocabularyKey(nameof(AgingPeriod1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod1ReportingCurrency = group.Add(new VocabularyKey(nameof(AgingPeriod1ReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriodLabel2 = group.Add(new VocabularyKey(nameof(AgingPeriodLabel2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod2 = group.Add(new VocabularyKey(nameof(AgingPeriod2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod2ReportingCurrency = group.Add(new VocabularyKey(nameof(AgingPeriod2ReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriodLabel3 = group.Add(new VocabularyKey(nameof(AgingPeriodLabel3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod3 = group.Add(new VocabularyKey(nameof(AgingPeriod3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod3ReportingCurrency = group.Add(new VocabularyKey(nameof(AgingPeriod3ReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriodLabel4 = group.Add(new VocabularyKey(nameof(AgingPeriodLabel4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod4 = group.Add(new VocabularyKey(nameof(AgingPeriod4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod4ReportingCurrency = group.Add(new VocabularyKey(nameof(AgingPeriod4ReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriodLabel5 = group.Add(new VocabularyKey(nameof(AgingPeriodLabel5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod5 = group.Add(new VocabularyKey(nameof(AgingPeriod5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod5ReportingCurrency = group.Add(new VocabularyKey(nameof(AgingPeriod5ReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriodLabel6 = group.Add(new VocabularyKey(nameof(AgingPeriodLabel6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod6 = group.Add(new VocabularyKey(nameof(AgingPeriod6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod6ReportingCurrency = group.Add(new VocabularyKey(nameof(AgingPeriod6ReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstNonzeroBalancePeriod = group.Add(new VocabularyKey(nameof(FirstNonzeroBalancePeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastPaymentAmount = group.Add(new VocabularyKey(nameof(LastPaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastPaymentDate = group.Add(new VocabularyKey(nameof(LastPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumOpenInvoices = group.Add(new VocabularyKey(nameof(NumOpenInvoices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MSTCurrency = group.Add(new VocabularyKey(nameof(MSTCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustName { get; private set; }
        public VocabularyKey CustAccount { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey AgingPeriodDefinition { get; private set; }
        public VocabularyKey AgedBy { get; private set; }
        public VocabularyKey AgingDate { get; private set; }
        public VocabularyKey SumOfAmountDueMst { get; private set; }
        public VocabularyKey AgingPeriodLabel1 { get; private set; }
        public VocabularyKey AgingPeriod1 { get; private set; }
        public VocabularyKey AgingPeriod1ReportingCurrency { get; private set; }
        public VocabularyKey AgingPeriodLabel2 { get; private set; }
        public VocabularyKey AgingPeriod2 { get; private set; }
        public VocabularyKey AgingPeriod2ReportingCurrency { get; private set; }
        public VocabularyKey AgingPeriodLabel3 { get; private set; }
        public VocabularyKey AgingPeriod3 { get; private set; }
        public VocabularyKey AgingPeriod3ReportingCurrency { get; private set; }
        public VocabularyKey AgingPeriodLabel4 { get; private set; }
        public VocabularyKey AgingPeriod4 { get; private set; }
        public VocabularyKey AgingPeriod4ReportingCurrency { get; private set; }
        public VocabularyKey AgingPeriodLabel5 { get; private set; }
        public VocabularyKey AgingPeriod5 { get; private set; }
        public VocabularyKey AgingPeriod5ReportingCurrency { get; private set; }
        public VocabularyKey AgingPeriodLabel6 { get; private set; }
        public VocabularyKey AgingPeriod6 { get; private set; }
        public VocabularyKey AgingPeriod6ReportingCurrency { get; private set; }
        public VocabularyKey FirstNonzeroBalancePeriod { get; private set; }
        public VocabularyKey LastPaymentAmount { get; private set; }
        public VocabularyKey LastPaymentDate { get; private set; }
        public VocabularyKey NumOpenInvoices { get; private set; }
        public VocabularyKey MSTCurrency { get; private set; }


    }
}