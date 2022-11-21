using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSContainerBuildTemplateV2EntityVocabulary : SimpleVocabulary
    {
        public WHSContainerBuildTemplateV2EntityVocabulary()
        {
            VocabularyName = "WHS Container Build Template V2 Entity";
            KeyPrefix = "commonDataModel.whscontainerbuildtemplatev2entity";
            KeySeparator = ".";
            Grouping = "/WHSContainerBuildTemplateV2Entity";

            AddGroup("WHSContainerBuildTemplateV2Entity Details", group =>
            {
                IsSplitPickingAllowed = group.Add(new VocabularyKey(nameof(IsSplitPickingAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerGroupId = group.Add(new VocabularyKey(nameof(ContainerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerTemplateId = group.Add(new VocabularyKey(nameof(ContainerTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerTemplateQuery = group.Add(new VocabularyKey(nameof(ContainerTemplateQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerTemplateQueryType = group.Add(new VocabularyKey(nameof(ContainerTemplateQueryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerPackingStrategy = group.Add(new VocabularyKey(nameof(ContainerPackingStrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsContainerPackedByDirectiveUnit = group.Add(new VocabularyKey(nameof(IsContainerPackedByDirectiveUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerTemplateSequenceNumber = group.Add(new VocabularyKey(nameof(ContainerTemplateSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaveStepCode = group.Add(new VocabularyKey(nameof(WaveStepCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsSplitPickingAllowed { get; private set; }
        public VocabularyKey ContainerGroupId { get; private set; }
        public VocabularyKey ContainerTemplateId { get; private set; }
        public VocabularyKey ContainerTemplateQuery { get; private set; }
        public VocabularyKey ContainerTemplateQueryType { get; private set; }
        public VocabularyKey ContainerPackingStrategy { get; private set; }
        public VocabularyKey IsContainerPackedByDirectiveUnit { get; private set; }
        public VocabularyKey ContainerTemplateSequenceNumber { get; private set; }
        public VocabularyKey WaveStepCode { get; private set; }
    }
}