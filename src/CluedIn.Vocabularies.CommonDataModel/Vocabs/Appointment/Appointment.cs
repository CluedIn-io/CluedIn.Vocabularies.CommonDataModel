using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentVocabulary : SimpleVocabulary
    {
        public AppointmentVocabulary()
        {
            VocabularyName = "Appointment";
            KeyPrefix = "commonDataModel.appointment";
            KeySeparator = ".";
            Grouping = "/Appointment";

            AddGroup("Appointment Details", group =>
            {

            });
        }



    }
}