using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRParticipantVocabulary : SimpleVocabulary
    {
        public AppointmentEMRParticipantVocabulary()
        {
            VocabularyName = "AppointmentEMRParticipant";
            KeyPrefix = "commonDataModel.appointmentemrparticipant";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRParticipant";

            AddGroup("AppointmentEMRParticipant Details", group =>
            {
                appointmentEMRParticipantId = group.Add(new VocabularyKey(nameof(appointmentEMRParticipantId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                participantActorType = group.Add(new VocabularyKey(nameof(participantActorType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                participationStatus = group.Add(new VocabularyKey(nameof(participationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                required = group.Add(new VocabularyKey(nameof(required), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey appointmentEMRParticipantId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey participantActorType { get; private set; }
        public VocabularyKey participationStatus { get; private set; }
        public VocabularyKey required { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}