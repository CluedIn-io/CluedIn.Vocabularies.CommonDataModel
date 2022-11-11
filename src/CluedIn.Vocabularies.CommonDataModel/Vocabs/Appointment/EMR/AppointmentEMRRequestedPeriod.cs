using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRRequestedPeriodVocabulary : SimpleVocabulary
    {
        public AppointmentEMRRequestedPeriodVocabulary()
        {
            VocabularyName = "Common Data Model AppointmentEMRRequestedPeriod";
            KeyPrefix = "commonDataModel.appointmentemrrequestedperiod";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRRequestedPeriod";

            AddGroup("Common Data Model AppointmentEMRRequestedPeriod Details", group =>
            {
                appointmentEMRRequestedPeriodId = group.Add(new VocabularyKey(nameof(appointmentEMRRequestedPeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                requestedPeriodEndDate = group.Add(new VocabularyKey(nameof(requestedPeriodEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                requestedPeriodStartDate = group.Add(new VocabularyKey(nameof(requestedPeriodStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey appointmentEMRRequestedPeriodId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey requestedPeriodEndDate { get; private set; }
        public VocabularyKey requestedPeriodStartDate { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}