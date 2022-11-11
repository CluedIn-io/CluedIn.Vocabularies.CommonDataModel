using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DataManagementExecutionJobEntityVocabulary : SimpleVocabulary
    {
        public DataManagementExecutionJobEntityVocabulary()
        {
            VocabularyName = "DataManagementExecutionJobEntity";
            KeyPrefix = "commonDataModel.datamanagementexecutionjobentity";
            KeySeparator = ".";
            Grouping = "/DataManagementExecutionJobEntity";

            AddGroup("DataManagementExecutionJobEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey JobId { get; private set; }


    }
}