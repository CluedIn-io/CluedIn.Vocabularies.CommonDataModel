using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesPriceAgreementEntityVocabulary : SimpleVocabulary
    {
        public SalesPriceAgreementEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesPriceAgreementEntity";
            KeyPrefix = "commonDataModel.salespriceagreemententity";
            KeySeparator = ".";
            Grouping = "/SalesPriceAgreementEntity";

            AddGroup("Common Data Model SalesPriceAgreementEntity Details", group =>
            {
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Price = group.Add(new VocabularyKey(nameof(Price), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceCurrencyCode = group.Add(new VocabularyKey(nameof(PriceCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesLeadTimeDays = group.Add(new VocabularyKey(nameof(SalesLeadTimeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillDeliveryDateControlDisregardLeadTime = group.Add(new VocabularyKey(nameof(WillDeliveryDateControlDisregardLeadTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceApplicableFromDate = group.Add(new VocabularyKey(nameof(PriceApplicableFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsGenericCurrencySearchEnabled = group.Add(new VocabularyKey(nameof(IsGenericCurrencySearchEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedPriceCharges = group.Add(new VocabularyKey(nameof(FixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeBasedPricingId = group.Add(new VocabularyKey(nameof(AttributeBasedPricingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPriceQuantity = group.Add(new VocabularyKey(nameof(SalesPriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromQuantity = group.Add(new VocabularyKey(nameof(FromQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToQuantity = group.Add(new VocabularyKey(nameof(ToQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillSearchContinue = group.Add(new VocabularyKey(nameof(WillSearchContinue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceApplicableToDate = group.Add(new VocabularyKey(nameof(PriceApplicableToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuantityUnitySymbol = group.Add(new VocabularyKey(nameof(QuantityUnitySymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductconfigurationId = group.Add(new VocabularyKey(nameof(ProductconfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceSiteId = group.Add(new VocabularyKey(nameof(PriceSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceWarehouseId = group.Add(new VocabularyKey(nameof(PriceWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceCustomerGroupCode = group.Add(new VocabularyKey(nameof(PriceCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountCode { get; private set; }
public VocabularyKey AccountRelation { get; private set; }
public VocabularyKey InventDimId { get; private set; }
public VocabularyKey ItemCode { get; private set; }
public VocabularyKey ItemRelation { get; private set; }
public VocabularyKey Price { get; private set; }
public VocabularyKey PriceCurrencyCode { get; private set; }
public VocabularyKey SalesLeadTimeDays { get; private set; }
public VocabularyKey WillDeliveryDateControlDisregardLeadTime { get; private set; }
public VocabularyKey PriceApplicableFromDate { get; private set; }
public VocabularyKey IsGenericCurrencySearchEnabled { get; private set; }
public VocabularyKey FixedPriceCharges { get; private set; }
public VocabularyKey AttributeBasedPricingId { get; private set; }
public VocabularyKey SalesPriceQuantity { get; private set; }
public VocabularyKey FromQuantity { get; private set; }
public VocabularyKey ToQuantity { get; private set; }
public VocabularyKey WillSearchContinue { get; private set; }
public VocabularyKey PriceApplicableToDate { get; private set; }
public VocabularyKey QuantityUnitySymbol { get; private set; }
public VocabularyKey RecordId { get; private set; }
public VocabularyKey ProductconfigurationId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey PriceSiteId { get; private set; }
public VocabularyKey PriceWarehouseId { get; private set; }
public VocabularyKey ProductNumber { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }
public VocabularyKey PriceCustomerGroupCode { get; private set; }
public VocabularyKey ItemNumber { get; private set; }


    }
}