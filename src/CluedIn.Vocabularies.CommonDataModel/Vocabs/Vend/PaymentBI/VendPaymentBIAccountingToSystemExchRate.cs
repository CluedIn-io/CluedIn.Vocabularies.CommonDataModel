using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymentBIAccountingToSystemExchRateVocabulary : SimpleVocabulary
    {
        public VendPaymentBIAccountingToSystemExchRateVocabulary()
        {
            VocabularyName = "Vend Payment BI Accounting To System Exch Rate";
            KeyPrefix = "commonDataModel.vendpaymentbiaccountingtosystemexchrate";
            KeySeparator = ".";
            Grouping = "/VendPaymentBIAccountingToSystemExchRate";

            AddGroup("VendPaymentBIAccountingToSystemExchRate Details", group =>
            {
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CrossRate = group.Add(new VocabularyKey(nameof(CrossRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GregorianDate = group.Add(new VocabularyKey(nameof(GregorianDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrency = group.Add(new VocabularyKey(nameof(AccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey CrossRate { get; private set; }
        public VocabularyKey GregorianDate { get; private set; }
        public VocabularyKey AccountingCurrency { get; private set; }
    }
}