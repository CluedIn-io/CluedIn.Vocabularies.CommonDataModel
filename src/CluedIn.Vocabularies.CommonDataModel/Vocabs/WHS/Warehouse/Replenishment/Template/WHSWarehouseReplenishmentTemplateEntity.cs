using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseReplenishmentTemplateEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseReplenishmentTemplateEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Replenishment Template Entity";
            KeyPrefix = "commonDataModel.whswarehousereplenishmenttemplateentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseReplenishmentTemplateEntity";

            AddGroup("WHSWarehouseReplenishmentTemplateEntity Details", group =>
            {
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateDescription = group.Add(new VocabularyKey(nameof(TemplateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateType = group.Add(new VocabularyKey(nameof(TemplateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaveStepCode = group.Add(new VocabularyKey(nameof(WaveStepCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities = group.Add(new VocabularyKey(nameof(WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillDemandCancellationCancelReplenishment = group.Add(new VocabularyKey(nameof(WillDemandCancellationCancelReplenishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey TemplateDescription { get; private set; }
        public VocabularyKey TemplateType { get; private set; }
        public VocabularyKey WaveStepCode { get; private set; }
        public VocabularyKey WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities { get; private set; }
        public VocabularyKey WillDemandCancellationCancelReplenishment { get; private set; }
    }
}