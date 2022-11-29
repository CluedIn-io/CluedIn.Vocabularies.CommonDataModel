using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class PractitionerRoleAvailableTimeVocabulary : SimpleVocabulary
    {
        public PractitionerRoleAvailableTimeVocabulary()
        {
            VocabularyName = "Practitioner Role Available Time";
            KeyPrefix = "commonDataModel.practitionerroleavailabletime.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/PractitionerRoleAvailableTime";

            AddGroup("PractitionerRoleAvailableTime Details for ElectronicMedicalRecords", group =>
            {
			    AllDay = group.Add(new VocabularyKey(nameof(AllDay), "All day", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AvailableEndTime = group.Add(new VocabularyKey(nameof(AvailableEndTime), "Available End Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AvailableStartTime = group.Add(new VocabularyKey(nameof(AvailableStartTime), "Available Start Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DaysOfWeek = group.Add(new VocabularyKey(nameof(DaysOfWeek), "Days of week", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PractitionerRoleAvailableTimeId = group.Add(new VocabularyKey(nameof(PractitionerRoleAvailableTimeId), "Practitioner Role Available Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AllDay { get; private set; }
        public VocabularyKey AvailableEndTime { get; private set; }
        public VocabularyKey AvailableStartTime { get; private set; }
        public VocabularyKey DaysOfWeek { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PractitionerRoleAvailableTimeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}