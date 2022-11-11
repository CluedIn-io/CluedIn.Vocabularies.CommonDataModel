using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConfiguratorDefinitionGroupFieldRangeEntityVocabulary : SimpleVocabulary
    {
        public ConfiguratorDefinitionGroupFieldRangeEntityVocabulary()
        {
            VocabularyName = "Common Data Model ConfiguratorDefinitionGroupFieldRangeEntity";
            KeyPrefix = "commonDataModel.configuratordefinitiongroupfieldrangeentity";
            KeySeparator = ".";
            Grouping = "/ConfiguratorDefinitionGroupFieldRangeEntity";

            AddGroup("Common Data Model ConfiguratorDefinitionGroupFieldRangeEntity Details", group =>
            {
                DefinitionGroupId = group.Add(new VocabularyKey(nameof(DefinitionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Range = group.Add(new VocabularyKey(nameof(Range), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DefinitionGroupId { get; private set; }
        public VocabularyKey FieldName { get; private set; }
        public VocabularyKey Range { get; private set; }
        public VocabularyKey TableName { get; private set; }


    }
}