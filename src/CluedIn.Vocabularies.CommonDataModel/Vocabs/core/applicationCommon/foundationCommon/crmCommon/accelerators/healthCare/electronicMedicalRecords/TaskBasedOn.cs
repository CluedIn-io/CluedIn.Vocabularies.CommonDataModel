using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class TaskBasedOnVocabulary : SimpleVocabulary
    {
        public TaskBasedOnVocabulary()
        {
            VocabularyName = "Task Based On";
            KeyPrefix = "commonDataModel.taskbasedon.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/TaskBasedOn";

            AddGroup("TaskBasedOn Details for ElectronicMedicalRecords", group =>
            {
			    BasedOn = group.Add(new VocabularyKey(nameof(BasedOn), "Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TaskBasedOnId = group.Add(new VocabularyKey(nameof(TaskBasedOnId), "Task Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BasedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey TaskBasedOnId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}