using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConfiguratorDefinitionGroupTableEntityVocabulary : SimpleVocabulary
    {
        public ConfiguratorDefinitionGroupTableEntityVocabulary()
        {
            VocabularyName = "Configurator Definition Group Table Entity";
            KeyPrefix = "commonDataModel.configuratordefinitiongrouptableentity";
            KeySeparator = ".";
            Grouping = "/ConfiguratorDefinitionGroupTableEntity";

            AddGroup("ConfiguratorDefinitionGroupTableEntity Details", group =>
            {
                DefinitionGroupId = group.Add(new VocabularyKey(nameof(DefinitionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataSourceNumber = group.Add(new VocabularyKey(nameof(DataSourceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelatedTableName = group.Add(new VocabularyKey(nameof(RelatedTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SysRelation = group.Add(new VocabularyKey(nameof(SysRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DefinitionGroupId { get; private set; }
        public VocabularyKey DataSourceNumber { get; private set; }
        public VocabularyKey RelatedTableName { get; private set; }
        public VocabularyKey SysRelation { get; private set; }
        public VocabularyKey TableName { get; private set; }
    }
}