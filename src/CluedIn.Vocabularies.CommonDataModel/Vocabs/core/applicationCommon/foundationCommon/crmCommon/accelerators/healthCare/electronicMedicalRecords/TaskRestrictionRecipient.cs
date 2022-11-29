using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class TaskRestrictionRecipientVocabulary : SimpleVocabulary
    {
        public TaskRestrictionRecipientVocabulary()
        {
            VocabularyName = "Task Restriction Recipient";
            KeyPrefix = "commonDataModel.taskrestrictionrecipient.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/TaskRestrictionRecipient";

            AddGroup("TaskRestrictionRecipient Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RestrictionRecipientType = group.Add(new VocabularyKey(nameof(RestrictionRecipientType), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TaskRestrictionRecipientId = group.Add(new VocabularyKey(nameof(TaskRestrictionRecipientId), "Task Restriction Recipient", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey RestrictionRecipientType { get; private set; }
        public VocabularyKey TaskRestrictionRecipientId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}