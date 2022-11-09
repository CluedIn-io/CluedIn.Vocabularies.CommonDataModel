using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsCommodityQuantityMarginTemplateV2EntityVocabulary : SimpleVocabulary
    {
        public PdsCommodityQuantityMarginTemplateV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model PdsCommodityQuantityMarginTemplateV2Entity";
            KeyPrefix = "commonDataModel.pdscommodityquantitymargintemplatev2entity";
            KeySeparator = ".";
            Grouping = "/PdsCommodityQuantityMarginTemplateV2Entity";

            AddGroup("Common Data Model PdsCommodityQuantityMarginTemplateV2Entity Details", group =>
            {
                CommodityPricingTemplateId = group.Add(new VocabularyKey(nameof(CommodityPricingTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MarginAccountCode = group.Add(new VocabularyKey(nameof(MarginAccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MarginAccountRelation = group.Add(new VocabularyKey(nameof(MarginAccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceCustomerGroupCode = group.Add(new VocabularyKey(nameof(PriceCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MarginItemCode = group.Add(new VocabularyKey(nameof(MarginItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MarginItemRelation = group.Add(new VocabularyKey(nameof(MarginItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderQuantity = group.Add(new VocabularyKey(nameof(OrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromQuantity = group.Add(new VocabularyKey(nameof(FromQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToQuantity = group.Add(new VocabularyKey(nameof(ToQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostMultiplier = group.Add(new VocabularyKey(nameof(CostMultiplier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MarginAmount = group.Add(new VocabularyKey(nameof(MarginAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MarginPercentage = group.Add(new VocabularyKey(nameof(MarginPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingSiteId = group.Add(new VocabularyKey(nameof(ShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingWarehouseId = group.Add(new VocabularyKey(nameof(ShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingWarehouseLocationId = group.Add(new VocabularyKey(nameof(ShippingWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CommodityPricingTemplateId { get; private set; }
public VocabularyKey MarginAccountCode { get; private set; }
public VocabularyKey MarginAccountRelation { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }
public VocabularyKey PriceCustomerGroupCode { get; private set; }
public VocabularyKey MarginItemCode { get; private set; }
public VocabularyKey MarginItemRelation { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ProductGroupId { get; private set; }
public VocabularyKey OrderQuantity { get; private set; }
public VocabularyKey FromQuantity { get; private set; }
public VocabularyKey ToQuantity { get; private set; }
public VocabularyKey CostMultiplier { get; private set; }
public VocabularyKey MarginAmount { get; private set; }
public VocabularyKey MarginPercentage { get; private set; }
public VocabularyKey ShippingSiteId { get; private set; }
public VocabularyKey ShippingWarehouseId { get; private set; }
public VocabularyKey ShippingWarehouseLocationId { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey ItemBatchNumber { get; private set; }
public VocabularyKey ItemSerialNumber { get; private set; }


    }
}