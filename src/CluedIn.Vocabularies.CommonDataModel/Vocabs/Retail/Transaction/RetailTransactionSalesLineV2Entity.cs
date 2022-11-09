using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionSalesLineV2EntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionSalesLineV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTransactionSalesLineV2Entity";
            KeyPrefix = "commonDataModel.retailtransactionsaleslinev2entity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionSalesLineV2Entity";

            AddGroup("Common Data Model RetailTransactionSalesLineV2Entity Details", group =>
            {
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BarCode = group.Add(new VocabularyKey(nameof(BarCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CatalogId = group.Add(new VocabularyKey(nameof(CatalogId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerDiscount = group.Add(new VocabularyKey(nameof(CustomerDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerInvoiceDiscountAmount = group.Add(new VocabularyKey(nameof(CustomerInvoiceDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountAmount = group.Add(new VocabularyKey(nameof(CashDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountAmountWithoutTax = group.Add(new VocabularyKey(nameof(DiscountAmountWithoutTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceGroups = group.Add(new VocabularyKey(nameof(PriceGroups), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OfferNumber = group.Add(new VocabularyKey(nameof(OfferNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountAmountForPrinting = group.Add(new VocabularyKey(nameof(DiscountAmountForPrinting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ModeOfDelivery = group.Add(new VocabularyKey(nameof(ModeOfDelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElectronicDeliveryEmail = group.Add(new VocabularyKey(nameof(ElectronicDeliveryEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailEmailAddressContent = group.Add(new VocabularyKey(nameof(RetailEmailAddressContent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GiftCard = group.Add(new VocabularyKey(nameof(GiftCard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonCodeDiscount = group.Add(new VocabularyKey(nameof(ReasonCodeDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Warehouse = group.Add(new VocabularyKey(nameof(Warehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SerialNumber = group.Add(new VocabularyKey(nameof(SerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SiteId = group.Add(new VocabularyKey(nameof(SiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryStatus = group.Add(new VocabularyKey(nameof(InventoryStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LotID = group.Add(new VocabularyKey(nameof(LotID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductScanned = group.Add(new VocabularyKey(nameof(ProductScanned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
KeyboardProductEntry = group.Add(new VocabularyKey(nameof(KeyboardProductEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscount = group.Add(new VocabularyKey(nameof(LineDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineManualDiscountAmount = group.Add(new VocabularyKey(nameof(LineManualDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineManualDiscountPercentage = group.Add(new VocabularyKey(nameof(LineManualDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLineDiscounted = group.Add(new VocabularyKey(nameof(IsLineDiscounted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLinkedProductNotOriginal = group.Add(new VocabularyKey(nameof(IsLinkedProductNotOriginal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChannelListingID = group.Add(new VocabularyKey(nameof(ChannelListingID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LogisticPostalAddressId = group.Add(new VocabularyKey(nameof(LogisticPostalAddressId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NetAmount = group.Add(new VocabularyKey(nameof(NetAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NetAmountInclusiveTax = group.Add(new VocabularyKey(nameof(NetAmountInclusiveTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NetPrice = group.Add(new VocabularyKey(nameof(NetPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOriginalOfLinkedProductList = group.Add(new VocabularyKey(nameof(IsOriginalOfLinkedProductList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalPrice = group.Add(new VocabularyKey(nameof(OriginalPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalSalesTaxGroup = group.Add(new VocabularyKey(nameof(OriginalSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(OriginalItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodicDiscountAmount = group.Add(new VocabularyKey(nameof(PeriodicDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodicDiscountGroup = group.Add(new VocabularyKey(nameof(PeriodicDiscountGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodicDiscountPercentage = group.Add(new VocabularyKey(nameof(PeriodicDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Price = group.Add(new VocabularyKey(nameof(Price), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPriceChange = group.Add(new VocabularyKey(nameof(IsPriceChange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceInBarCode = group.Add(new VocabularyKey(nameof(PriceInBarCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedReceiptDate = group.Add(new VocabularyKey(nameof(RequestedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceiptNumber = group.Add(new VocabularyKey(nameof(ReceiptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReturnLineNumber = group.Add(new VocabularyKey(nameof(ReturnLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReturnNoSale = group.Add(new VocabularyKey(nameof(IsReturnNoSale), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReturnQuantity = group.Add(new VocabularyKey(nameof(ReturnQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReturnTerminal = group.Add(new VocabularyKey(nameof(ReturnTerminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReturnTransactionNumber = group.Add(new VocabularyKey(nameof(ReturnTransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFIDTagId = group.Add(new VocabularyKey(nameof(RFIDTagId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsScaleProduct = group.Add(new VocabularyKey(nameof(IsScaleProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SectionNumber = group.Add(new VocabularyKey(nameof(SectionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShelfNumber = group.Add(new VocabularyKey(nameof(ShelfNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedShipDate = group.Add(new VocabularyKey(nameof(RequestedShipDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StandardNetPrice = group.Add(new VocabularyKey(nameof(StandardNetPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxAmount = group.Add(new VocabularyKey(nameof(SalesTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalDiscount = group.Add(new VocabularyKey(nameof(TotalDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalDiscountInfoCodeLineNum = group.Add(new VocabularyKey(nameof(TotalDiscountInfoCodeLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalDiscountPercentage = group.Add(new VocabularyKey(nameof(TotalDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionCode = group.Add(new VocabularyKey(nameof(TransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionStatus = group.Add(new VocabularyKey(nameof(TransactionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Unit = group.Add(new VocabularyKey(nameof(Unit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitQuantity = group.Add(new VocabularyKey(nameof(UnitQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VariantNumber = group.Add(new VocabularyKey(nameof(VariantNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWeightProduct = group.Add(new VocabularyKey(nameof(IsWeightProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWeightManuallyEntered = group.Add(new VocabularyKey(nameof(IsWeightManuallyEntered), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryHierarchy = group.Add(new VocabularyKey(nameof(CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LogisticsPostalAddressLocation = group.Add(new VocabularyKey(nameof(LogisticsPostalAddressLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LogisticsPostalAddressValidFrom = group.Add(new VocabularyKey(nameof(LogisticsPostalAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LogisticLocationId = group.Add(new VocabularyKey(nameof(LogisticLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailChannelTableOMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReturnOperatingUnitNumber = group.Add(new VocabularyKey(nameof(ReturnOperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemColor = group.Add(new VocabularyKey(nameof(ItemColor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSize = group.Add(new VocabularyKey(nameof(ItemSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemStyle = group.Add(new VocabularyKey(nameof(ItemStyle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemConfigId = group.Add(new VocabularyKey(nameof(ItemConfigId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SkipReports = group.Add(new VocabularyKey(nameof(SkipReports), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LinePercentageDiscount = group.Add(new VocabularyKey(nameof(LinePercentageDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BusinessDate = group.Add(new VocabularyKey(nameof(BusinessDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxExemptPriceInclusiveOriginalPrice = group.Add(new VocabularyKey(nameof(TaxExemptPriceInclusiveOriginalPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxExemptPriceInclusiveReductionAmount = group.Add(new VocabularyKey(nameof(TaxExemptPriceInclusiveReductionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SalesTaxGroup { get; private set; }
public VocabularyKey ItemSalesTaxGroup { get; private set; }
public VocabularyKey Terminal { get; private set; }
public VocabularyKey TransactionNumber { get; private set; }
public VocabularyKey BarCode { get; private set; }
public VocabularyKey CatalogId { get; private set; }
public VocabularyKey CategoryId { get; private set; }
public VocabularyKey Channel { get; private set; }
public VocabularyKey CostAmount { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey CustomerAccount { get; private set; }
public VocabularyKey CustomerDiscount { get; private set; }
public VocabularyKey CustomerInvoiceDiscountAmount { get; private set; }
public VocabularyKey CashDiscountAmount { get; private set; }
public VocabularyKey DiscountAmountWithoutTax { get; private set; }
public VocabularyKey PriceGroups { get; private set; }
public VocabularyKey OfferNumber { get; private set; }
public VocabularyKey DiscountAmountForPrinting { get; private set; }
public VocabularyKey ModeOfDelivery { get; private set; }
public VocabularyKey ElectronicDeliveryEmail { get; private set; }
public VocabularyKey RetailEmailAddressContent { get; private set; }
public VocabularyKey GiftCard { get; private set; }
public VocabularyKey ReasonCodeDiscount { get; private set; }
public VocabularyKey Warehouse { get; private set; }
public VocabularyKey SerialNumber { get; private set; }
public VocabularyKey SiteId { get; private set; }
public VocabularyKey InventoryStatus { get; private set; }
public VocabularyKey LotID { get; private set; }
public VocabularyKey ItemId { get; private set; }
public VocabularyKey ProductScanned { get; private set; }
public VocabularyKey ItemRelation { get; private set; }
public VocabularyKey KeyboardProductEntry { get; private set; }
public VocabularyKey LineDiscount { get; private set; }
public VocabularyKey LineManualDiscountAmount { get; private set; }
public VocabularyKey LineManualDiscountPercentage { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey IsLineDiscounted { get; private set; }
public VocabularyKey IsLinkedProductNotOriginal { get; private set; }
public VocabularyKey ChannelListingID { get; private set; }
public VocabularyKey LogisticPostalAddressId { get; private set; }
public VocabularyKey NetAmount { get; private set; }
public VocabularyKey NetAmountInclusiveTax { get; private set; }
public VocabularyKey NetPrice { get; private set; }
public VocabularyKey IsOriginalOfLinkedProductList { get; private set; }
public VocabularyKey OriginalPrice { get; private set; }
public VocabularyKey OriginalSalesTaxGroup { get; private set; }
public VocabularyKey OriginalItemSalesTaxGroup { get; private set; }
public VocabularyKey PeriodicDiscountAmount { get; private set; }
public VocabularyKey PeriodicDiscountGroup { get; private set; }
public VocabularyKey PeriodicDiscountPercentage { get; private set; }
public VocabularyKey Price { get; private set; }
public VocabularyKey IsPriceChange { get; private set; }
public VocabularyKey PriceInBarCode { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey RequestedReceiptDate { get; private set; }
public VocabularyKey ReceiptNumber { get; private set; }
public VocabularyKey ReturnLineNumber { get; private set; }
public VocabularyKey IsReturnNoSale { get; private set; }
public VocabularyKey ReturnQuantity { get; private set; }
public VocabularyKey ReturnTerminal { get; private set; }
public VocabularyKey ReturnTransactionNumber { get; private set; }
public VocabularyKey RFIDTagId { get; private set; }
public VocabularyKey IsScaleProduct { get; private set; }
public VocabularyKey SectionNumber { get; private set; }
public VocabularyKey ShelfNumber { get; private set; }
public VocabularyKey RequestedShipDate { get; private set; }
public VocabularyKey StandardNetPrice { get; private set; }
public VocabularyKey SalesTaxAmount { get; private set; }
public VocabularyKey TotalDiscount { get; private set; }
public VocabularyKey TotalDiscountInfoCodeLineNum { get; private set; }
public VocabularyKey TotalDiscountPercentage { get; private set; }
public VocabularyKey TransactionCode { get; private set; }
public VocabularyKey TransactionStatus { get; private set; }
public VocabularyKey Unit { get; private set; }
public VocabularyKey UnitPrice { get; private set; }
public VocabularyKey UnitQuantity { get; private set; }
public VocabularyKey VariantNumber { get; private set; }
public VocabularyKey IsWeightProduct { get; private set; }
public VocabularyKey IsWeightManuallyEntered { get; private set; }
public VocabularyKey CategoryHierarchy { get; private set; }
public VocabularyKey CategoryName { get; private set; }
public VocabularyKey CategoryHierarchyName { get; private set; }
public VocabularyKey LogisticsPostalAddressLocation { get; private set; }
public VocabularyKey LogisticsPostalAddressValidFrom { get; private set; }
public VocabularyKey LogisticLocationId { get; private set; }
public VocabularyKey RetailChannelTableOMOperatingUnitID { get; private set; }
public VocabularyKey OperatingUnitNumber { get; private set; }
public VocabularyKey ReturnOperatingUnitNumber { get; private set; }
public VocabularyKey ItemColor { get; private set; }
public VocabularyKey ItemSize { get; private set; }
public VocabularyKey ItemStyle { get; private set; }
public VocabularyKey ItemConfigId { get; private set; }
public VocabularyKey InventDimId { get; private set; }
public VocabularyKey SkipReports { get; private set; }
public VocabularyKey LinePercentageDiscount { get; private set; }
public VocabularyKey BusinessDate { get; private set; }
public VocabularyKey TransactionDate { get; private set; }
public VocabularyKey TaxExemptPriceInclusiveOriginalPrice { get; private set; }
public VocabularyKey TaxExemptPriceInclusiveReductionAmount { get; private set; }


    }
}