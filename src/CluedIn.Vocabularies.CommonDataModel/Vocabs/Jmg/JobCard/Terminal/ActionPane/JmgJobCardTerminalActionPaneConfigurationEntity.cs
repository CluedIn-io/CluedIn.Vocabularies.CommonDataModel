using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgJobCardTerminalActionPaneConfigurationEntityVocabulary : SimpleVocabulary
    {
        public JmgJobCardTerminalActionPaneConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgJobCardTerminalActionPaneConfigurationEntity";
            KeyPrefix = "commonDataModel.jmgjobcardterminalactionpaneconfigurationentity";
            KeySeparator = ".";
            Grouping = "/JmgJobCardTerminalActionPaneConfigurationEntity";

            AddGroup("Common Data Model JmgJobCardTerminalActionPaneConfigurationEntity Details", group =>
            {
                ActionPaneConfigurationId = group.Add(new VocabularyKey(nameof(ActionPaneConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionPaneConfigurationDescription = group.Add(new VocabularyKey(nameof(ActionPaneConfigurationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActionPaneConfigurationId { get; private set; }
        public VocabularyKey ActionPaneConfigurationDescription { get; private set; }


    }
}