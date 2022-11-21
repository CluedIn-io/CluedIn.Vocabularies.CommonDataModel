using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOrderConfirmationLineEntityVocabulary : SimpleVocabulary
    {
        public SalesOrderConfirmationLineEntityVocabulary()
        {
            VocabularyName = "Sales Order Confirmation Line Entity";
            KeyPrefix = "commonDataModel.salesorderconfirmationlineentity";
            KeySeparator = ".";
            Grouping = "/SalesOrderConfirmationLineEntity";

            AddGroup("SalesOrderConfirmationLineEntity Details", group =>
            {
                ConfirmationDate = group.Add(new VocabularyKey(nameof(ConfirmationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationNumber = group.Add(new VocabularyKey(nameof(ConfirmationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationDocumentReference = group.Add(new VocabularyKey(nameof(ConfirmationDocumentReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountPercentage = group.Add(new VocabularyKey(nameof(CashDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedShippingDate = group.Add(new VocabularyKey(nameof(ConfirmedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedInventoryQuantity = group.Add(new VocabularyKey(nameof(ConfirmedInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(SalesOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmountSalesTaxAmount = group.Add(new VocabularyKey(nameof(LineAmountSalesTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountAmount = group.Add(new VocabularyKey(nameof(LineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountPercentage = group.Add(new VocabularyKey(nameof(LineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountAmount = group.Add(new VocabularyKey(nameof(MultilineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountPercentage = group.Add(new VocabularyKey(nameof(MultilineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ConfirmedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceQuantity = group.Add(new VocabularyKey(nameof(SalesPriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedSalesQuantity = group.Add(new VocabularyKey(nameof(ConfirmedSalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionSalesRepresentativeGroupId = group.Add(new VocabularyKey(nameof(CommissionSalesRepresentativeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedPriceCharges = group.Add(new VocabularyKey(nameof(FixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalLineSalesTaxAmount = group.Add(new VocabularyKey(nameof(TotalLineSalesTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxPrintCode = group.Add(new VocabularyKey(nameof(SalesTaxPrintCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingWarehouseId = group.Add(new VocabularyKey(nameof(ShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingSiteId = group.Add(new VocabularyKey(nameof(ShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedInventoryStatusId = group.Add(new VocabularyKey(nameof(ConfirmedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(OrderingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesProductCategoryName = group.Add(new VocabularyKey(nameof(SalesProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ConfirmationDate { get; private set; }
        public VocabularyKey ConfirmationNumber { get; private set; }
        public VocabularyKey ConfirmationDocumentReference { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey DiscountAmount { get; private set; }
        public VocabularyKey CashDiscountPercentage { get; private set; }
        public VocabularyKey ConfirmedShippingDate { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey ExternalItemNumber { get; private set; }
        public VocabularyKey ConfirmedInventoryQuantity { get; private set; }
        public VocabularyKey SalesOrderLineInventoryLotId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey LineAmount { get; private set; }
        public VocabularyKey LineAmountSalesTaxAmount { get; private set; }
        public VocabularyKey LineDiscountAmount { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LineDiscountPercentage { get; private set; }
        public VocabularyKey MultilineDiscountAmount { get; private set; }
        public VocabularyKey MultilineDiscountPercentage { get; private set; }
        public VocabularyKey LineDescription { get; private set; }
        public VocabularyKey ConfirmedCatchWeightQuantity { get; private set; }
        public VocabularyKey SalesPriceQuantity { get; private set; }
        public VocabularyKey ConfirmedSalesQuantity { get; private set; }
        public VocabularyKey CommissionSalesRepresentativeGroupId { get; private set; }
        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey FixedPriceCharges { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey TotalLineSalesTaxAmount { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey SalesTaxItemGroupCode { get; private set; }
        public VocabularyKey SalesTaxPrintCode { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ShippingWarehouseId { get; private set; }
        public VocabularyKey ShippingSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ConfirmedInventoryStatusId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey OrderingCustomerAccountNumber { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
        public VocabularyKey SalesProductCategoryName { get; private set; }
    }
}