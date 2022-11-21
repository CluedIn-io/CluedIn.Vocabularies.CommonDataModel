using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRRequestedPeriodVocabulary : SimpleVocabulary
    {
        public AppointmentEMRRequestedPeriodVocabulary()
        {
            VocabularyName = "Appointment EMR Requested Period";
            KeyPrefix = "commonDataModel.appointmentemrrequestedperiod";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRRequestedPeriod";

            AddGroup("AppointmentEMRRequestedPeriod Details", group =>
            {
                AppointmentEMRRequestedPeriodId = group.Add(new VocabularyKey(nameof(AppointmentEMRRequestedPeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedPeriodEndDate = group.Add(new VocabularyKey(nameof(RequestedPeriodEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedPeriodStartDate = group.Add(new VocabularyKey(nameof(RequestedPeriodStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AppointmentEMRRequestedPeriodId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequestedPeriodEndDate { get; private set; }
        public VocabularyKey RequestedPeriodStartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}