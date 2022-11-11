using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgJobCardTerminalConfigurationUserAssignmentEntityVocabulary : SimpleVocabulary
    {
        public JmgJobCardTerminalConfigurationUserAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgJobCardTerminalConfigurationUserAssignmentEntity";
            KeyPrefix = "commonDataModel.jmgjobcardterminalconfigurationuserassignmententity";
            KeySeparator = ".";
            Grouping = "/JmgJobCardTerminalConfigurationUserAssignmentEntity";

            AddGroup("Common Data Model JmgJobCardTerminalConfigurationUserAssignmentEntity Details", group =>
            {
                JobCardTerminalConfigurationRecId = group.Add(new VocabularyKey(nameof(JobCardTerminalConfigurationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobCardTerminalConfigurationId = group.Add(new VocabularyKey(nameof(JobCardTerminalConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemUserRecId = group.Add(new VocabularyKey(nameof(SystemUserRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemUserId = group.Add(new VocabularyKey(nameof(SystemUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JobCardTerminalConfigurationRecId { get; private set; }
        public VocabularyKey JobCardTerminalConfigurationId { get; private set; }
        public VocabularyKey SystemUserRecId { get; private set; }
        public VocabularyKey SystemUserId { get; private set; }


    }
}