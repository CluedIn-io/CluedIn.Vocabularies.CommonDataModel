using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMVendorRebateAgreementLineEntityVocabulary : SimpleVocabulary
    {
        public TAMVendorRebateAgreementLineEntityVocabulary()
        {
            VocabularyName = "TAMVendorRebateAgreementLineEntity";
            KeyPrefix = "commonDataModel.tamvendorrebateagreementlineentity";
            KeySeparator = ".";
            Grouping = "/TAMVendorRebateAgreementLineEntity";

            AddGroup("TAMVendorRebateAgreementLineEntity Details", group =>
            {
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAgreementRefRecId = group.Add(new VocabularyKey(nameof(RebateAgreementRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAmtType = group.Add(new VocabularyKey(nameof(RebateAmtType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromNetPurchaseAmount = group.Add(new VocabularyKey(nameof(FromNetPurchaseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromGrossPurchaseAmount = group.Add(new VocabularyKey(nameof(FromGrossPurchaseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAmountPerProductUnitSold = group.Add(new VocabularyKey(nameof(RebateAmountPerProductUnitSold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedRebateAmount = group.Add(new VocabularyKey(nameof(FixedRebateAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebatePercentage = group.Add(new VocabularyKey(nameof(RebatePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToNetPurchaseAmount = group.Add(new VocabularyKey(nameof(ToNetPurchaseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToGrossPurchaseAmount = group.Add(new VocabularyKey(nameof(ToGrossPurchaseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAgreementId = group.Add(new VocabularyKey(nameof(RebateAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateLineBreakType = group.Add(new VocabularyKey(nameof(RebateLineBreakType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey RebateAgreementRefRecId { get; private set; }
        public VocabularyKey RebateAmtType { get; private set; }
        public VocabularyKey UnitSymbol { get; private set; }
        public VocabularyKey FromNetPurchaseAmount { get; private set; }
        public VocabularyKey FromGrossPurchaseAmount { get; private set; }
        public VocabularyKey RebateAmountPerProductUnitSold { get; private set; }
        public VocabularyKey FixedRebateAmount { get; private set; }
        public VocabularyKey RebatePercentage { get; private set; }
        public VocabularyKey ToNetPurchaseAmount { get; private set; }
        public VocabularyKey ToGrossPurchaseAmount { get; private set; }
        public VocabularyKey RebateAgreementId { get; private set; }
        public VocabularyKey RebateLineBreakType { get; private set; }


    }
}