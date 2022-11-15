using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemGlobalConfigurationEntityVocabulary : SimpleVocabulary
    {
        public SystemGlobalConfigurationEntityVocabulary()
        {
            VocabularyName = "System Global Configuration Entity";
            KeyPrefix = "commonDataModel.systemglobalconfigurationentity";
            KeySeparator = ".";
            Grouping = "/SystemGlobalConfigurationEntity";

            AddGroup("SystemGlobalConfigurationEntity Details", group =>
            {
                AOSInstanceName = group.Add(new VocabularyKey(nameof(AOSInstanceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettingLevel = group.Add(new VocabularyKey(nameof(SettingLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AOSInstanceName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SettingLevel { get; private set; }
        public VocabularyKey Value { get; private set; }
    }
}