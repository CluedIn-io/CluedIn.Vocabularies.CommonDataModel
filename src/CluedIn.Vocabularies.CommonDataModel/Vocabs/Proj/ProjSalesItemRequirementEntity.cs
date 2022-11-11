using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjSalesItemRequirementEntityVocabulary : SimpleVocabulary
    {
        public ProjSalesItemRequirementEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjSalesItemRequirementEntity";
            KeyPrefix = "commonDataModel.projsalesitemrequiremententity";
            KeySeparator = ".";
            Grouping = "/ProjSalesItemRequirementEntity";

            AddGroup("Common Data Model ProjSalesItemRequirementEntity Details", group =>
            {
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarCode = group.Add(new VocabularyKey(nameof(BarCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarCodeType = group.Add(new VocabularyKey(nameof(BarCodeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStatusStopped = group.Add(new VocabularyKey(nameof(IsStatusStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPartialDeliveryPrevented = group.Add(new VocabularyKey(nameof(IsPartialDeliveryPrevented), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipDate = group.Add(new VocabularyKey(nameof(ShipDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPrice = group.Add(new VocabularyKey(nameof(CostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryDateControl = group.Add(new VocabularyKey(nameof(DeliveryDateControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryName = group.Add(new VocabularyKey(nameof(DeliveryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryType = group.Add(new VocabularyKey(nameof(DeliveryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModeOfDelivery = group.Add(new VocabularyKey(nameof(ModeOfDelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTerms = group.Add(new VocabularyKey(nameof(DeliveryTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDeliverNow = group.Add(new VocabularyKey(nameof(InventDeliverNow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceNumber = group.Add(new VocabularyKey(nameof(ReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceLot = group.Add(new VocabularyKey(nameof(ReferenceLot), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceType = group.Add(new VocabularyKey(nameof(ReferenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventTransactionId = group.Add(new VocabularyKey(nameof(InventTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventTransactionReturnId = group.Add(new VocabularyKey(nameof(InventTransactionReturnId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBOMId = group.Add(new VocabularyKey(nameof(ItemBOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRouteId = group.Add(new VocabularyKey(nameof(ItemRouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetAmount = group.Add(new VocabularyKey(nameof(NetAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDeliveryType = group.Add(new VocabularyKey(nameof(LineDeliveryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Overdelivery = group.Add(new VocabularyKey(nameof(Overdelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutoBatchReservation = group.Add(new VocabularyKey(nameof(AutoBatchReservation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SameBatchSelection = group.Add(new VocabularyKey(nameof(SameBatchSelection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceUnit = group.Add(new VocabularyKey(nameof(PriceUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLinePropertyId = group.Add(new VocabularyKey(nameof(ProjectLinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTransactionId = group.Add(new VocabularyKey(nameof(ProjectTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityOrdered = group.Add(new VocabularyKey(nameof(QuantityOrdered), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptDateConfirmed = group.Add(new VocabularyKey(nameof(ReceiptDateConfirmed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptDateRequested = group.Add(new VocabularyKey(nameof(ReceiptDateRequested), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainInventFinancial = group.Add(new VocabularyKey(nameof(RemainInventFinancial), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainInventPhysical = group.Add(new VocabularyKey(nameof(RemainInventPhysical), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reservation = group.Add(new VocabularyKey(nameof(Reservation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesCategory = group.Add(new VocabularyKey(nameof(SalesCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuantity = group.Add(new VocabularyKey(nameof(SalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesStatus = group.Add(new VocabularyKey(nameof(SalesStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnit = group.Add(new VocabularyKey(nameof(SalesUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scrap = group.Add(new VocabularyKey(nameof(Scrap), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceOrderId = group.Add(new VocabularyKey(nameof(ServiceOrderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingDateConfirmed = group.Add(new VocabularyKey(nameof(ShippingDateConfirmed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingDateRequested = group.Add(new VocabularyKey(nameof(ShippingDateRequested), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroup = group.Add(new VocabularyKey(nameof(TaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroup = group.Add(new VocabularyKey(nameof(TaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Underdelivery = group.Add(new VocabularyKey(nameof(Underdelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesCategoryName = group.Add(new VocabularyKey(nameof(SalesCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDelveryAddress = group.Add(new VocabularyKey(nameof(FormattedDelveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLongitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressPostBox = group.Add(new VocabularyKey(nameof(DeliveryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidFrom = group.Add(new VocabularyKey(nameof(DeliveryValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidTo = group.Add(new VocabularyKey(nameof(DeliveryValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingWarehouseId = group.Add(new VocabularyKey(nameof(ShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingSiteId = group.Add(new VocabularyKey(nameof(ShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedInventoryStatusId = group.Add(new VocabularyKey(nameof(OrderedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCFOP = group.Add(new VocabularyKey(nameof(DeliveryCFOP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCFOPId = group.Add(new VocabularyKey(nameof(DeliveryCFOPId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey BarCode { get; private set; }
        public VocabularyKey BarCodeType { get; private set; }
        public VocabularyKey IsStatusStopped { get; private set; }
        public VocabularyKey IsPartialDeliveryPrevented { get; private set; }
        public VocabularyKey ShipDate { get; private set; }
        public VocabularyKey CostPrice { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DeliveryDateControl { get; private set; }
        public VocabularyKey DeliveryName { get; private set; }
        public VocabularyKey DeliveryType { get; private set; }
        public VocabularyKey ModeOfDelivery { get; private set; }
        public VocabularyKey DeliveryTerms { get; private set; }
        public VocabularyKey InventDeliverNow { get; private set; }
        public VocabularyKey ReferenceNumber { get; private set; }
        public VocabularyKey ReferenceLot { get; private set; }
        public VocabularyKey ReferenceType { get; private set; }
        public VocabularyKey InventTransactionId { get; private set; }
        public VocabularyKey InventTransactionReturnId { get; private set; }
        public VocabularyKey ItemBOMId { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey ItemRouteId { get; private set; }
        public VocabularyKey LedgerDimension { get; private set; }
        public VocabularyKey NetAmount { get; private set; }
        public VocabularyKey LineDeliveryType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Overdelivery { get; private set; }
        public VocabularyKey AutoBatchReservation { get; private set; }
        public VocabularyKey SameBatchSelection { get; private set; }
        public VocabularyKey PriceUnit { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectLinePropertyId { get; private set; }
        public VocabularyKey ProjectTransactionId { get; private set; }
        public VocabularyKey QuantityOrdered { get; private set; }
        public VocabularyKey ReceiptDateConfirmed { get; private set; }
        public VocabularyKey ReceiptDateRequested { get; private set; }
        public VocabularyKey RemainInventFinancial { get; private set; }
        public VocabularyKey RemainInventPhysical { get; private set; }
        public VocabularyKey Reservation { get; private set; }
        public VocabularyKey SalesCategory { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey SalesQuantity { get; private set; }
        public VocabularyKey SalesStatus { get; private set; }
        public VocabularyKey SalesUnit { get; private set; }
        public VocabularyKey Scrap { get; private set; }
        public VocabularyKey ServiceOrderId { get; private set; }
        public VocabularyKey ShippingDateConfirmed { get; private set; }
        public VocabularyKey ShippingDateRequested { get; private set; }
        public VocabularyKey TaxGroup { get; private set; }
        public VocabularyKey TaxItemGroup { get; private set; }
        public VocabularyKey Underdelivery { get; private set; }
        public VocabularyKey SalesCategoryName { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DeliveryPostalAddressRecId { get; private set; }
        public VocabularyKey FormattedDelveryAddress { get; private set; }
        public VocabularyKey DeliveryBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryAddressCountyId { get; private set; }
        public VocabularyKey DeliveryAddressDescription { get; private set; }
        public VocabularyKey DeliveryAddressDistrictName { get; private set; }
        public VocabularyKey DeliveryAddressDunsNumber { get; private set; }
        public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
        public VocabularyKey DeliveryAddressLatitude { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }
        public VocabularyKey DeliveryAddressLongitude { get; private set; }
        public VocabularyKey DeliveryAddressPostBox { get; private set; }
        public VocabularyKey DeliveryAddressStateId { get; private set; }
        public VocabularyKey DeliveryAddressStreet { get; private set; }
        public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey DeliveryAddressTimeZone { get; private set; }
        public VocabularyKey DeliveryValidFrom { get; private set; }
        public VocabularyKey DeliveryValidTo { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ShippingWarehouseId { get; private set; }
        public VocabularyKey ShippingSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey OrderedInventoryStatusId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }
        public VocabularyKey DeliveryCFOP { get; private set; }
        public VocabularyKey DeliveryCFOPId { get; private set; }


    }
}