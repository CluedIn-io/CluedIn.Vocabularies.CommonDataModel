using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkTemplateWorkBreakEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkTemplateWorkBreakEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWorkTemplateWorkBreakEntity";
            KeyPrefix = "commonDataModel.whswarehouseworktemplateworkbreakentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkTemplateWorkBreakEntity";

            AddGroup("Common Data Model WHSWarehouseWorkTemplateWorkBreakEntity Details", group =>
            {
                WorkTemplateWorkBreakTableFieldId = group.Add(new VocabularyKey(nameof(WorkTemplateWorkBreakTableFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkTemplateWorkBreakTableFieldName = group.Add(new VocabularyKey(nameof(WorkTemplateWorkBreakTableFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkTemplateWorkBreakTableId = group.Add(new VocabularyKey(nameof(WorkTemplateWorkBreakTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkTemplateWorkBreakTableName = group.Add(new VocabularyKey(nameof(WorkTemplateWorkBreakTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkBreakLineNumber = group.Add(new VocabularyKey(nameof(WorkBreakLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkTemplateRecordId = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFieldBreakingWork = group.Add(new VocabularyKey(nameof(IsFieldBreakingWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkTemplateId = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkTemplateWorkOrderType = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WorkTemplateWorkBreakTableFieldId { get; private set; }
        public VocabularyKey WorkTemplateWorkBreakTableFieldName { get; private set; }
        public VocabularyKey WorkTemplateWorkBreakTableId { get; private set; }
        public VocabularyKey WorkTemplateWorkBreakTableName { get; private set; }
        public VocabularyKey WorkBreakLineNumber { get; private set; }
        public VocabularyKey WarehouseWorkTemplateRecordId { get; private set; }
        public VocabularyKey IsFieldBreakingWork { get; private set; }
        public VocabularyKey WarehouseWorkTemplateId { get; private set; }
        public VocabularyKey WarehouseWorkTemplateWorkOrderType { get; private set; }


    }
}