using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWaveTemplateGroupEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWaveTemplateGroupEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Wave Template Group Entity";
            KeyPrefix = "commonDataModel.whswarehousewavetemplategroupentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWaveTemplateGroupEntity";

            AddGroup("WHSWarehouseWaveTemplateGroupEntity Details", group =>
            {
                WaveTemplate = group.Add(new VocabularyKey(nameof(WaveTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableId = group.Add(new VocabularyKey(nameof(GroupTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupFieldId = group.Add(new VocabularyKey(nameof(GroupFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupBy = group.Add(new VocabularyKey(nameof(GroupBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWaveTemplateName = group.Add(new VocabularyKey(nameof(WarehouseWaveTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableName = group.Add(new VocabularyKey(nameof(GroupTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableFieldName = group.Add(new VocabularyKey(nameof(GroupTableFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WaveTemplate { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey GroupTableId { get; private set; }
        public VocabularyKey GroupFieldId { get; private set; }
        public VocabularyKey GroupBy { get; private set; }
        public VocabularyKey WarehouseWaveTemplateName { get; private set; }
        public VocabularyKey GroupTableName { get; private set; }
        public VocabularyKey GroupTableFieldName { get; private set; }
    }
}