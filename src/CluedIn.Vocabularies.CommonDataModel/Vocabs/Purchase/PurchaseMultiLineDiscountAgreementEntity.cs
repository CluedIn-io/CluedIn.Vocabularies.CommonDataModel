using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchaseMultiLineDiscountAgreementEntityVocabulary : SimpleVocabulary
    {
        public PurchaseMultiLineDiscountAgreementEntityVocabulary()
        {
            VocabularyName = "PurchaseMultiLineDiscountAgreementEntity";
            KeyPrefix = "commonDataModel.purchasemultilinediscountagreemententity";
            KeySeparator = ".";
            Grouping = "/PurchaseMultiLineDiscountAgreementEntity";

            AddGroup("PurchaseMultiLineDiscountAgreementEntity Details", group =>
            {
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountCurrencyCode = group.Add(new VocabularyKey(nameof(DiscountCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountApplicableFromDate = group.Add(new VocabularyKey(nameof(DiscountApplicableFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage1 = group.Add(new VocabularyKey(nameof(DiscountPercentage1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage2 = group.Add(new VocabularyKey(nameof(DiscountPercentage2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromQuantity = group.Add(new VocabularyKey(nameof(FromQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToQuantity = group.Add(new VocabularyKey(nameof(ToQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSearchContinue = group.Add(new VocabularyKey(nameof(WillSearchContinue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountApplicableToDate = group.Add(new VocabularyKey(nameof(DiscountApplicableToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityUnitSymbol = group.Add(new VocabularyKey(nameof(QuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultiLineDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(MultiLineDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultiLineDiscountProductGroupCode = group.Add(new VocabularyKey(nameof(MultiLineDiscountProductGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey DiscountAmount { get; private set; }
        public VocabularyKey DiscountCurrencyCode { get; private set; }
        public VocabularyKey DiscountApplicableFromDate { get; private set; }
        public VocabularyKey InventDimId { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey DiscountPercentage1 { get; private set; }
        public VocabularyKey DiscountPercentage2 { get; private set; }
        public VocabularyKey FromQuantity { get; private set; }
        public VocabularyKey ToQuantity { get; private set; }
        public VocabularyKey WillSearchContinue { get; private set; }
        public VocabularyKey DiscountApplicableToDate { get; private set; }
        public VocabularyKey QuantityUnitSymbol { get; private set; }
        public VocabularyKey RecordId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey MultiLineDiscountVendorGroupCode { get; private set; }
        public VocabularyKey MultiLineDiscountProductGroupCode { get; private set; }


    }
}