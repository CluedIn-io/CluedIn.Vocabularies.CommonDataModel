using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DataManagementTargetMapEntityVocabulary : SimpleVocabulary
    {
        public DataManagementTargetMapEntityVocabulary()
        {
            VocabularyName = "Data Management Target Map Entity";
            KeyPrefix = "commonDataModel.datamanagementtargetmapentity";
            KeySeparator = ".";
            Grouping = "/DataManagementTargetMapEntity";

            AddGroup("DataManagementTargetMapEntity Details", group =>
            {
                Entity = group.Add(new VocabularyKey(nameof(Entity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAutoManual = group.Add(new VocabularyKey(nameof(IsAutoManual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetDataSourceName = group.Add(new VocabularyKey(nameof(TargetDataSourceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetField = group.Add(new VocabularyKey(nameof(TargetField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetTable = group.Add(new VocabularyKey(nameof(TargetTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StagingField = group.Add(new VocabularyKey(nameof(StagingField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArrayIndex = group.Add(new VocabularyKey(nameof(ArrayIndex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShortStagingField = group.Add(new VocabularyKey(nameof(ShortStagingField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRequired = group.Add(new VocabularyKey(nameof(IsRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSystem = group.Add(new VocabularyKey(nameof(IsSystem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldDataTypeValue = group.Add(new VocabularyKey(nameof(FieldDataTypeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecVersionValue = group.Add(new VocabularyKey(nameof(RecVersionValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataSourceName = group.Add(new VocabularyKey(nameof(DataSourceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataSourceField = group.Add(new VocabularyKey(nameof(DataSourceField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldLength = group.Add(new VocabularyKey(nameof(FieldLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityLabel = group.Add(new VocabularyKey(nameof(EntityLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldAOTName = group.Add(new VocabularyKey(nameof(FieldAOTName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Entity { get; private set; }
        public VocabularyKey IsAutoManual { get; private set; }
        public VocabularyKey TargetDataSourceName { get; private set; }
        public VocabularyKey TargetField { get; private set; }
        public VocabularyKey TargetTable { get; private set; }
        public VocabularyKey StagingField { get; private set; }
        public VocabularyKey ArrayIndex { get; private set; }
        public VocabularyKey ShortStagingField { get; private set; }
        public VocabularyKey IsRequired { get; private set; }
        public VocabularyKey IsSystem { get; private set; }
        public VocabularyKey FieldDataTypeValue { get; private set; }
        public VocabularyKey RecVersionValue { get; private set; }
        public VocabularyKey DataSourceName { get; private set; }
        public VocabularyKey DataSourceField { get; private set; }
        public VocabularyKey FieldLength { get; private set; }
        public VocabularyKey EntityLabel { get; private set; }
        public VocabularyKey FieldAOTName { get; private set; }
    }
}