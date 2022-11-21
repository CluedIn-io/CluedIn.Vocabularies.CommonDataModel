using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgJobCardTerminalGridConfigurationEntityVocabulary : SimpleVocabulary
    {
        public JmgJobCardTerminalGridConfigurationEntityVocabulary()
        {
            VocabularyName = "Jmg Job Card Terminal Grid Configuration Entity";
            KeyPrefix = "commonDataModel.jmgjobcardterminalgridconfigurationentity";
            KeySeparator = ".";
            Grouping = "/JmgJobCardTerminalGridConfigurationEntity";

            AddGroup("JmgJobCardTerminalGridConfigurationEntity Details", group =>
            {
                GridConfigurationDescription = group.Add(new VocabularyKey(nameof(GridConfigurationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GridConfigurationId = group.Add(new VocabularyKey(nameof(GridConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GridConfigurationDescription { get; private set; }
        public VocabularyKey GridConfigurationId { get; private set; }
    }
}