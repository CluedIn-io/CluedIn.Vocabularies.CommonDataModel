using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConfiguratorDefinitionGroupSummationEntityVocabulary : SimpleVocabulary
    {
        public ConfiguratorDefinitionGroupSummationEntityVocabulary()
        {
            VocabularyName = "Configurator Definition Group Summation Entity";
            KeyPrefix = "commonDataModel.configuratordefinitiongroupsummationentity";
            KeySeparator = ".";
            Grouping = "/ConfiguratorDefinitionGroupSummationEntity";

            AddGroup("ConfiguratorDefinitionGroupSummationEntity Details", group =>
            {
                Average = group.Add(new VocabularyKey(nameof(Average), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AverageSelected = group.Add(new VocabularyKey(nameof(AverageSelected), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefinitionGroupId = group.Add(new VocabularyKey(nameof(DefinitionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountAll = group.Add(new VocabularyKey(nameof(CountAll), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountSelected = group.Add(new VocabularyKey(nameof(CountSelected), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SumAll = group.Add(new VocabularyKey(nameof(SumAll), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SumSelected = group.Add(new VocabularyKey(nameof(SumSelected), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Average { get; private set; }
        public VocabularyKey AverageSelected { get; private set; }
        public VocabularyKey DefinitionGroupId { get; private set; }
        public VocabularyKey CountAll { get; private set; }
        public VocabularyKey CountSelected { get; private set; }
        public VocabularyKey FieldName { get; private set; }
        public VocabularyKey SumAll { get; private set; }
        public VocabularyKey SumSelected { get; private set; }
        public VocabularyKey TableName { get; private set; }
    }
}