using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorInvoiceLineEntityVocabulary : SimpleVocabulary
    {
        public VendorInvoiceLineEntityVocabulary()
        {
            VocabularyName = "Vendor Invoice Line Entity";
            KeyPrefix = "commonDataModel.vendorinvoicelineentity";
            KeySeparator = ".";
            Grouping = "/VendorInvoiceLineEntity";

            AddGroup("VendorInvoiceLineEntity Details", group =>
            {
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvanceApplicationReference = group.Add(new VocabularyKey(nameof(AdvanceApplicationReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangeQuantityManually = group.Add(new VocabularyKey(nameof(ChangeQuantityManually), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CloseForReceipt = group.Add(new VocabularyKey(nameof(CloseForReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountyOrigDest = group.Add(new VocabularyKey(nameof(CountyOrigDest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryName = group.Add(new VocabularyKey(nameof(DeliveryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionNumber = group.Add(new VocabularyKey(nameof(DimensionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventNow = group.Add(new VocabularyKey(nameof(InventNow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAccount = group.Add(new VocabularyKey(nameof(InvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetAmount = group.Add(new VocabularyKey(nameof(NetAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Discount = group.Add(new VocabularyKey(nameof(Discount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercent = group.Add(new VocabularyKey(nameof(DiscountPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscount = group.Add(new VocabularyKey(nameof(MultilineDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountPercentage = group.Add(new VocabularyKey(nameof(MultilineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ordering = group.Add(new VocabularyKey(nameof(Ordering), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackedExtensions = group.Add(new VocabularyKey(nameof(PackedExtensions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustedUnitPrice = group.Add(new VocabularyKey(nameof(AdjustedUnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PDSCalculationId = group.Add(new VocabularyKey(nameof(PDSCalculationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CWUpdate = group.Add(new VocabularyKey(nameof(CWUpdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CWDeliveryRemainder = group.Add(new VocabularyKey(nameof(CWDeliveryRemainder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CWRemainingQuantity = group.Add(new VocabularyKey(nameof(CWRemainingQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Port = group.Add(new VocabularyKey(nameof(Port), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceUnit = group.Add(new VocabularyKey(nameof(PriceUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategory = group.Add(new VocabularyKey(nameof(ProcurementCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReleaseAllRetainedAmount = group.Add(new VocabularyKey(nameof(ReleaseAllRetainedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percentage = group.Add(new VocabularyKey(nameof(Percentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetainageAmount = group.Add(new VocabularyKey(nameof(RetainageAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalRetainedAmount = group.Add(new VocabularyKey(nameof(TotalRetainedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetainPercentage = group.Add(new VocabularyKey(nameof(RetainPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargesOnPurchases = group.Add(new VocabularyKey(nameof(ChargesOnPurchases), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Unit = group.Add(new VocabularyKey(nameof(Unit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonTableReference = group.Add(new VocabularyKey(nameof(ReasonTableReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiveNow = group.Add(new VocabularyKey(nameof(ReceiveNow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainAfter = group.Add(new VocabularyKey(nameof(RemainAfter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainAfterInvent = group.Add(new VocabularyKey(nameof(RemainAfterInvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainBefore = group.Add(new VocabularyKey(nameof(RemainBefore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainBeforeInvent = group.Add(new VocabularyKey(nameof(RemainBeforeInvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalDeliverRemainder = group.Add(new VocabularyKey(nameof(OriginalDeliverRemainder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceLineReviewStatus = group.Add(new VocabularyKey(nameof(VendorInvoiceLineReviewStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceDocumentLine = group.Add(new VocabularyKey(nameof(SourceDocumentLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticsProcedure = group.Add(new VocabularyKey(nameof(StatisticsProcedure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrder = group.Add(new VocabularyKey(nameof(PurchaseOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099Amount = group.Add(new VocabularyKey(nameof(Tax1099Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099BoxDetailReference = group.Add(new VocabularyKey(nameof(Tax1099BoxDetailReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099Fields = group.Add(new VocabularyKey(nameof(Tax1099Fields), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryState = group.Add(new VocabularyKey(nameof(DeliveryState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099StateAmount = group.Add(new VocabularyKey(nameof(Tax1099StateAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTax = group.Add(new VocabularyKey(nameof(ItemSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxGroup = group.Add(new VocabularyKey(nameof(WithholdingTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCode = group.Add(new VocabularyKey(nameof(TransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transport = group.Add(new VocabularyKey(nameof(Transport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Commodity = group.Add(new VocabularyKey(nameof(Commodity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrigCountryRegionId = group.Add(new VocabularyKey(nameof(OrigCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateOfOrigin = group.Add(new VocabularyKey(nameof(StateOfOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionTemplateId = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyID = group.Add(new VocabularyKey(nameof(PartyID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataAreaCompany = group.Add(new VocabularyKey(nameof(DataAreaCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategoryHierarchy = group.Add(new VocabularyKey(nameof(ProcurementCategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategoryName = group.Add(new VocabularyKey(nameof(ProcurementCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProcurementCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099Box = group.Add(new VocabularyKey(nameof(Tax1099Box), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099Type = group.Add(new VocabularyKey(nameof(Tax1099Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderReference = group.Add(new VocabularyKey(nameof(HeaderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchLineNumber = group.Add(new VocabularyKey(nameof(PurchLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPCodeRecId = group.Add(new VocabularyKey(nameof(CFOPCodeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxServiceCode = group.Add(new VocabularyKey(nameof(TaxServiceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdGroup = group.Add(new VocabularyKey(nameof(TaxWithholdGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdItemGroup = group.Add(new VocabularyKey(nameof(TaxWithholdItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPCode = group.Add(new VocabularyKey(nameof(CFOPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdItemGroupName = group.Add(new VocabularyKey(nameof(TaxWithholdItemGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiotOperationType = group.Add(new VocabularyKey(nameof(DiotOperationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemName = group.Add(new VocabularyKey(nameof(ItemName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceLineNumber = group.Add(new VocabularyKey(nameof(InvoiceLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventorySiteId = group.Add(new VocabularyKey(nameof(InventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryWarehouseId = group.Add(new VocabularyKey(nameof(InventoryWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedInventoryStatusId = group.Add(new VocabularyKey(nameof(OrderedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetReservationLineRecId = group.Add(new VocabularyKey(nameof(BudgetReservationLineRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetReservationLineNumber = group.Add(new VocabularyKey(nameof(BudgetReservationLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetReservationDocumentNumber = group.Add(new VocabularyKey(nameof(BudgetReservationDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceTransactionDate = group.Add(new VocabularyKey(nameof(InvoiceTransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductFlavor = group.Add(new VocabularyKey(nameof(ProductFlavor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey AdvanceApplicationReference { get; private set; }
        public VocabularyKey ChangeQuantityManually { get; private set; }
        public VocabularyKey CloseForReceipt { get; private set; }
        public VocabularyKey CountyOrigDest { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DeliveryName { get; private set; }
        public VocabularyKey LineDescription { get; private set; }
        public VocabularyKey DimensionNumber { get; private set; }
        public VocabularyKey InventNow { get; private set; }
        public VocabularyKey InvoiceAccount { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey NetAmount { get; private set; }
        public VocabularyKey Discount { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey DiscountPercent { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey MultilineDiscount { get; private set; }
        public VocabularyKey MultilineDiscountPercentage { get; private set; }
        public VocabularyKey Ordering { get; private set; }
        public VocabularyKey PackedExtensions { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey AdjustedUnitPrice { get; private set; }
        public VocabularyKey PDSCalculationId { get; private set; }
        public VocabularyKey CWUpdate { get; private set; }
        public VocabularyKey CWDeliveryRemainder { get; private set; }
        public VocabularyKey CWRemainingQuantity { get; private set; }
        public VocabularyKey Port { get; private set; }
        public VocabularyKey PriceUnit { get; private set; }
        public VocabularyKey ProcurementCategory { get; private set; }
        public VocabularyKey ReleaseAllRetainedAmount { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Percentage { get; private set; }
        public VocabularyKey RetainageAmount { get; private set; }
        public VocabularyKey TotalRetainedAmount { get; private set; }
        public VocabularyKey RetainPercentage { get; private set; }
        public VocabularyKey ChargesOnPurchases { get; private set; }
        public VocabularyKey UnitPrice { get; private set; }
        public VocabularyKey Unit { get; private set; }
        public VocabularyKey ReasonTableReference { get; private set; }
        public VocabularyKey ReceiveNow { get; private set; }
        public VocabularyKey RemainAfter { get; private set; }
        public VocabularyKey RemainAfterInvent { get; private set; }
        public VocabularyKey RemainBefore { get; private set; }
        public VocabularyKey RemainBeforeInvent { get; private set; }
        public VocabularyKey OriginalDeliverRemainder { get; private set; }
        public VocabularyKey VendorInvoiceLineReviewStatus { get; private set; }
        public VocabularyKey SourceDocumentLine { get; private set; }
        public VocabularyKey StatisticsProcedure { get; private set; }
        public VocabularyKey PurchaseOrder { get; private set; }
        public VocabularyKey Tax1099Amount { get; private set; }
        public VocabularyKey Tax1099BoxDetailReference { get; private set; }
        public VocabularyKey Tax1099Fields { get; private set; }
        public VocabularyKey DeliveryState { get; private set; }
        public VocabularyKey Tax1099StateAmount { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey ItemSalesTax { get; private set; }
        public VocabularyKey WithholdingTaxGroup { get; private set; }
        public VocabularyKey TransactionCode { get; private set; }
        public VocabularyKey Transport { get; private set; }
        public VocabularyKey Commodity { get; private set; }
        public VocabularyKey OrigCountryRegionId { get; private set; }
        public VocabularyKey StateOfOrigin { get; private set; }
        public VocabularyKey AccountingDistributionTemplateId { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey PartyID { get; private set; }
        public VocabularyKey DataAreaCompany { get; private set; }
        public VocabularyKey ProcurementCategoryHierarchy { get; private set; }
        public VocabularyKey ProcurementCategoryName { get; private set; }
        public VocabularyKey ProcurementCategoryHierarchyName { get; private set; }
        public VocabularyKey Tax1099Box { get; private set; }
        public VocabularyKey Tax1099Type { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey MainAccountDisplayValue { get; private set; }
        public VocabularyKey HeaderReference { get; private set; }
        public VocabularyKey PurchLineNumber { get; private set; }
        public VocabularyKey CFOPCodeRecId { get; private set; }
        public VocabularyKey TaxServiceCode { get; private set; }
        public VocabularyKey TaxWithholdGroup { get; private set; }
        public VocabularyKey TaxWithholdItemGroup { get; private set; }
        public VocabularyKey CFOPCode { get; private set; }
        public VocabularyKey TaxWithholdItemGroupName { get; private set; }
        public VocabularyKey DiotOperationType { get; private set; }
        public VocabularyKey ItemName { get; private set; }
        public VocabularyKey InvoiceLineNumber { get; private set; }
        public VocabularyKey InventorySiteId { get; private set; }
        public VocabularyKey InventoryWarehouseId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey OrderedInventoryStatusId { get; private set; }
        public VocabularyKey BudgetReservationLineRecId { get; private set; }
        public VocabularyKey BudgetReservationLineNumber { get; private set; }
        public VocabularyKey BudgetReservationDocumentNumber { get; private set; }
        public VocabularyKey InvoiceTransactionDate { get; private set; }
        public VocabularyKey ProductFlavor { get; private set; }
    }
}