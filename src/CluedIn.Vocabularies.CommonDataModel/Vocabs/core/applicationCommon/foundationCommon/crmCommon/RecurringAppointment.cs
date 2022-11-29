using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class RecurringAppointmentVocabulary : SimpleVocabulary
    {
        public RecurringAppointmentVocabulary()
        {
            VocabularyName = "Recurring Appointment";
            KeyPrefix = "commonDataModel.recurringappointment.crmcommon";
            KeySeparator = ".";
            Grouping = "/RecurringAppointment";

            AddGroup("RecurringAppointment Details for CrmCommon", group =>
            {
			    OptionalAttendees = group.Add(new VocabularyKey(nameof(OptionalAttendees), "Optional Attendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequiredAttendees = group.Add(new VocabularyKey(nameof(RequiredAttendees), "Required Attendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OptionalAttendees { get; private set; }
        public VocabularyKey RequiredAttendees { get; private set; }
    }
}