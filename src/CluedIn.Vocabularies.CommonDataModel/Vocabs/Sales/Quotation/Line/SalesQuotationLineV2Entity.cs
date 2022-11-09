using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesQuotationLineV2EntityVocabulary : SimpleVocabulary
    {
        public SalesQuotationLineV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesQuotationLineV2Entity";
            KeyPrefix = "commonDataModel.salesquotationlinev2entity";
            KeySeparator = ".";
            Grouping = "/SalesQuotationLineV2Entity";

            AddGroup("Common Data Model SalesQuotationLineV2Entity Details", group =>
            {
                SalesQuotationNumber = group.Add(new VocabularyKey(nameof(SalesQuotationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesQuotationStatus = group.Add(new VocabularyKey(nameof(SalesQuotationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressRefRecId = group.Add(new VocabularyKey(nameof(AddressRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressRefTableId = group.Add(new VocabularyKey(nameof(AddressRefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesQuotationPromisingMethod = group.Add(new VocabularyKey(nameof(SalesQuotationPromisingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryTermsId = group.Add(new VocabularyKey(nameof(DeliveryTermsId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BOMId = group.Add(new VocabularyKey(nameof(BOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RouteId = group.Add(new VocabularyKey(nameof(RouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscountAmount = group.Add(new VocabularyKey(nameof(LineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscountPercentage = group.Add(new VocabularyKey(nameof(LineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MultilineDiscountAmount = group.Add(new VocabularyKey(nameof(MultilineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MultilineDiscountPercentage = group.Add(new VocabularyKey(nameof(MultilineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowedOverdeliveryPercentage = group.Add(new VocabularyKey(nameof(AllowedOverdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackingUnitSymbol = group.Add(new VocabularyKey(nameof(PackingUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatPortId = group.Add(new VocabularyKey(nameof(IntrastatPortId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPriceQuantity = group.Add(new VocabularyKey(nameof(SalesPriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedReceiptDate = group.Add(new VocabularyKey(nameof(RequestedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommissionSalesRepresentativeGroupId = group.Add(new VocabularyKey(nameof(CommissionSalesRepresentativeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedPriceCharges = group.Add(new VocabularyKey(nameof(FixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedSalesQuantity = group.Add(new VocabularyKey(nameof(RequestedSalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedShippingDate = group.Add(new VocabularyKey(nameof(RequestedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatStatisticsProcedureCode = group.Add(new VocabularyKey(nameof(IntrastatStatisticsProcedureCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntrastatTriangularDeal = group.Add(new VocabularyKey(nameof(IsIntrastatTriangularDeal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatTransactionCode = group.Add(new VocabularyKey(nameof(IntrastatTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatTransportModeCode = group.Add(new VocabularyKey(nameof(IntrastatTransportModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowedUnderdeliveryPercentage = group.Add(new VocabularyKey(nameof(AllowedUnderdeliveryPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesProductCategoryName = group.Add(new VocabularyKey(nameof(SalesProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SuframaDiscountPercentage = group.Add(new VocabularyKey(nameof(SuframaDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryValidTo = group.Add(new VocabularyKey(nameof(DeliveryValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryValidFrom = group.Add(new VocabularyKey(nameof(DeliveryValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressPostBox = group.Add(new VocabularyKey(nameof(DeliveryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressLongitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCityInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStreetInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormattedDeliveryAddress = group.Add(new VocabularyKey(nameof(FormattedDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesProductCategoryHierarchyRecId = group.Add(new VocabularyKey(nameof(SalesProductCategoryHierarchyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedInventoryStatusId = group.Add(new VocabularyKey(nameof(RequestedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingSiteId = group.Add(new VocabularyKey(nameof(ShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingWarehouseId = group.Add(new VocabularyKey(nameof(ShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatCommodityCode = group.Add(new VocabularyKey(nameof(IntrastatCommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CFOPTableRecId = group.Add(new VocabularyKey(nameof(CFOPTableRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CFOPCode = group.Add(new VocabularyKey(nameof(CFOPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineCreationSequenceNumber = group.Add(new VocabularyKey(nameof(LineCreationSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(RequestingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProspectId = group.Add(new VocabularyKey(nameof(ProspectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingWarehouseLocationId = group.Add(new VocabularyKey(nameof(ShippingWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SalesQuotationNumber { get; private set; }
public VocabularyKey InventoryLotId { get; private set; }
public VocabularyKey SalesQuotationStatus { get; private set; }
public VocabularyKey AddressRefRecId { get; private set; }
public VocabularyKey AddressRefTableId { get; private set; }
public VocabularyKey SalesQuotationPromisingMethod { get; private set; }
public VocabularyKey DeliveryAddressName { get; private set; }
public VocabularyKey DeliveryModeCode { get; private set; }
public VocabularyKey DeliveryTermsId { get; private set; }
public VocabularyKey ExternalItemNumber { get; private set; }
public VocabularyKey BOMId { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey RouteId { get; private set; }
public VocabularyKey LineAmount { get; private set; }
public VocabularyKey LineDiscountAmount { get; private set; }
public VocabularyKey LineDiscountPercentage { get; private set; }
public VocabularyKey MultilineDiscountAmount { get; private set; }
public VocabularyKey MultilineDiscountPercentage { get; private set; }
public VocabularyKey LineDescription { get; private set; }
public VocabularyKey AllowedOverdeliveryPercentage { get; private set; }
public VocabularyKey PackingUnitSymbol { get; private set; }
public VocabularyKey IntrastatPortId { get; private set; }
public VocabularyKey SalesPriceQuantity { get; private set; }
public VocabularyKey RequestedReceiptDate { get; private set; }
public VocabularyKey CommissionSalesRepresentativeGroupId { get; private set; }
public VocabularyKey FixedPriceCharges { get; private set; }
public VocabularyKey SalesPrice { get; private set; }
public VocabularyKey RequestedSalesQuantity { get; private set; }
public VocabularyKey SalesUnitSymbol { get; private set; }
public VocabularyKey RequestedShippingDate { get; private set; }
public VocabularyKey IntrastatStatisticsProcedureCode { get; private set; }
public VocabularyKey IsIntrastatTriangularDeal { get; private set; }
public VocabularyKey SalesTaxGroupCode { get; private set; }
public VocabularyKey SalesTaxItemGroupCode { get; private set; }
public VocabularyKey IntrastatTransactionCode { get; private set; }
public VocabularyKey IntrastatTransportModeCode { get; private set; }
public VocabularyKey AllowedUnderdeliveryPercentage { get; private set; }
public VocabularyKey SalesProductCategoryName { get; private set; }
public VocabularyKey SuframaDiscountPercentage { get; private set; }
public VocabularyKey DeliveryValidTo { get; private set; }
public VocabularyKey DeliveryValidFrom { get; private set; }
public VocabularyKey DeliveryAddressTimeZone { get; private set; }
public VocabularyKey DeliveryAddressZipCode { get; private set; }
public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
public VocabularyKey DeliveryAddressStreet { get; private set; }
public VocabularyKey DeliveryAddressStateId { get; private set; }
public VocabularyKey DeliveryAddressPostBox { get; private set; }
public VocabularyKey DeliveryAddressLongitude { get; private set; }
public VocabularyKey DeliveryAddressLocationId { get; private set; }
public VocabularyKey DeliveryAddressLatitude { get; private set; }
public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
public VocabularyKey DeliveryAddressDunsNumber { get; private set; }
public VocabularyKey DeliveryAddressDistrictName { get; private set; }
public VocabularyKey DeliveryAddressDescription { get; private set; }
public VocabularyKey DeliveryAddressCountyId { get; private set; }
public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
public VocabularyKey DeliveryAddressCity { get; private set; }
public VocabularyKey DeliveryAddressCityInKana { get; private set; }
public VocabularyKey DeliveryAddressStreetInKana { get; private set; }
public VocabularyKey DeliveryBuildingCompliment { get; private set; }
public VocabularyKey FormattedDeliveryAddress { get; private set; }
public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }
public VocabularyKey DeliveryPostalAddressRecId { get; private set; }
public VocabularyKey MainAccountId { get; private set; }
public VocabularyKey MainAccountIdDisplayValue { get; private set; }
public VocabularyKey DefaultLedgerDimension { get; private set; }
public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey SalesProductCategoryHierarchyRecId { get; private set; }
public VocabularyKey RequestedInventoryStatusId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ShippingSiteId { get; private set; }
public VocabularyKey ShippingWarehouseId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ItemBatchNumber { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey IntrastatCommodityCode { get; private set; }
public VocabularyKey CFOPTableRecId { get; private set; }
public VocabularyKey CFOPCode { get; private set; }
public VocabularyKey LineCreationSequenceNumber { get; private set; }
public VocabularyKey RequestingCustomerAccountNumber { get; private set; }
public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
public VocabularyKey ProspectId { get; private set; }
public VocabularyKey ShippingWarehouseLocationId { get; private set; }


    }
}