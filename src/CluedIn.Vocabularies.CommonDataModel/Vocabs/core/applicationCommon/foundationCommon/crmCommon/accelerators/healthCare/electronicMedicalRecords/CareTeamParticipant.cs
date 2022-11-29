using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CareTeamParticipantVocabulary : SimpleVocabulary
    {
        public CareTeamParticipantVocabulary()
        {
            VocabularyName = "Care Team Participant";
            KeyPrefix = "commonDataModel.careteamparticipant.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CareTeamParticipant";

            AddGroup("CareTeamParticipant Details for ElectronicMedicalRecords", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Entity Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CareTeamParticipantId = group.Add(new VocabularyKey(nameof(CareTeamParticipantId), "Care Team Participant", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MemberType = group.Add(new VocabularyKey(nameof(MemberType), "Member Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodEnd = group.Add(new VocabularyKey(nameof(PeriodEnd), "Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodStart = group.Add(new VocabularyKey(nameof(PeriodStart), "Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey CareTeamParticipantId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey MemberType { get; private set; }
        public VocabularyKey PeriodEnd { get; private set; }
        public VocabularyKey PeriodStart { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}