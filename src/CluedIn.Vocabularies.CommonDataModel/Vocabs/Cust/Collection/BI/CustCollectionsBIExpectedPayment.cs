using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBIExpectedPaymentVocabulary : SimpleVocabulary
    {
        public CustCollectionsBIExpectedPaymentVocabulary()
        {
            VocabularyName = "Common Data Model CustCollectionsBIExpectedPayment";
            KeyPrefix = "commonDataModel.custcollectionsbiexpectedpayment";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBIExpectedPayment";

            AddGroup("Common Data Model CustCollectionsBIExpectedPayment Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedPayDate = group.Add(new VocabularyKey(nameof(ExpectedPayDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemCurrencyAmounts = group.Add(new VocabularyKey(nameof(SystemCurrencyAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey ExpectedPayDate { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey SystemCurrencyAmounts { get; private set; }
        public VocabularyKey Voucher { get; private set; }


    }
}