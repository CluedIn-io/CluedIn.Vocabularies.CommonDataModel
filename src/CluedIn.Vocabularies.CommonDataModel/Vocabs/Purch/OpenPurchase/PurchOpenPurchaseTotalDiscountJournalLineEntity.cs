using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchOpenPurchaseTotalDiscountJournalLineEntityVocabulary : SimpleVocabulary
    {
        public PurchOpenPurchaseTotalDiscountJournalLineEntityVocabulary()
        {
            VocabularyName = "Purch Open Purchase Total Discount Journal Line Entity";
            KeyPrefix = "commonDataModel.purchopenpurchasetotaldiscountjournallineentity";
            KeySeparator = ".";
            Grouping = "/PurchOpenPurchaseTotalDiscountJournalLineEntity";

            AddGroup("PurchOpenPurchaseTotalDiscountJournalLineEntity Details", group =>
            {
                TradeAgreementJournalNumber = group.Add(new VocabularyKey(nameof(TradeAgreementJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(TotalDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromOrderSubtotalAmount = group.Add(new VocabularyKey(nameof(FromOrderSubtotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToOrderSubtotalAmount = group.Add(new VocabularyKey(nameof(ToOrderSubtotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountApplicableFromDate = group.Add(new VocabularyKey(nameof(DiscountApplicableFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountApplicableToDate = group.Add(new VocabularyKey(nameof(DiscountApplicableToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountCurrencyCode = group.Add(new VocabularyKey(nameof(DiscountCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage1 = group.Add(new VocabularyKey(nameof(DiscountPercentage1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage2 = group.Add(new VocabularyKey(nameof(DiscountPercentage2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSearchContinue = group.Add(new VocabularyKey(nameof(WillSearchContinue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessingLog = group.Add(new VocabularyKey(nameof(ProcessingLog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNum = group.Add(new VocabularyKey(nameof(JournalNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TradeAgreementJournalNumber { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey TotalDiscountVendorGroupCode { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey FromOrderSubtotalAmount { get; private set; }
        public VocabularyKey ToOrderSubtotalAmount { get; private set; }
        public VocabularyKey DiscountApplicableFromDate { get; private set; }
        public VocabularyKey DiscountApplicableToDate { get; private set; }
        public VocabularyKey DiscountAmount { get; private set; }
        public VocabularyKey DiscountCurrencyCode { get; private set; }
        public VocabularyKey DiscountPercentage1 { get; private set; }
        public VocabularyKey DiscountPercentage2 { get; private set; }
        public VocabularyKey WillSearchContinue { get; private set; }
        public VocabularyKey ProcessingLog { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey JournalNum { get; private set; }
    }
}