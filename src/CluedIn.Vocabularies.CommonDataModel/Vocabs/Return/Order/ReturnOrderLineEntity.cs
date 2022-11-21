using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReturnOrderLineEntityVocabulary : SimpleVocabulary
    {
        public ReturnOrderLineEntityVocabulary()
        {
            VocabularyName = "Return Order Line Entity";
            KeyPrefix = "commonDataModel.returnorderlineentity";
            KeySeparator = ".";
            Grouping = "/ReturnOrderLineEntity";

            AddGroup("ReturnOrderLineEntity Details", group =>
            {
                RMANumber = group.Add(new VocabularyKey(nameof(RMANumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnOrderNumber = group.Add(new VocabularyKey(nameof(ReturnOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnUnitCost = group.Add(new VocabularyKey(nameof(ReturnUnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnSalesQuantity = group.Add(new VocabularyKey(nameof(ReturnSalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceNumber = group.Add(new VocabularyKey(nameof(ReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceInventoryLotId = group.Add(new VocabularyKey(nameof(ReferenceInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceType = group.Add(new VocabularyKey(nameof(ReferenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnInventoryLotId = group.Add(new VocabularyKey(nameof(ReturnInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturningInventoryLotId = group.Add(new VocabularyKey(nameof(ReturningInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReturnCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReturnedQuantityAvailableForReservation = group.Add(new VocabularyKey(nameof(IsReturnedQuantityAvailableForReservation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualReturnArrivalDate = group.Add(new VocabularyKey(nameof(ActualReturnArrivalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnClosedDate = group.Add(new VocabularyKey(nameof(ReturnClosedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedReturnArrivalDate = group.Add(new VocabularyKey(nameof(ExpectedReturnArrivalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnDispositionCode = group.Add(new VocabularyKey(nameof(ReturnDispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnStatus = group.Add(new VocabularyKey(nameof(ReturnStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnedSalesQuantity = group.Add(new VocabularyKey(nameof(ReturnedSalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginCountryRegionId = group.Add(new VocabularyKey(nameof(OriginCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginStateId = group.Add(new VocabularyKey(nameof(OriginStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressName = group.Add(new VocabularyKey(nameof(ReturnAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnWarehouseId = group.Add(new VocabularyKey(nameof(ReturnWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnSiteId = group.Add(new VocabularyKey(nameof(ReturnSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedInventoryStatusId = group.Add(new VocabularyKey(nameof(OrderedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnPostalAddressRecId = group.Add(new VocabularyKey(nameof(ReturnPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReturnAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsReturnAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedReturnAddress = group.Add(new VocabularyKey(nameof(FormattedReturnAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(ReturnAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressCity = group.Add(new VocabularyKey(nameof(ReturnAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressCountryRegionId = group.Add(new VocabularyKey(nameof(ReturnAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(ReturnAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressCountyId = group.Add(new VocabularyKey(nameof(ReturnAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressDescription = group.Add(new VocabularyKey(nameof(ReturnAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressDistrictName = group.Add(new VocabularyKey(nameof(ReturnAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressDunsNumber = group.Add(new VocabularyKey(nameof(ReturnAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReturnAddressPrivate = group.Add(new VocabularyKey(nameof(IsReturnAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressLatitude = group.Add(new VocabularyKey(nameof(ReturnAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressLocationId = group.Add(new VocabularyKey(nameof(ReturnAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressLongitude = group.Add(new VocabularyKey(nameof(ReturnAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressPostBox = group.Add(new VocabularyKey(nameof(ReturnAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressStateId = group.Add(new VocabularyKey(nameof(ReturnAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressStreet = group.Add(new VocabularyKey(nameof(ReturnAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressStreetNumber = group.Add(new VocabularyKey(nameof(ReturnAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressZipCode = group.Add(new VocabularyKey(nameof(ReturnAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressCityInKana = group.Add(new VocabularyKey(nameof(ReturnAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressStreetInKana = group.Add(new VocabularyKey(nameof(ReturnAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressTimeZone = group.Add(new VocabularyKey(nameof(ReturnAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressValidFrom = group.Add(new VocabularyKey(nameof(ReturnAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressValidTo = group.Add(new VocabularyKey(nameof(ReturnAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RMANumber { get; private set; }
        public VocabularyKey ReturnOrderNumber { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
        public VocabularyKey ReturnUnitCost { get; private set; }
        public VocabularyKey ReturnSalesQuantity { get; private set; }
        public VocabularyKey ExternalItemNumber { get; private set; }
        public VocabularyKey ReferenceNumber { get; private set; }
        public VocabularyKey ReferenceInventoryLotId { get; private set; }
        public VocabularyKey ReferenceType { get; private set; }
        public VocabularyKey ReturnInventoryLotId { get; private set; }
        public VocabularyKey ReturningInventoryLotId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey LineAmount { get; private set; }
        public VocabularyKey LineDescription { get; private set; }
        public VocabularyKey ReturnCatchWeightQuantity { get; private set; }
        public VocabularyKey IsReturnedQuantityAvailableForReservation { get; private set; }
        public VocabularyKey ActualReturnArrivalDate { get; private set; }
        public VocabularyKey ReturnClosedDate { get; private set; }
        public VocabularyKey ExpectedReturnArrivalDate { get; private set; }
        public VocabularyKey ReturnDispositionCode { get; private set; }
        public VocabularyKey ReturnStatus { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey ReturnedSalesQuantity { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey OriginCountryRegionId { get; private set; }
        public VocabularyKey OriginStateId { get; private set; }
        public VocabularyKey ReturnAddressName { get; private set; }
        public VocabularyKey MainAccountIdDisplayValue { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ReturnWarehouseId { get; private set; }
        public VocabularyKey ReturnSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey OrderedInventoryStatusId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ReturnPostalAddressRecId { get; private set; }
        public VocabularyKey IsReturnAddressOrderSpecific { get; private set; }
        public VocabularyKey FormattedReturnAddress { get; private set; }
        public VocabularyKey ReturnAddressBuildingCompliment { get; private set; }
        public VocabularyKey ReturnAddressCity { get; private set; }
        public VocabularyKey ReturnAddressCountryRegionId { get; private set; }
        public VocabularyKey ReturnAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey ReturnAddressCountyId { get; private set; }
        public VocabularyKey ReturnAddressDescription { get; private set; }
        public VocabularyKey ReturnAddressDistrictName { get; private set; }
        public VocabularyKey ReturnAddressDunsNumber { get; private set; }
        public VocabularyKey IsReturnAddressPrivate { get; private set; }
        public VocabularyKey ReturnAddressLatitude { get; private set; }
        public VocabularyKey ReturnAddressLocationId { get; private set; }
        public VocabularyKey ReturnAddressLongitude { get; private set; }
        public VocabularyKey ReturnAddressPostBox { get; private set; }
        public VocabularyKey ReturnAddressStateId { get; private set; }
        public VocabularyKey ReturnAddressStreet { get; private set; }
        public VocabularyKey ReturnAddressStreetNumber { get; private set; }
        public VocabularyKey ReturnAddressZipCode { get; private set; }
        public VocabularyKey ReturnAddressCityInKana { get; private set; }
        public VocabularyKey ReturnAddressStreetInKana { get; private set; }
        public VocabularyKey ReturnAddressTimeZone { get; private set; }
        public VocabularyKey ReturnAddressValidFrom { get; private set; }
        public VocabularyKey ReturnAddressValidTo { get; private set; }
    }
}