using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CashDiscountEntityVocabulary : SimpleVocabulary
    {
        public CashDiscountEntityVocabulary()
        {
            VocabularyName = "CashDiscountEntity";
            KeyPrefix = "commonDataModel.cashdiscountentity";
            KeySeparator = ".";
            Grouping = "/CashDiscountEntity";

            AddGroup("CashDiscountEntity Details", group =>
            {
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextCashDiscountCode = group.Add(new VocabularyKey(nameof(NextCashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountMethod = group.Add(new VocabularyKey(nameof(DiscountMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetMethodForVendorDiscounts = group.Add(new VocabularyKey(nameof(OffsetMethodForVendorDiscounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfDays = group.Add(new VocabularyKey(nameof(NumberOfDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfMonths = group.Add(new VocabularyKey(nameof(NumberOfMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdForCustomerDiscounts = group.Add(new VocabularyKey(nameof(MainAccountIdForCustomerDiscounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percent = group.Add(new VocabularyKey(nameof(Percent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdForVendorDiscounts = group.Add(new VocabularyKey(nameof(MainAccountIdForVendorDiscounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdForCustomerDiscountsDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdForCustomerDiscountsDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdForVendorDiscountsDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdForVendorDiscountsDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DescriptionQRBill = group.Add(new VocabularyKey(nameof(DescriptionQRBill), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey NextCashDiscountCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DiscountMethod { get; private set; }
        public VocabularyKey OffsetMethodForVendorDiscounts { get; private set; }
        public VocabularyKey NumberOfDays { get; private set; }
        public VocabularyKey NumberOfMonths { get; private set; }
        public VocabularyKey MainAccountIdForCustomerDiscounts { get; private set; }
        public VocabularyKey Percent { get; private set; }
        public VocabularyKey MainAccountIdForVendorDiscounts { get; private set; }
        public VocabularyKey MainAccountIdForCustomerDiscountsDisplayValue { get; private set; }
        public VocabularyKey MainAccountIdForVendorDiscountsDisplayValue { get; private set; }
        public VocabularyKey DescriptionQRBill { get; private set; }


    }
}