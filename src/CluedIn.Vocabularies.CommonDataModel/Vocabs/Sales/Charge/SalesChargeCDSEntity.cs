using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesChargeCDSEntityVocabulary : SimpleVocabulary
    {
        public SalesChargeCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesChargeCDSEntity";
            KeyPrefix = "commonDataModel.saleschargecdsentity";
            KeySeparator = ".";
            Grouping = "/SalesChargeCDSEntity";

            AddGroup("Common Data Model SalesChargeCDSEntity Details", group =>
            {
                ChargeClassification = group.Add(new VocabularyKey(nameof(ChargeClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeCode = group.Add(new VocabularyKey(nameof(ChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeDescription = group.Add(new VocabularyKey(nameof(ChargeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditPostingMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(CreditPostingMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditPostingMethod = group.Add(new VocabularyKey(nameof(CreditPostingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditPostingType = group.Add(new VocabularyKey(nameof(CreditPostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitPostingMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(DebitPostingMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitPostingMethod = group.Add(new VocabularyKey(nameof(DebitPostingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitPostingType = group.Add(new VocabularyKey(nameof(DebitPostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillIntrastatInvoiceValueIncludeChargeAmounts = group.Add(new VocabularyKey(nameof(WillIntrastatInvoiceValueIncludeChargeAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillIntrastatStatisticalValueIncludeChargeAmounts = group.Add(new VocabularyKey(nameof(WillIntrastatStatisticalValueIncludeChargeAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesInvoicingProrateChargeAmounts = group.Add(new VocabularyKey(nameof(WillSalesInvoicingProrateChargeAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerName = group.Add(new VocabularyKey(nameof(LedgerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccountsName = group.Add(new VocabularyKey(nameof(ChartOfAccountsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ChargeClassification { get; private set; }
        public VocabularyKey ChargeCode { get; private set; }
        public VocabularyKey ChargeDescription { get; private set; }
        public VocabularyKey CreditPostingMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey CreditPostingMethod { get; private set; }
        public VocabularyKey CreditPostingType { get; private set; }
        public VocabularyKey DebitPostingMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey DebitPostingMethod { get; private set; }
        public VocabularyKey DebitPostingType { get; private set; }
        public VocabularyKey SalesTaxItemGroupCode { get; private set; }
        public VocabularyKey WillIntrastatInvoiceValueIncludeChargeAmounts { get; private set; }
        public VocabularyKey WillIntrastatStatisticalValueIncludeChargeAmounts { get; private set; }
        public VocabularyKey WillSalesInvoicingProrateChargeAmounts { get; private set; }
        public VocabularyKey LedgerName { get; private set; }
        public VocabularyKey ChartOfAccountsName { get; private set; }


    }
}