using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgJobCardDeviceConfigurationUserAssignmentEntityVocabulary : SimpleVocabulary
    {
        public JmgJobCardDeviceConfigurationUserAssignmentEntityVocabulary()
        {
            VocabularyName = "JmgJobCardDeviceConfigurationUserAssignmentEntity";
            KeyPrefix = "commonDataModel.jmgjobcarddeviceconfigurationuserassignmententity";
            KeySeparator = ".";
            Grouping = "/JmgJobCardDeviceConfigurationUserAssignmentEntity";

            AddGroup("JmgJobCardDeviceConfigurationUserAssignmentEntity Details", group =>
            {
                JobCardDeviceConfigurationRecId = group.Add(new VocabularyKey(nameof(JobCardDeviceConfigurationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobCardDeviceConfigurationId = group.Add(new VocabularyKey(nameof(JobCardDeviceConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemUserRecId = group.Add(new VocabularyKey(nameof(SystemUserRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemUserId = group.Add(new VocabularyKey(nameof(SystemUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JobCardDeviceConfigurationRecId { get; private set; }
        public VocabularyKey JobCardDeviceConfigurationId { get; private set; }
        public VocabularyKey SystemUserRecId { get; private set; }
        public VocabularyKey SystemUserId { get; private set; }


    }
}