using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConfiguratorDefinitionGroupEntityVocabulary : SimpleVocabulary
    {
        public ConfiguratorDefinitionGroupEntityVocabulary()
        {
            VocabularyName = "Configurator Definition Group Entity";
            KeyPrefix = "commonDataModel.configuratordefinitiongroupentity";
            KeySeparator = ".";
            Grouping = "/ConfiguratorDefinitionGroupEntity";

            AddGroup("ConfiguratorDefinitionGroupEntity Details", group =>
            {
                DefinitionGroupId = group.Add(new VocabularyKey(nameof(DefinitionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQueryBased = group.Add(new VocabularyKey(nameof(IsQueryBased), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueryTitle = group.Add(new VocabularyKey(nameof(QueryTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DefinitionGroupId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey IsQueryBased { get; private set; }
        public VocabularyKey QueryTitle { get; private set; }
    }
}