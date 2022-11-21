using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceLevelAgreementEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceLevelAgreementEntityVocabulary()
        {
            VocabularyName = "SMA Service Level Agreement Entity";
            KeyPrefix = "commonDataModel.smaservicelevelagreemententity";
            KeySeparator = ".";
            Grouping = "/SMAServiceLevelAgreementEntity";

            AddGroup("SMAServiceLevelAgreementEntity Details", group =>
            {
                AgreementWorkCalendarId = group.Add(new VocabularyKey(nameof(AgreementWorkCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceRequestResponseDays = group.Add(new VocabularyKey(nameof(ServiceRequestResponseDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementDescription = group.Add(new VocabularyKey(nameof(AgreementDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceRequestResponseHours = group.Add(new VocabularyKey(nameof(ServiceRequestResponseHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceRequestResponseMinutes = group.Add(new VocabularyKey(nameof(ServiceRequestResponseMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementId = group.Add(new VocabularyKey(nameof(AgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAgreementSuspended = group.Add(new VocabularyKey(nameof(IsAgreementSuspended), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AgreementWorkCalendarId { get; private set; }
        public VocabularyKey ServiceRequestResponseDays { get; private set; }
        public VocabularyKey AgreementDescription { get; private set; }
        public VocabularyKey ServiceRequestResponseHours { get; private set; }
        public VocabularyKey ServiceRequestResponseMinutes { get; private set; }
        public VocabularyKey AgreementId { get; private set; }
        public VocabularyKey IsAgreementSuspended { get; private set; }
    }
}