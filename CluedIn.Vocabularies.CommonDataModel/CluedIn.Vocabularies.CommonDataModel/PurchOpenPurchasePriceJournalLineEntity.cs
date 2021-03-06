using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchOpenPurchasePriceJournalLineEntityVocabulary : SimpleVocabulary
    {
        public PurchOpenPurchasePriceJournalLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchOpenPurchasePriceJournalLineEntity";
            KeyPrefix = "commonDataModel.purchopenpurchasepricejournallineentity";
            KeySeparator = ".";
            Grouping = "/PurchOpenPurchasePriceJournalLineEntity";

            AddGroup("Common Data Model PurchOpenPurchasePriceJournalLineEntity Details", group =>
            {
                TradeAgreementJournalNumber = group.Add(new VocabularyKey(nameof(TradeAgreementJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceVendorGroupCode = group.Add(new VocabularyKey(nameof(PriceVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceSiteId = group.Add(new VocabularyKey(nameof(PriceSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceWarehouseId = group.Add(new VocabularyKey(nameof(PriceWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromQuantity = group.Add(new VocabularyKey(nameof(FromQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToQuantity = group.Add(new VocabularyKey(nameof(ToQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuantityUnitSymbol = group.Add(new VocabularyKey(nameof(QuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceApplicableFromDate = group.Add(new VocabularyKey(nameof(PriceApplicableFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceApplicableToDate = group.Add(new VocabularyKey(nameof(PriceApplicableToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Price = group.Add(new VocabularyKey(nameof(Price), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceCurrencyCode = group.Add(new VocabularyKey(nameof(PriceCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeBasedPricingId = group.Add(new VocabularyKey(nameof(AttributeBasedPricingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedPriceCharges = group.Add(new VocabularyKey(nameof(FixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchasePriceQuantity = group.Add(new VocabularyKey(nameof(PurchasePriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementLeadTimeDays = group.Add(new VocabularyKey(nameof(ProcurementLeadTimeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillDeliveryDateControlDisregardLeadTime = group.Add(new VocabularyKey(nameof(WillDeliveryDateControlDisregardLeadTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProcurementLeadTimeUsingWorkingDays = group.Add(new VocabularyKey(nameof(IsProcurementLeadTimeUsingWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillSearchContinue = group.Add(new VocabularyKey(nameof(WillSearchContinue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcessingLog = group.Add(new VocabularyKey(nameof(ProcessingLog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalNum = group.Add(new VocabularyKey(nameof(JournalNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TradeAgreementJournalNumber { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey PriceVendorGroupCode { get; private set; }
public VocabularyKey VendorAccountNumber { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey PriceSiteId { get; private set; }
public VocabularyKey PriceWarehouseId { get; private set; }
public VocabularyKey FromQuantity { get; private set; }
public VocabularyKey ToQuantity { get; private set; }
public VocabularyKey QuantityUnitSymbol { get; private set; }
public VocabularyKey PriceApplicableFromDate { get; private set; }
public VocabularyKey PriceApplicableToDate { get; private set; }
public VocabularyKey Price { get; private set; }
public VocabularyKey PriceCurrencyCode { get; private set; }
public VocabularyKey AttributeBasedPricingId { get; private set; }
public VocabularyKey FixedPriceCharges { get; private set; }
public VocabularyKey PurchasePriceQuantity { get; private set; }
public VocabularyKey ProcurementLeadTimeDays { get; private set; }
public VocabularyKey WillDeliveryDateControlDisregardLeadTime { get; private set; }
public VocabularyKey IsProcurementLeadTimeUsingWorkingDays { get; private set; }
public VocabularyKey WillSearchContinue { get; private set; }
public VocabularyKey ProcessingLog { get; private set; }
public VocabularyKey AccountRelation { get; private set; }
public VocabularyKey AccountCode { get; private set; }
public VocabularyKey ItemCode { get; private set; }
public VocabularyKey ItemRelation { get; private set; }
public VocabularyKey JournalNum { get; private set; }


    }
}