using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqDemPlanHistoricalExternalDemandV2EntityVocabulary : SimpleVocabulary
    {
        public ReqDemPlanHistoricalExternalDemandV2EntityVocabulary()
        {
            VocabularyName = "Req Dem Plan Historical External Demand V2 Entity";
            KeyPrefix = "commonDataModel.reqdemplanhistoricalexternaldemandv2entity";
            KeySeparator = ".";
            Grouping = "/ReqDemPlanHistoricalExternalDemandV2Entity";

            AddGroup("ReqDemPlanHistoricalExternalDemandV2Entity Details", group =>
            {
                CustomerAddressCountryRegionId = group.Add(new VocabularyKey(nameof(CustomerAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                DeliveringSiteId = group.Add(new VocabularyKey(nameof(DeliveringSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveringWarehouseId = group.Add(new VocabularyKey(nameof(DeliveringWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandDate = group.Add(new VocabularyKey(nameof(DemandDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandQuantity = group.Add(new VocabularyKey(nameof(DemandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataSourceRecId = group.Add(new VocabularyKey(nameof(DataSourceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataSourceDescription = group.Add(new VocabularyKey(nameof(DataSourceDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataSourceType = group.Add(new VocabularyKey(nameof(DataSourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerAddressCountryRegionId { get; private set; }
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
        public VocabularyKey DeliveringSiteId { get; private set; }
        public VocabularyKey DeliveringWarehouseId { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey DemandDate { get; private set; }
        public VocabularyKey DemandQuantity { get; private set; }
        public VocabularyKey DataSourceRecId { get; private set; }
        public VocabularyKey DataSourceDescription { get; private set; }
        public VocabularyKey DataSourceType { get; private set; }
    }
}