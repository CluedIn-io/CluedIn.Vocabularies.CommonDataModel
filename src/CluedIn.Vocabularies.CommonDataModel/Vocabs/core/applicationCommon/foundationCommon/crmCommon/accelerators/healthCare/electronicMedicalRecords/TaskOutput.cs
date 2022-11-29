using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class TaskOutputVocabulary : SimpleVocabulary
    {
        public TaskOutputVocabulary()
        {
            VocabularyName = "Task Output";
            KeyPrefix = "commonDataModel.taskoutput.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/TaskOutput";

            AddGroup("TaskOutput Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OutputValue = group.Add(new VocabularyKey(nameof(OutputValue), "Value (Output)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TaskOutId = group.Add(new VocabularyKey(nameof(TaskOutId), "Task Out", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey OutputValue { get; private set; }
        public VocabularyKey TaskOutId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}