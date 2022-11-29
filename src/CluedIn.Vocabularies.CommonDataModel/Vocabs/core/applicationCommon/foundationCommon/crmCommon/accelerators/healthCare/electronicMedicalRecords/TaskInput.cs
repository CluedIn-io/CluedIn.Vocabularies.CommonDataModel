using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class TaskInputVocabulary : SimpleVocabulary
    {
        public TaskInputVocabulary()
        {
            VocabularyName = "Task Input";
            KeyPrefix = "commonDataModel.taskinput.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/TaskInput";

            AddGroup("TaskInput Details for ElectronicMedicalRecords", group =>
            {
			    InputValue = group.Add(new VocabularyKey(nameof(InputValue), "Value (Input)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TaskInputId = group.Add(new VocabularyKey(nameof(TaskInputId), "Task Input", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey InputValue { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey TaskInputId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}