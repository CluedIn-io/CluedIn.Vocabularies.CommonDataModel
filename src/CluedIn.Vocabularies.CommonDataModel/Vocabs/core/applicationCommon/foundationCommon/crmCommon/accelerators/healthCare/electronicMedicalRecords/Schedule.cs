using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ScheduleVocabulary : SimpleVocabulary
    {
        public ScheduleVocabulary()
        {
            VocabularyName = "Schedule";
            KeyPrefix = "commonDataModel.schedule.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Schedule";

            AddGroup("Schedule Details for ElectronicMedicalRecords", group =>
            {
			    Active = group.Add(new VocabularyKey(nameof(Active), "Active", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Comment = group.Add(new VocabularyKey(nameof(Comment), "Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanningHorizonEndDateTime = group.Add(new VocabularyKey(nameof(PlanningHorizonEndDateTime), "End Date Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanningHorizonStartDateTime = group.Add(new VocabularyKey(nameof(PlanningHorizonStartDateTime), "Start Date Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduleId = group.Add(new VocabularyKey(nameof(ScheduleId), "Schedule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduleNumber = group.Add(new VocabularyKey(nameof(ScheduleNumber), "Schedule Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Active { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PlanningHorizonEndDateTime { get; private set; }
        public VocabularyKey PlanningHorizonStartDateTime { get; private set; }
        public VocabularyKey ScheduleId { get; private set; }
        public VocabularyKey ScheduleNumber { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}