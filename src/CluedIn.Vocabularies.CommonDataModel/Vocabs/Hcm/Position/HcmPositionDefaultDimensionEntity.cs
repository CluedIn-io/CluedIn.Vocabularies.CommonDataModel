using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPositionDefaultDimensionEntityVocabulary : SimpleVocabulary
    {
        public HcmPositionDefaultDimensionEntityVocabulary()
        {
            VocabularyName = "Hcm Position Default Dimension Entity";
            KeyPrefix = "commonDataModel.hcmpositiondefaultdimensionentity";
            KeySeparator = ".";
            Grouping = "/HcmPositionDefaultDimensionEntity";

            AddGroup("HcmPositionDefaultDimensionEntity Details", group =>
            {
                DistributionTemplate = group.Add(new VocabularyKey(nameof(DistributionTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityDataArea = group.Add(new VocabularyKey(nameof(LegalEntityDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistributionTemplateId = group.Add(new VocabularyKey(nameof(DistributionTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateLegalEntity = group.Add(new VocabularyKey(nameof(TemplateLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateLegalEntityId = group.Add(new VocabularyKey(nameof(TemplateLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DistributionTemplate { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey LegalEntityDataArea { get; private set; }
        public VocabularyKey DistributionTemplateId { get; private set; }
        public VocabularyKey TemplateLegalEntity { get; private set; }
        public VocabularyKey TemplateLegalEntityId { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
    }
}