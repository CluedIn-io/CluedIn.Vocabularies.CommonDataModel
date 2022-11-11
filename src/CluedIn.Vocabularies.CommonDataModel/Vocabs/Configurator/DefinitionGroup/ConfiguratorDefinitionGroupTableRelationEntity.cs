using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConfiguratorDefinitionGroupTableRelationEntityVocabulary : SimpleVocabulary
    {
        public ConfiguratorDefinitionGroupTableRelationEntityVocabulary()
        {
            VocabularyName = "Common Data Model ConfiguratorDefinitionGroupTableRelationEntity";
            KeyPrefix = "commonDataModel.configuratordefinitiongrouptablerelationentity";
            KeySeparator = ".";
            Grouping = "/ConfiguratorDefinitionGroupTableRelationEntity";

            AddGroup("Common Data Model ConfiguratorDefinitionGroupTableRelationEntity Details", group =>
            {
                DefinitionGroupId = group.Add(new VocabularyKey(nameof(DefinitionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedValue = group.Add(new VocabularyKey(nameof(FixedValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelatedField = group.Add(new VocabularyKey(nameof(RelatedField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelatedTable = group.Add(new VocabularyKey(nameof(RelatedTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelationshipType = group.Add(new VocabularyKey(nameof(RelationshipType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceFieldName = group.Add(new VocabularyKey(nameof(SourceFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceTableName = group.Add(new VocabularyKey(nameof(SourceTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DefinitionGroupId { get; private set; }
        public VocabularyKey FixedValue { get; private set; }
        public VocabularyKey RelatedField { get; private set; }
        public VocabularyKey RelatedTable { get; private set; }
        public VocabularyKey RelationshipType { get; private set; }
        public VocabularyKey SourceFieldName { get; private set; }
        public VocabularyKey SourceTableName { get; private set; }


    }
}