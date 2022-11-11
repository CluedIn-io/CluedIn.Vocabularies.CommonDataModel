using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentVocabulary : SimpleVocabulary
    {
        public AppointmentVocabulary()
        {
            VocabularyName = "Common Data Model Appointment";
            KeyPrefix = "commonDataModel.appointment";
            KeySeparator = ".";
            Grouping = "/Appointment";

            AddGroup("Common Data Model Appointment Details", group =>
            {

            });
        }



    }
}