using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscPurchaseTradeAgreementActivationEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscPurchaseTradeAgreementActivationEntityVocabulary()
        {
            VocabularyName = "Common Data Model PriceDiscPurchaseTradeAgreementActivationEntity";
            KeyPrefix = "commonDataModel.pricediscpurchasetradeagreementactivationentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscPurchaseTradeAgreementActivationEntity";

            AddGroup("Common Data Model PriceDiscPurchaseTradeAgreementActivationEntity Details", group =>
            {
                IsSpecificProductSpecificVendorPriceCombinationActive = group.Add(new VocabularyKey(nameof(IsSpecificProductSpecificVendorPriceCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSpecificProductSpecificVendorGroupPriceCombinationActive = group.Add(new VocabularyKey(nameof(IsSpecificProductSpecificVendorGroupPriceCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSpecificProductAllVendorsPriceCombinationActive = group.Add(new VocabularyKey(nameof(IsSpecificProductAllVendorsPriceCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSpecificProductSpecificVendorLineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsSpecificProductSpecificVendorLineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSpecificProductSpecificVendorGroupLineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsSpecificProductSpecificVendorGroupLineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSpecificProductAllVendorsLineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsSpecificProductAllVendorsLineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSpecificProductGroupSpecificVendorLineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsSpecificProductGroupSpecificVendorLineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSpecificProductGroupSpecificVendorGroupLineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsSpecificProductGroupSpecificVendorGroupLineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSpecificProductGroupAllVendorsLineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsSpecificProductGroupAllVendorsLineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllProductsSpecificVendorLineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsAllProductsSpecificVendorLineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllProductsSpecificVendorGroupLineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsAllProductsSpecificVendorGroupLineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllProductsAllVendorsLineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsAllProductsAllVendorsLineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSpecificProductGroupSpecificVendorMultilineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsSpecificProductGroupSpecificVendorMultilineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSpecificProductGroupSpecificVendorGroupMultilineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsSpecificProductGroupSpecificVendorGroupMultilineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSpecificProductGroupAllVendorsMultilineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsSpecificProductGroupAllVendorsMultilineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllProductsSpecificVendorMultilineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsAllProductsSpecificVendorMultilineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllProductsSpecificVendorGroupMultilineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsAllProductsSpecificVendorGroupMultilineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllProductsAllVendorsMultilineDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsAllProductsAllVendorsMultilineDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllProductsSpecificVendorTotalDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsAllProductsSpecificVendorTotalDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllProductsSpecificVendorGroupTotalDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsAllProductsSpecificVendorGroupTotalDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllProductsAllVendorsTotalDiscountCombinationActive = group.Add(new VocabularyKey(nameof(IsAllProductsAllVendorsTotalDiscountCombinationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAgreementDiscountActive = group.Add(new VocabularyKey(nameof(IsAgreementDiscountActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsSpecificProductSpecificVendorPriceCombinationActive { get; private set; }
public VocabularyKey IsSpecificProductSpecificVendorGroupPriceCombinationActive { get; private set; }
public VocabularyKey IsSpecificProductAllVendorsPriceCombinationActive { get; private set; }
public VocabularyKey IsSpecificProductSpecificVendorLineDiscountCombinationActive { get; private set; }
public VocabularyKey IsSpecificProductSpecificVendorGroupLineDiscountCombinationActive { get; private set; }
public VocabularyKey IsSpecificProductAllVendorsLineDiscountCombinationActive { get; private set; }
public VocabularyKey IsSpecificProductGroupSpecificVendorLineDiscountCombinationActive { get; private set; }
public VocabularyKey IsSpecificProductGroupSpecificVendorGroupLineDiscountCombinationActive { get; private set; }
public VocabularyKey IsSpecificProductGroupAllVendorsLineDiscountCombinationActive { get; private set; }
public VocabularyKey IsAllProductsSpecificVendorLineDiscountCombinationActive { get; private set; }
public VocabularyKey IsAllProductsSpecificVendorGroupLineDiscountCombinationActive { get; private set; }
public VocabularyKey IsAllProductsAllVendorsLineDiscountCombinationActive { get; private set; }
public VocabularyKey IsSpecificProductGroupSpecificVendorMultilineDiscountCombinationActive { get; private set; }
public VocabularyKey IsSpecificProductGroupSpecificVendorGroupMultilineDiscountCombinationActive { get; private set; }
public VocabularyKey IsSpecificProductGroupAllVendorsMultilineDiscountCombinationActive { get; private set; }
public VocabularyKey IsAllProductsSpecificVendorMultilineDiscountCombinationActive { get; private set; }
public VocabularyKey IsAllProductsSpecificVendorGroupMultilineDiscountCombinationActive { get; private set; }
public VocabularyKey IsAllProductsAllVendorsMultilineDiscountCombinationActive { get; private set; }
public VocabularyKey IsAllProductsSpecificVendorTotalDiscountCombinationActive { get; private set; }
public VocabularyKey IsAllProductsSpecificVendorGroupTotalDiscountCombinationActive { get; private set; }
public VocabularyKey IsAllProductsAllVendorsTotalDiscountCombinationActive { get; private set; }
public VocabularyKey IsAgreementDiscountActive { get; private set; }


    }
}