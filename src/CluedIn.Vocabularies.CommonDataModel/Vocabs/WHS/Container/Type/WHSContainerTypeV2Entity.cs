using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSContainerTypeV2EntityVocabulary : SimpleVocabulary
    {
        public WHSContainerTypeV2EntityVocabulary()
        {
            VocabularyName = "WHS Container Type V2 Entity";
            KeyPrefix = "commonDataModel.whscontainertypev2entity";
            KeySeparator = ".";
            Grouping = "/WHSContainerTypeV2Entity";

            AddGroup("WHSContainerTypeV2Entity Details", group =>
            {
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumContainerizationHeight = group.Add(new VocabularyKey(nameof(MaximumContainerizationHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumContainerizationLength = group.Add(new VocabularyKey(nameof(MaximumContainerizationLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumContainerizationVolume = group.Add(new VocabularyKey(nameof(MaximumContainerizationVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumContainerWeight = group.Add(new VocabularyKey(nameof(MaximumContainerWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TareContainerWeight = group.Add(new VocabularyKey(nameof(TareContainerWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumContainerizationWidth = group.Add(new VocabularyKey(nameof(MaximumContainerizationWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerHeight = group.Add(new VocabularyKey(nameof(ContainerHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerLength = group.Add(new VocabularyKey(nameof(ContainerLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerVolume = group.Add(new VocabularyKey(nameof(ContainerVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerWidth = group.Add(new VocabularyKey(nameof(ContainerWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsContainerVolumeFlexible = group.Add(new VocabularyKey(nameof(IsContainerVolumeFlexible), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerTypeUnitSymbol = group.Add(new VocabularyKey(nameof(ContainerTypeUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstContainerAttributeValue = group.Add(new VocabularyKey(nameof(FirstContainerAttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondContainerAttributeValue = group.Add(new VocabularyKey(nameof(SecondContainerAttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdContainerAttributeValue = group.Add(new VocabularyKey(nameof(ThirdContainerAttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FourthContainerAttributeValue = group.Add(new VocabularyKey(nameof(FourthContainerAttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeId { get; private set; }
        public VocabularyKey TypeDescription { get; private set; }
        public VocabularyKey MaximumContainerizationHeight { get; private set; }
        public VocabularyKey MaximumContainerizationLength { get; private set; }
        public VocabularyKey MaximumContainerizationVolume { get; private set; }
        public VocabularyKey MaximumContainerWeight { get; private set; }
        public VocabularyKey TareContainerWeight { get; private set; }
        public VocabularyKey MaximumContainerizationWidth { get; private set; }
        public VocabularyKey ContainerHeight { get; private set; }
        public VocabularyKey ContainerLength { get; private set; }
        public VocabularyKey ContainerVolume { get; private set; }
        public VocabularyKey ContainerWidth { get; private set; }
        public VocabularyKey IsContainerVolumeFlexible { get; private set; }
        public VocabularyKey ContainerTypeUnitSymbol { get; private set; }
        public VocabularyKey FirstContainerAttributeValue { get; private set; }
        public VocabularyKey SecondContainerAttributeValue { get; private set; }
        public VocabularyKey ThirdContainerAttributeValue { get; private set; }
        public VocabularyKey FourthContainerAttributeValue { get; private set; }
    }
}