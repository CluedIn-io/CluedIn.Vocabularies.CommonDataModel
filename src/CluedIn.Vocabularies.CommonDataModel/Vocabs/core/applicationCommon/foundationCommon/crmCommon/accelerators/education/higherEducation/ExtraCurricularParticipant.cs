using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class ExtraCurricularParticipantVocabulary : SimpleVocabulary
    {
        public ExtraCurricularParticipantVocabulary()
        {
            VocabularyName = "Extra Curricular Participant";
            KeyPrefix = "commonDataModel.extracurricularparticipant.highereducation";
            KeySeparator = ".";
            Grouping = "/ExtraCurricularParticipant";

            AddGroup("ExtraCurricularParticipant Details for HigherEducation", group =>
            {
			    ExtracurricularParticipantId = group.Add(new VocabularyKey(nameof(ExtracurricularParticipantId), "Extra Curricular Participant", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Student Extra Curricular Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AwardsReceived = group.Add(new VocabularyKey(nameof(AwardsReceived), "Awards Received", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PositionsHeld = group.Add(new VocabularyKey(nameof(PositionsHeld), "Positions Held", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Source = group.Add(new VocabularyKey(nameof(Source), "Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    State = group.Add(new VocabularyKey(nameof(State), "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExtracurricularParticipantId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AwardsReceived { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey PositionsHeld { get; private set; }
        public VocabularyKey Source { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey State { get; private set; }
    }
}