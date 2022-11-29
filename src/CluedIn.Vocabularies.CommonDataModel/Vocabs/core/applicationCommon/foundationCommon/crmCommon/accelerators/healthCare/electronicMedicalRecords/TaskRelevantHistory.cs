using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class TaskRelevantHistoryVocabulary : SimpleVocabulary
    {
        public TaskRelevantHistoryVocabulary()
        {
            VocabularyName = "Task Relevant History";
            KeyPrefix = "commonDataModel.taskrelevanthistory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/TaskRelevantHistory";

            AddGroup("TaskRelevantHistory Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TaskRelevantHistoryId = group.Add(new VocabularyKey(nameof(TaskRelevantHistoryId), "Task Relevant History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey TaskRelevantHistoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}