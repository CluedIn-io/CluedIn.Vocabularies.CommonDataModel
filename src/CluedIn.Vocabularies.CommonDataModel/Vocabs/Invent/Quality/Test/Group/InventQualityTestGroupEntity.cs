using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityTestGroupEntityVocabulary : SimpleVocabulary
    {
        public InventQualityTestGroupEntityVocabulary()
        {
            VocabularyName = "Invent Quality Test Group Entity";
            KeyPrefix = "commonDataModel.inventqualitytestgroupentity";
            KeySeparator = ".";
            Grouping = "/InventQualityTestGroupEntity";

            AddGroup("InventQualityTestGroupEntity Details", group =>
            {
                AcceptableQualityLevelPercentage = group.Add(new VocabularyKey(nameof(AcceptableQualityLevelPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FailedQualityOrderInventoryStatusId = group.Add(new VocabularyKey(nameof(FailedQualityOrderInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSamplingId = group.Add(new VocabularyKey(nameof(ItemSamplingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PassedQualityOrderInventoryStatusId = group.Add(new VocabularyKey(nameof(PassedQualityOrderInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FailedQualityOrderBatchDispositionCode = group.Add(new VocabularyKey(nameof(FailedQualityOrderBatchDispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PassedQualityOrderBatchDispositionCode = group.Add(new VocabularyKey(nameof(PassedQualityOrderBatchDispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchAttributeValueDefaultedWithTestMeasurement = group.Add(new VocabularyKey(nameof(IsBatchAttributeValueDefaultedWithTestMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchDispositionStatusDefaultedWithTestMeasurement = group.Add(new VocabularyKey(nameof(IsBatchDispositionStatusDefaultedWithTestMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDestructiveTest = group.Add(new VocabularyKey(nameof(IsDestructiveTest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestGroupId = group.Add(new VocabularyKey(nameof(QualityTestGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryStatusDefaultedWithTestMeasurement = group.Add(new VocabularyKey(nameof(IsInventoryStatusDefaultedWithTestMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AcceptableQualityLevelPercentage { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FailedQualityOrderInventoryStatusId { get; private set; }
        public VocabularyKey ItemSamplingId { get; private set; }
        public VocabularyKey PassedQualityOrderInventoryStatusId { get; private set; }
        public VocabularyKey FailedQualityOrderBatchDispositionCode { get; private set; }
        public VocabularyKey PassedQualityOrderBatchDispositionCode { get; private set; }
        public VocabularyKey IsBatchAttributeValueDefaultedWithTestMeasurement { get; private set; }
        public VocabularyKey IsBatchDispositionStatusDefaultedWithTestMeasurement { get; private set; }
        public VocabularyKey IsDestructiveTest { get; private set; }
        public VocabularyKey QualityTestGroupId { get; private set; }
        public VocabularyKey IsInventoryStatusDefaultedWithTestMeasurement { get; private set; }
    }
}