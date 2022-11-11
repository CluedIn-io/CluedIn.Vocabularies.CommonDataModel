using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymentBIAccountingToSystemExchRateVocabulary : SimpleVocabulary
    {
        public VendPaymentBIAccountingToSystemExchRateVocabulary()
        {
            VocabularyName = "Common Data Model VendPaymentBIAccountingToSystemExchRate";
            KeyPrefix = "commonDataModel.vendpaymentbiaccountingtosystemexchrate";
            KeySeparator = ".";
            Grouping = "/VendPaymentBIAccountingToSystemExchRate";

            AddGroup("Common Data Model VendPaymentBIAccountingToSystemExchRate Details", group =>
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