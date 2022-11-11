using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustInterestCodeWithFeeEntityVocabulary : SimpleVocabulary
    {
        public CustInterestCodeWithFeeEntityVocabulary()
        {
            VocabularyName = "CustInterestCodeWithFeeEntity";
            KeyPrefix = "commonDataModel.custinterestcodewithfeeentity";
            KeySeparator = ".";
            Grouping = "/CustInterestCodeWithFeeEntity";

            AddGroup("CustInterestCodeWithFeeEntity Details", group =>
            {
                InterestCode = group.Add(new VocabularyKey(nameof(InterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestType = group.Add(new VocabularyKey(nameof(InterestType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestGraceDays = group.Add(new VocabularyKey(nameof(InterestGraceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeType = group.Add(new VocabularyKey(nameof(FeeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestByRange = group.Add(new VocabularyKey(nameof(InterestByRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestCalcType = group.Add(new VocabularyKey(nameof(InterestCalcType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestCalculateBy = group.Add(new VocabularyKey(nameof(InterestCalculateBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestCalculateByInterval = group.Add(new VocabularyKey(nameof(InterestCalculateByInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestPercent = group.Add(new VocabularyKey(nameof(InterestPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerPostingAccount = group.Add(new VocabularyKey(nameof(LedgerPostingAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerPostingAccountDisplayValue = group.Add(new VocabularyKey(nameof(LedgerPostingAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeCurrencyCode = group.Add(new VocabularyKey(nameof(FeeCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeDescription = group.Add(new VocabularyKey(nameof(FeeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeInterestValue = group.Add(new VocabularyKey(nameof(FeeInterestValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumInterestAmount = group.Add(new VocabularyKey(nameof(MaximumInterestAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumInterestAmount = group.Add(new VocabularyKey(nameof(MinimumInterestAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeCustWhenInterestExceeds = group.Add(new VocabularyKey(nameof(ChargeCustWhenInterestExceeds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeLedgerDimension = group.Add(new VocabularyKey(nameof(FeeLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(FeeLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Fee = group.Add(new VocabularyKey(nameof(Fee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeTaxItemGroup = group.Add(new VocabularyKey(nameof(FeeTaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InterestCode { get; private set; }
        public VocabularyKey InterestType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InterestGraceDays { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey FeeType { get; private set; }
        public VocabularyKey InterestByRange { get; private set; }
        public VocabularyKey InterestCalcType { get; private set; }
        public VocabularyKey InterestCalculateBy { get; private set; }
        public VocabularyKey InterestCalculateByInterval { get; private set; }
        public VocabularyKey InterestPercent { get; private set; }
        public VocabularyKey LedgerPostingAccount { get; private set; }
        public VocabularyKey LedgerPostingAccountDisplayValue { get; private set; }
        public VocabularyKey FeeCurrencyCode { get; private set; }
        public VocabularyKey FeeDescription { get; private set; }
        public VocabularyKey FeeInterestValue { get; private set; }
        public VocabularyKey MaximumInterestAmount { get; private set; }
        public VocabularyKey MinimumInterestAmount { get; private set; }
        public VocabularyKey ChargeCustWhenInterestExceeds { get; private set; }
        public VocabularyKey FeeLedgerDimension { get; private set; }
        public VocabularyKey FeeLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey Fee { get; private set; }
        public VocabularyKey FeeTaxItemGroup { get; private set; }


    }
}