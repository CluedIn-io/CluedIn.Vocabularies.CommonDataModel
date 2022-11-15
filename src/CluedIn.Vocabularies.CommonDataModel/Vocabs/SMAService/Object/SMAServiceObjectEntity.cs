using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceObjectEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceObjectEntityVocabulary()
        {
            VocabularyName = "SMA Service Object Entity";
            KeyPrefix = "commonDataModel.smaserviceobjectentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceObjectEntity";

            AddGroup("SMAServiceObjectEntity Details", group =>
            {
                ObjectDescription = group.Add(new VocabularyKey(nameof(ObjectDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceObjectGroupId = group.Add(new VocabularyKey(nameof(ServiceObjectGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ObjectId = group.Add(new VocabularyKey(nameof(ObjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceBOMTemplateId = group.Add(new VocabularyKey(nameof(ServiceBOMTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ObjectDescription { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ServiceObjectGroupId { get; private set; }
        public VocabularyKey ObjectId { get; private set; }
        public VocabularyKey ServiceBOMTemplateId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
    }
}