using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ScheduleServiceTypeVocabulary : SimpleVocabulary
    {
        public ScheduleServiceTypeVocabulary()
        {
            VocabularyName = "Schedule Service Type";
            KeyPrefix = "commonDataModel.scheduleservicetype.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ScheduleServiceType";

            AddGroup("ScheduleServiceType Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduleServiceTypeId = group.Add(new VocabularyKey(nameof(ScheduleServiceTypeId), "Schedule Service Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ScheduleServiceTypeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}