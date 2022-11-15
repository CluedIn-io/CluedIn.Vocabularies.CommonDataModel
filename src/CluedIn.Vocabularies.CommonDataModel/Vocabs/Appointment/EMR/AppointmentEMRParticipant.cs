using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRParticipantVocabulary : SimpleVocabulary
    {
        public AppointmentEMRParticipantVocabulary()
        {
            VocabularyName = "Appointment EMR Participant";
            KeyPrefix = "commonDataModel.appointmentemrparticipant";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRParticipant";

            AddGroup("AppointmentEMRParticipant Details", group =>
            {
                AppointmentEMRParticipantId = group.Add(new VocabularyKey(nameof(AppointmentEMRParticipantId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParticipantActorType = group.Add(new VocabularyKey(nameof(ParticipantActorType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParticipationStatus = group.Add(new VocabularyKey(nameof(ParticipationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Required = group.Add(new VocabularyKey(nameof(Required), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AppointmentEMRParticipantId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ParticipantActorType { get; private set; }
        public VocabularyKey ParticipationStatus { get; private set; }
        public VocabularyKey Required { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}