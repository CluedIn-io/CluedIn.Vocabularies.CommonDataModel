using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualitySamplingEntityVocabulary : SimpleVocabulary
    {
        public InventQualitySamplingEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventQualitySamplingEntity";
            KeyPrefix = "commonDataModel.inventqualitysamplingentity";
            KeySeparator = ".";
            Grouping = "/InventQualitySamplingEntity";

            AddGroup("Common Data Model InventQualitySamplingEntity Details", group =>
            {
                SamplingId = group.Add(new VocabularyKey(nameof(SamplingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SamplingDescription = group.Add(new VocabularyKey(nameof(SamplingDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedInventoryQuantity = group.Add(new VocabularyKey(nameof(FixedInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityPercentage = group.Add(new VocabularyKey(nameof(QuantityPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillQualityOrderFullyBlockOrderLineQuantity = group.Add(new VocabularyKey(nameof(WillQualityOrderFullyBlockOrderLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillEveryInventoryUpdateCreateQualityOrder = group.Add(new VocabularyKey(nameof(WillEveryInventoryUpdateCreateQualityOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQualityOrderWarehouseSpecific = group.Add(new VocabularyKey(nameof(IsQualityOrderWarehouseSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQualityOrderInventoryStatusSpecific = group.Add(new VocabularyKey(nameof(IsQualityOrderInventoryStatusSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQualityOrderWarehouseLocationSpecific = group.Add(new VocabularyKey(nameof(IsQualityOrderWarehouseLocationSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQualityOrderBatchNumberSpecific = group.Add(new VocabularyKey(nameof(IsQualityOrderBatchNumberSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQualityOrderSerialNumberSpecific = group.Add(new VocabularyKey(nameof(IsQualityOrderSerialNumberSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TestQtySpecification = group.Add(new VocabularyKey(nameof(TestQtySpecification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSamplingValue = group.Add(new VocabularyKey(nameof(ItemSamplingValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscriminatingInventoryDimensions = group.Add(new VocabularyKey(nameof(DiscriminatingInventoryDimensions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SamplingId { get; private set; }
        public VocabularyKey SamplingDescription { get; private set; }
        public VocabularyKey FixedInventoryQuantity { get; private set; }
        public VocabularyKey QuantityPercentage { get; private set; }
        public VocabularyKey WillQualityOrderFullyBlockOrderLineQuantity { get; private set; }
        public VocabularyKey WillEveryInventoryUpdateCreateQualityOrder { get; private set; }
        public VocabularyKey IsQualityOrderWarehouseSpecific { get; private set; }
        public VocabularyKey IsQualityOrderInventoryStatusSpecific { get; private set; }
        public VocabularyKey IsQualityOrderWarehouseLocationSpecific { get; private set; }
        public VocabularyKey IsQualityOrderBatchNumberSpecific { get; private set; }
        public VocabularyKey IsQualityOrderSerialNumberSpecific { get; private set; }
        public VocabularyKey TestQtySpecification { get; private set; }
        public VocabularyKey ItemSamplingValue { get; private set; }
        public VocabularyKey DiscriminatingInventoryDimensions { get; private set; }


    }
}