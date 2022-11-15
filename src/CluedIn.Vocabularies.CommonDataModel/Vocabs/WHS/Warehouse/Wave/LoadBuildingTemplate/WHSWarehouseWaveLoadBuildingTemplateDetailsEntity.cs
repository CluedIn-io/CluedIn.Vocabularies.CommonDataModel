using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWaveLoadBuildingTemplateDetailsEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWaveLoadBuildingTemplateDetailsEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Wave Load Building Template Details Entity";
            KeyPrefix = "commonDataModel.whswarehousewaveloadbuildingtemplatedetailsentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWaveLoadBuildingTemplateDetailsEntity";

            AddGroup("WHSWarehouseWaveLoadBuildingTemplateDetailsEntity Details", group =>
            {
                WarehouseWaveLoadBuildingTemplateName = group.Add(new VocabularyKey(nameof(WarehouseWaveLoadBuildingTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BreakBy = group.Add(new VocabularyKey(nameof(BreakBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupFieldId = group.Add(new VocabularyKey(nameof(GroupFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableId = group.Add(new VocabularyKey(nameof(GroupTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupFieldName = group.Add(new VocabularyKey(nameof(GroupFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableName = group.Add(new VocabularyKey(nameof(GroupTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WarehouseWaveLoadBuildingTemplateName { get; private set; }
        public VocabularyKey BreakBy { get; private set; }
        public VocabularyKey GroupFieldId { get; private set; }
        public VocabularyKey GroupTableId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey GroupFieldName { get; private set; }
        public VocabularyKey GroupTableName { get; private set; }
    }
}