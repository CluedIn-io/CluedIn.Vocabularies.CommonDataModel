using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RequestGroupActionParticipantVocabulary : SimpleVocabulary
    {
        public RequestGroupActionParticipantVocabulary()
        {
            VocabularyName = "Request Group Action Participant";
            KeyPrefix = "commonDataModel.requestgroupactionparticipant.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RequestGroupActionParticipant";

            AddGroup("RequestGroupActionParticipant Details for ElectronicMedicalRecords", group =>
            {
			    ActionParticipantType = group.Add(new VocabularyKey(nameof(ActionParticipantType), "Participant Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupActionParticipantId = group.Add(new VocabularyKey(nameof(RequestGroupActionParticipantId), "Request Group Action Participant", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActionParticipantType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequestGroupActionParticipantId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}