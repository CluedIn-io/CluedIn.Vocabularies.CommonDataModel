using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgJobCardTerminalActionPaneConfigurationEntityVocabulary : SimpleVocabulary
    {
        public JmgJobCardTerminalActionPaneConfigurationEntityVocabulary()
        {
            VocabularyName = "Jmg Job Card Terminal Action Pane Configuration Entity";
            KeyPrefix = "commonDataModel.jmgjobcardterminalactionpaneconfigurationentity";
            KeySeparator = ".";
            Grouping = "/JmgJobCardTerminalActionPaneConfigurationEntity";

            AddGroup("JmgJobCardTerminalActionPaneConfigurationEntity Details", group =>
            {
                ActionPaneConfigurationId = group.Add(new VocabularyKey(nameof(ActionPaneConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionPaneConfigurationDescription = group.Add(new VocabularyKey(nameof(ActionPaneConfigurationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ActionPaneConfigurationId { get; private set; }
        public VocabularyKey ActionPaneConfigurationDescription { get; private set; }
    }
}