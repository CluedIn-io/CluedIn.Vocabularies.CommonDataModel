using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationContainerTypeLimitEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationContainerTypeLimitEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseLocationContainerTypeLimitEntity";
            KeyPrefix = "commonDataModel.whswarehouselocationcontainertypelimitentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationContainerTypeLimitEntity";

            AddGroup("WHSWarehouseLocationContainerTypeLimitEntity Details", group =>
            {
                IsUnlimitedQuantityAllowed = group.Add(new VocabularyKey(nameof(IsUnlimitedQuantityAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerTypeId = group.Add(new VocabularyKey(nameof(ContainerTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationProfileId = group.Add(new VocabularyKey(nameof(WarehouseLocationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerTypeQuantityLimit = group.Add(new VocabularyKey(nameof(ContainerTypeQuantityLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerTypeQuantityLimitUnitSymbol = group.Add(new VocabularyKey(nameof(ContainerTypeQuantityLimitUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsUnlimitedQuantityAllowed { get; private set; }
        public VocabularyKey ContainerTypeId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey WarehouseLocationProfileId { get; private set; }
        public VocabularyKey ContainerTypeQuantityLimit { get; private set; }
        public VocabularyKey ContainerTypeQuantityLimitUnitSymbol { get; private set; }


    }
}