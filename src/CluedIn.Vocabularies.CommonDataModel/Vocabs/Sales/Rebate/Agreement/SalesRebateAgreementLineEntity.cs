using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesRebateAgreementLineEntityVocabulary : SimpleVocabulary
    {
        public SalesRebateAgreementLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesRebateAgreementLineEntity";
            KeyPrefix = "commonDataModel.salesrebateagreementlineentity";
            KeySeparator = ".";
            Grouping = "/SalesRebateAgreementLineEntity";

            AddGroup("Common Data Model SalesRebateAgreementLineEntity Details", group =>
            {
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAgreementRefRecId = group.Add(new VocabularyKey(nameof(RebateAgreementRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueType = group.Add(new VocabularyKey(nameof(ValueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromAmount = group.Add(new VocabularyKey(nameof(FromAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromSalesQuantity = group.Add(new VocabularyKey(nameof(FromSalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToAmount = group.Add(new VocabularyKey(nameof(ToAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToSalesQuantity = group.Add(new VocabularyKey(nameof(ToSalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductUnitSymbol = group.Add(new VocabularyKey(nameof(ProductUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAmountPerProductUnitSold = group.Add(new VocabularyKey(nameof(RebateAmountPerProductUnitSold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedRebateAmount = group.Add(new VocabularyKey(nameof(FixedRebateAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebatePercentage = group.Add(new VocabularyKey(nameof(RebatePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAgreementId = group.Add(new VocabularyKey(nameof(RebateAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountTakenFrom = group.Add(new VocabularyKey(nameof(AmountTakenFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromNetSalesAmount = group.Add(new VocabularyKey(nameof(FromNetSalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromGrossSalesAmount = group.Add(new VocabularyKey(nameof(FromGrossSalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToNetSalesAmount = group.Add(new VocabularyKey(nameof(ToNetSalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToGrossSalesAmount = group.Add(new VocabularyKey(nameof(ToGrossSalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsValidated = group.Add(new VocabularyKey(nameof(IsValidated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidatingWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(ValidatingWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey RebateAgreementRefRecId { get; private set; }
        public VocabularyKey ValueType { get; private set; }
        public VocabularyKey FromAmount { get; private set; }
        public VocabularyKey FromSalesQuantity { get; private set; }
        public VocabularyKey ToAmount { get; private set; }
        public VocabularyKey ToSalesQuantity { get; private set; }
        public VocabularyKey ProductUnitSymbol { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey RebateAmountPerProductUnitSold { get; private set; }
        public VocabularyKey FixedRebateAmount { get; private set; }
        public VocabularyKey RebatePercentage { get; private set; }
        public VocabularyKey RebateAgreementId { get; private set; }
        public VocabularyKey AmountTakenFrom { get; private set; }
        public VocabularyKey FromNetSalesAmount { get; private set; }
        public VocabularyKey FromGrossSalesAmount { get; private set; }
        public VocabularyKey ToNetSalesAmount { get; private set; }
        public VocabularyKey ToGrossSalesAmount { get; private set; }
        public VocabularyKey IsValidated { get; private set; }
        public VocabularyKey ValidatingWorkerPersonnelNumber { get; private set; }


    }
}