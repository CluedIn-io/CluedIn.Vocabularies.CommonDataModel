using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRRoyaltyAgreementLineAmountEntityVocabulary : SimpleVocabulary
    {
        public MCRRoyaltyAgreementLineAmountEntityVocabulary()
        {
            VocabularyName = "MCR Royalty Agreement Line Amount Entity";
            KeyPrefix = "commonDataModel.mcrroyaltyagreementlineamountentity";
            KeySeparator = ".";
            Grouping = "/MCRRoyaltyAgreementLineAmountEntity";

            AddGroup("MCRRoyaltyAgreementLineAmountEntity Details", group =>
            {
                RoyaltyAgreementId = group.Add(new VocabularyKey(nameof(RoyaltyAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoyaltyAgreementLineId = group.Add(new VocabularyKey(nameof(RoyaltyAgreementLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountTakenFrom = group.Add(new VocabularyKey(nameof(AmountTakenFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromValue = group.Add(new VocabularyKey(nameof(FromValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToValue = group.Add(new VocabularyKey(nameof(ToValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromNetSalesAmount = group.Add(new VocabularyKey(nameof(FromNetSalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromGrossSalesAmount = group.Add(new VocabularyKey(nameof(FromGrossSalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToNetSalesAmount = group.Add(new VocabularyKey(nameof(ToNetSalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToGrossSalesAmount = group.Add(new VocabularyKey(nameof(ToGrossSalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceQuantity = group.Add(new VocabularyKey(nameof(SalesPriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoyaltyValueType = group.Add(new VocabularyKey(nameof(RoyaltyValueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoyaltyValue = group.Add(new VocabularyKey(nameof(RoyaltyValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoyaltyAmountPerProductUnitSold = group.Add(new VocabularyKey(nameof(RoyaltyAmountPerProductUnitSold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedRoyaltyAmount = group.Add(new VocabularyKey(nameof(FixedRoyaltyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoyaltyPercentage = group.Add(new VocabularyKey(nameof(RoyaltyPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RoyaltyAgreementId { get; private set; }
        public VocabularyKey RoyaltyAgreementLineId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey AmountTakenFrom { get; private set; }
        public VocabularyKey FromValue { get; private set; }
        public VocabularyKey ToValue { get; private set; }
        public VocabularyKey FromNetSalesAmount { get; private set; }
        public VocabularyKey FromGrossSalesAmount { get; private set; }
        public VocabularyKey ToNetSalesAmount { get; private set; }
        public VocabularyKey ToGrossSalesAmount { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey SalesPriceQuantity { get; private set; }
        public VocabularyKey RoyaltyValueType { get; private set; }
        public VocabularyKey RoyaltyValue { get; private set; }
        public VocabularyKey RoyaltyAmountPerProductUnitSold { get; private set; }
        public VocabularyKey FixedRoyaltyAmount { get; private set; }
        public VocabularyKey RoyaltyPercentage { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
    }
}