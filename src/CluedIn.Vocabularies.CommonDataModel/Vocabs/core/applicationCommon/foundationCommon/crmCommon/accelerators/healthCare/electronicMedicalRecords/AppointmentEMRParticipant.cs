using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AppointmentEMRParticipantVocabulary : SimpleVocabulary
    {
        public AppointmentEMRParticipantVocabulary()
        {
            VocabularyName = "Appointment EMR Participant";
            KeyPrefix = "commonDataModel.appointmentemrparticipant.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRParticipant";

            AddGroup("AppointmentEMRParticipant Details for ElectronicMedicalRecords", group =>
            {
			    AppointmentEMRParticipantId = group.Add(new VocabularyKey(nameof(AppointmentEMRParticipantId), "Appointment (EMR) Participant", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipantActorType = group.Add(new VocabularyKey(nameof(ParticipantActorType), "Participant Actor Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipationStatus = group.Add(new VocabularyKey(nameof(ParticipationStatus), "Participation Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Required = group.Add(new VocabularyKey(nameof(Required), "Required", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
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