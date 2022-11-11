using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSOutboundSortingTemplateV2EntityVocabulary : SimpleVocabulary
    {
        public WHSOutboundSortingTemplateV2EntityVocabulary()
        {
            VocabularyName = "WHSOutboundSortingTemplateV2Entity";
            KeyPrefix = "commonDataModel.whsoutboundsortingtemplatev2entity";
            KeySeparator = ".";
            Grouping = "/WHSOutboundSortingTemplateV2Entity";

            AddGroup("WHSOutboundSortingTemplateV2Entity Details", group =>
            {
                WillPositionCloseCreateWork = group.Add(new VocabularyKey(nameof(WillPositionCloseCreateWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionAssignmentMethod = group.Add(new VocabularyKey(nameof(PositionAssignmentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateDescription = group.Add(new VocabularyKey(nameof(TemplateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateQuery = group.Add(new VocabularyKey(nameof(TemplateQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortingTemplateType = group.Add(new VocabularyKey(nameof(SortingTemplateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortingVerificationMethod = group.Add(new VocabularyKey(nameof(SortingVerificationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionAssignmentCriteria = group.Add(new VocabularyKey(nameof(PositionAssignmentCriteria), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSortingCompletionClosePosition = group.Add(new VocabularyKey(nameof(WillSortingCompletionClosePosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPositionCloseCreateContainer = group.Add(new VocabularyKey(nameof(WillPositionCloseCreateContainer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfSortingPositions = group.Add(new VocabularyKey(nameof(NumberOfSortingPositions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehousePackingProfileId = group.Add(new VocabularyKey(nameof(WarehousePackingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortingPositionPrefix = group.Add(new VocabularyKey(nameof(SortingPositionPrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaveStepCode = group.Add(new VocabularyKey(nameof(WaveStepCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WillPositionCloseCreateWork { get; private set; }
        public VocabularyKey PositionAssignmentMethod { get; private set; }
        public VocabularyKey TemplateDescription { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }
        public VocabularyKey TemplateQuery { get; private set; }
        public VocabularyKey SortingTemplateType { get; private set; }
        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey SortingVerificationMethod { get; private set; }
        public VocabularyKey PositionAssignmentCriteria { get; private set; }
        public VocabularyKey WillSortingCompletionClosePosition { get; private set; }
        public VocabularyKey WillPositionCloseCreateContainer { get; private set; }
        public VocabularyKey NumberOfSortingPositions { get; private set; }
        public VocabularyKey WarehousePackingProfileId { get; private set; }
        public VocabularyKey SortingPositionPrefix { get; private set; }
        public VocabularyKey WaveStepCode { get; private set; }


    }
}