using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOrderLineChargeV2EntityVocabulary : SimpleVocabulary
    {
        public SalesOrderLineChargeV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesOrderLineChargeV2Entity";
            KeyPrefix = "commonDataModel.salesorderlinechargev2entity";
            KeySeparator = ".";
            Grouping = "/SalesOrderLineChargeV2Entity";

            AddGroup("Common Data Model SalesOrderLineChargeV2Entity Details", group =>
            {
                ChargeCategory = group.Add(new VocabularyKey(nameof(ChargeCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesChargeCode = group.Add(new VocabularyKey(nameof(SalesChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeDescription = group.Add(new VocabularyKey(nameof(ChargeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeAccountingCurrencyCode = group.Add(new VocabularyKey(nameof(ChargeAccountingCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargePercentage = group.Add(new VocabularyKey(nameof(ChargePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalChargeAmount = group.Add(new VocabularyKey(nameof(ExternalChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedChargeAmount = group.Add(new VocabularyKey(nameof(FixedChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntercompanyChargePercentage = group.Add(new VocabularyKey(nameof(IntercompanyChargePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeLineNumber = group.Add(new VocabularyKey(nameof(ChargeLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(SalesOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitChargeAmount = group.Add(new VocabularyKey(nameof(UnitChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInvoiceProcessingKeepCharge = group.Add(new VocabularyKey(nameof(WillInvoiceProcessingKeepCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentTableId = group.Add(new VocabularyKey(nameof(DocumentTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRecId = group.Add(new VocabularyKey(nameof(DocumentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentStatus = group.Add(new VocabularyKey(nameof(DocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanyCharge = group.Add(new VocabularyKey(nameof(IsIntercompanyCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBrokerContractCharge = group.Add(new VocabularyKey(nameof(IsBrokerContractCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ChargeCategory { get; private set; }
        public VocabularyKey SalesChargeCode { get; private set; }
        public VocabularyKey ChargeDescription { get; private set; }
        public VocabularyKey ChargeAccountingCurrencyCode { get; private set; }
        public VocabularyKey ChargePercentage { get; private set; }
        public VocabularyKey ExternalChargeAmount { get; private set; }
        public VocabularyKey FixedChargeAmount { get; private set; }
        public VocabularyKey IntercompanyChargePercentage { get; private set; }
        public VocabularyKey ChargeLineNumber { get; private set; }
        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey SalesOrderLineInventoryLotId { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey SalesTaxItemGroupCode { get; private set; }
        public VocabularyKey UnitChargeAmount { get; private set; }
        public VocabularyKey WillInvoiceProcessingKeepCharge { get; private set; }
        public VocabularyKey DocumentTableId { get; private set; }
        public VocabularyKey DocumentRecId { get; private set; }
        public VocabularyKey DocumentStatus { get; private set; }
        public VocabularyKey IsIntercompanyCharge { get; private set; }
        public VocabularyKey IsBrokerContractCharge { get; private set; }


    }
}