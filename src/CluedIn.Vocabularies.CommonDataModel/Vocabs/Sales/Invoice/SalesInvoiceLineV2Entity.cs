using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesInvoiceLineV2EntityVocabulary : SimpleVocabulary
    {
        public SalesInvoiceLineV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesInvoiceLineV2Entity";
            KeyPrefix = "commonDataModel.salesinvoicelinev2entity";
            KeySeparator = ".";
            Grouping = "/SalesInvoiceLineV2Entity";

            AddGroup("Common Data Model SalesInvoiceLineV2Entity Details", group =>
            {
                InvoicedQuantity = group.Add(new VocabularyKey(nameof(InvoicedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceNumber = group.Add(new VocabularyKey(nameof(InvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedShippingDate = group.Add(new VocabularyKey(nameof(ConfirmedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineTotalDiscountAmount = group.Add(new VocabularyKey(nameof(LineTotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineCreationSequenceNumber = group.Add(new VocabularyKey(nameof(LineCreationSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineTotalTaxAmount = group.Add(new VocabularyKey(nameof(LineTotalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineTotalChargeAmount = group.Add(new VocabularyKey(nameof(LineTotalChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventorySiteId = group.Add(new VocabularyKey(nameof(InventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryWarehouseId = group.Add(new VocabularyKey(nameof(InventoryWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedInventoryStatusId = group.Add(new VocabularyKey(nameof(OrderedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionNumber = group.Add(new VocabularyKey(nameof(DimensionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerVoucher = group.Add(new VocabularyKey(nameof(LedgerVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesProductCategoryName = group.Add(new VocabularyKey(nameof(SalesProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(SalesProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InvoicedQuantity { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey InvoiceNumber { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey ConfirmedShippingDate { get; private set; }
        public VocabularyKey LineTotalDiscountAmount { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey LineCreationSequenceNumber { get; private set; }
        public VocabularyKey LineTotalTaxAmount { get; private set; }
        public VocabularyKey LineTotalChargeAmount { get; private set; }
        public VocabularyKey LineAmount { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey InventorySiteId { get; private set; }
        public VocabularyKey InventoryWarehouseId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey OrderedInventoryStatusId { get; private set; }
        public VocabularyKey DimensionNumber { get; private set; }
        public VocabularyKey LedgerVoucher { get; private set; }
        public VocabularyKey SalesProductCategoryName { get; private set; }
        public VocabularyKey SalesProductCategoryHierarchyName { get; private set; }


    }
}