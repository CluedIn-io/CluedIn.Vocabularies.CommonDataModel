using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class AppointmentVocabulary : SimpleVocabulary
    {
        public AppointmentVocabulary()
        {
            VocabularyName = "Appointment";
            KeyPrefix = "commonDataModel.appointment.marketing";
            KeySeparator = ".";
            Grouping = "/Appointment";

            AddGroup("Appointment Details for Marketing", group =>
            {
			    CustomerJourneyIteration = group.Add(new VocabularyKey(nameof(CustomerJourneyIteration), "Customer journey iteration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CustomerJourneyIteration { get; private set; }
    }
}