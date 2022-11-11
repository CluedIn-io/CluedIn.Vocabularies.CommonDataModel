using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgJobCardTerminalActionPaneControlConfigurationEntityVocabulary : SimpleVocabulary
    {
        public JmgJobCardTerminalActionPaneControlConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgJobCardTerminalActionPaneControlConfigurationEntity";
            KeyPrefix = "commonDataModel.jmgjobcardterminalactionpanecontrolconfigurationentity";
            KeySeparator = ".";
            Grouping = "/JmgJobCardTerminalActionPaneControlConfigurationEntity";

            AddGroup("Common Data Model JmgJobCardTerminalActionPaneControlConfigurationEntity Details", group =>
            {
                JobCardTerminalActionPaneConfigurationRecId = group.Add(new VocabularyKey(nameof(JobCardTerminalActionPaneConfigurationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobCardTerminalActionPaneConfigurationId = group.Add(new VocabularyKey(nameof(JobCardTerminalActionPaneConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ButtonFunction = group.Add(new VocabularyKey(nameof(ButtonFunction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ControlType = group.Add(new VocabularyKey(nameof(ControlType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ControlLabel = group.Add(new VocabularyKey(nameof(ControlLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ControlSequenceNumber = group.Add(new VocabularyKey(nameof(ControlSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JobCardTerminalActionPaneConfigurationRecId { get; private set; }
        public VocabularyKey JobCardTerminalActionPaneConfigurationId { get; private set; }
        public VocabularyKey ButtonFunction { get; private set; }
        public VocabularyKey ControlType { get; private set; }
        public VocabularyKey ControlLabel { get; private set; }
        public VocabularyKey ControlSequenceNumber { get; private set; }


    }
}