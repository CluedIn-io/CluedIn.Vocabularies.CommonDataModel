using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReturnAutomaticReturnDispositionCodeChargeEntityVocabulary : SimpleVocabulary
    {
        public ReturnAutomaticReturnDispositionCodeChargeEntityVocabulary()
        {
            VocabularyName = "ReturnAutomaticReturnDispositionCodeChargeEntity";
            KeyPrefix = "commonDataModel.returnautomaticreturndispositioncodechargeentity";
            KeySeparator = ".";
            Grouping = "/ReturnAutomaticReturnDispositionCodeChargeEntity";

            AddGroup("ReturnAutomaticReturnDispositionCodeChargeEntity Details", group =>
            {
                ReturnDispositionCode = group.Add(new VocabularyKey(nameof(ReturnDispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnRelation = group.Add(new VocabularyKey(nameof(ReturnRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnOrderCurrencyCode = group.Add(new VocabularyKey(nameof(ReturnOrderCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesChargeCode = group.Add(new VocabularyKey(nameof(SalesChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeCategory = group.Add(new VocabularyKey(nameof(ChargeCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargePercentage = group.Add(new VocabularyKey(nameof(ChargePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedChargeAmount = group.Add(new VocabularyKey(nameof(FixedChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitChargeAmount = group.Add(new VocabularyKey(nameof(UnitChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntercompanyChargePercentage = group.Add(new VocabularyKey(nameof(IntercompanyChargePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeAccountingCurrencyCode = group.Add(new VocabularyKey(nameof(ChargeAccountingCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInvoiceProcessingKeepCharge = group.Add(new VocabularyKey(nameof(WillInvoiceProcessingKeepCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReturnDispositionCode { get; private set; }
        public VocabularyKey ReturnRelation { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey ReturnOrderCurrencyCode { get; private set; }
        public VocabularyKey SalesChargeCode { get; private set; }
        public VocabularyKey ChargeCategory { get; private set; }
        public VocabularyKey ChargePercentage { get; private set; }
        public VocabularyKey FixedChargeAmount { get; private set; }
        public VocabularyKey UnitChargeAmount { get; private set; }
        public VocabularyKey IntercompanyChargePercentage { get; private set; }
        public VocabularyKey ChargeAccountingCurrencyCode { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey WillInvoiceProcessingKeepCharge { get; private set; }


    }
}