using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConfiguratorDefinitionGroupSortOrderEntityVocabulary : SimpleVocabulary
    {
        public ConfiguratorDefinitionGroupSortOrderEntityVocabulary()
        {
            VocabularyName = "ConfiguratorDefinitionGroupSortOrderEntity";
            KeyPrefix = "commonDataModel.configuratordefinitiongroupsortorderentity";
            KeySeparator = ".";
            Grouping = "/ConfiguratorDefinitionGroupSortOrderEntity";

            AddGroup("ConfiguratorDefinitionGroupSortOrderEntity Details", group =>
            {
                DefinitionGroupId = group.Add(new VocabularyKey(nameof(DefinitionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortingNumber = group.Add(new VocabularyKey(nameof(SortingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortOrder = group.Add(new VocabularyKey(nameof(SortOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DefinitionGroupId { get; private set; }
        public VocabularyKey FieldName { get; private set; }
        public VocabularyKey SortingNumber { get; private set; }
        public VocabularyKey SortOrder { get; private set; }
        public VocabularyKey TableName { get; private set; }


    }
}