using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResReleasedProductWarehouseDefaultsV2EntityVocabulary : SimpleVocabulary
    {
        public EcoResReleasedProductWarehouseDefaultsV2EntityVocabulary()
        {
            VocabularyName = "Eco Res Released Product Warehouse Defaults V2 Entity";
            KeyPrefix = "commonDataModel.ecoresreleasedproductwarehousedefaultsv2entity";
            KeySeparator = ".";
            Grouping = "/EcoResReleasedProductWarehouseDefaultsV2Entity";

            AddGroup("EcoResReleasedProductWarehouseDefaultsV2Entity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductWarehouseId = group.Add(new VocabularyKey(nameof(ProductWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountingGroupId = group.Add(new VocabularyKey(nameof(CountingGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultIssueWarehouseLocationId = group.Add(new VocabularyKey(nameof(DefaultIssueWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReceiptWarehouseLocationId = group.Add(new VocabularyKey(nameof(DefaultReceiptWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickingWarehouseLocationId = group.Add(new VocabularyKey(nameof(PickingWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountingJournalNumber = group.Add(new VocabularyKey(nameof(CountingJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCountingStarted = group.Add(new VocabularyKey(nameof(IsCountingStarted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProductWarehouseId { get; private set; }
        public VocabularyKey CountingGroupId { get; private set; }
        public VocabularyKey DefaultIssueWarehouseLocationId { get; private set; }
        public VocabularyKey DefaultReceiptWarehouseLocationId { get; private set; }
        public VocabularyKey PickingWarehouseLocationId { get; private set; }
        public VocabularyKey CountingJournalNumber { get; private set; }
        public VocabularyKey IsCountingStarted { get; private set; }
    }
}