using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesAutomaticSalesDocumentLineDeliveryChargeEntityVocabulary : SimpleVocabulary
    {
        public SalesAutomaticSalesDocumentLineDeliveryChargeEntityVocabulary()
        {
            VocabularyName = "Sales Automatic Sales Document Line Delivery Charge Entity";
            KeyPrefix = "commonDataModel.salesautomaticsalesdocumentlinedeliverychargeentity";
            KeySeparator = ".";
            Grouping = "/SalesAutomaticSalesDocumentLineDeliveryChargeEntity";

            AddGroup("SalesAutomaticSalesDocumentLineDeliveryChargeEntity Details", group =>
            {
                ChargingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(ChargingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargingChargeCustomerGroupId = group.Add(new VocabularyKey(nameof(ChargingChargeCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargingDeliveryModeCode = group.Add(new VocabularyKey(nameof(ChargingDeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargingChargeDeliveryGroupId = group.Add(new VocabularyKey(nameof(ChargingChargeDeliveryGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesDocumentCurrencyCode = group.Add(new VocabularyKey(nameof(SalesDocumentCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryChargeCode = group.Add(new VocabularyKey(nameof(DeliveryChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeCategory = group.Add(new VocabularyKey(nameof(ChargeCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargePercentage = group.Add(new VocabularyKey(nameof(ChargePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedChargeAmount = group.Add(new VocabularyKey(nameof(FixedChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitChargeAmount = group.Add(new VocabularyKey(nameof(UnitChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntercompanyChargePercentage = group.Add(new VocabularyKey(nameof(IntercompanyChargePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalChargeAmount = group.Add(new VocabularyKey(nameof(ExternalChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeAccountingCurrencyCode = group.Add(new VocabularyKey(nameof(ChargeAccountingCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInvoiceProcessingKeepCharge = group.Add(new VocabularyKey(nameof(WillInvoiceProcessingKeepCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DlvModeCode = group.Add(new VocabularyKey(nameof(DlvModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DlvModeRelation = group.Add(new VocabularyKey(nameof(DlvModeRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ChargingCustomerAccountNumber { get; private set; }
        public VocabularyKey ChargingChargeCustomerGroupId { get; private set; }
        public VocabularyKey ChargingDeliveryModeCode { get; private set; }
        public VocabularyKey ChargingChargeDeliveryGroupId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey SalesDocumentCurrencyCode { get; private set; }
        public VocabularyKey DeliveryChargeCode { get; private set; }
        public VocabularyKey ChargeCategory { get; private set; }
        public VocabularyKey ChargePercentage { get; private set; }
        public VocabularyKey FixedChargeAmount { get; private set; }
        public VocabularyKey UnitChargeAmount { get; private set; }
        public VocabularyKey IntercompanyChargePercentage { get; private set; }
        public VocabularyKey ExternalChargeAmount { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey ChargeAccountingCurrencyCode { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey WillInvoiceProcessingKeepCharge { get; private set; }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey DlvModeCode { get; private set; }
        public VocabularyKey DlvModeRelation { get; private set; }
    }
}