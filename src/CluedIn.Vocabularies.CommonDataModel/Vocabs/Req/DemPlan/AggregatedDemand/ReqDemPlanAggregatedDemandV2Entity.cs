using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqDemPlanAggregatedDemandV2EntityVocabulary : SimpleVocabulary
    {
        public ReqDemPlanAggregatedDemandV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model ReqDemPlanAggregatedDemandV2Entity";
            KeyPrefix = "commonDataModel.reqdemplanaggregateddemandv2entity";
            KeySeparator = ".";
            Grouping = "/ReqDemPlanAggregatedDemandV2Entity";

            AddGroup("Common Data Model ReqDemPlanAggregatedDemandV2Entity Details", group =>
            {
                DemandCategory = group.Add(new VocabularyKey(nameof(DemandCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAddressCountryRegionCode = group.Add(new VocabularyKey(nameof(CustomerAddressCountryRegionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAddressStateId = group.Add(new VocabularyKey(nameof(CustomerAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerGroupId = group.Add(new VocabularyKey(nameof(CustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductAllocationKeyId = group.Add(new VocabularyKey(nameof(ProductAllocationKeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveringWarehouseId = group.Add(new VocabularyKey(nameof(DeliveringWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveringSiteId = group.Add(new VocabularyKey(nameof(DeliveringSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandDate = group.Add(new VocabularyKey(nameof(DemandDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandQuantity = group.Add(new VocabularyKey(nameof(DemandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandQuantityConfidenceIntervalLowerBound = group.Add(new VocabularyKey(nameof(DemandQuantityConfidenceIntervalLowerBound), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandQuantityConfidenceIntervalUpperBound = group.Add(new VocabularyKey(nameof(DemandQuantityConfidenceIntervalUpperBound), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DemandCategory { get; private set; }
public VocabularyKey CustomerAddressCountryRegionCode { get; private set; }
public VocabularyKey CustomerAddressStateId { get; private set; }
public VocabularyKey CustomerGroupId { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }
public VocabularyKey ProductAllocationKeyId { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey DeliveringWarehouseId { get; private set; }
public VocabularyKey DeliveringSiteId { get; private set; }
public VocabularyKey InventoryStatusId { get; private set; }
public VocabularyKey DemandDate { get; private set; }
public VocabularyKey DemandQuantity { get; private set; }
public VocabularyKey DemandQuantityConfidenceIntervalLowerBound { get; private set; }
public VocabularyKey DemandQuantityConfidenceIntervalUpperBound { get; private set; }


    }
}