using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RequestGroupActionActionVocabulary : SimpleVocabulary
    {
        public RequestGroupActionActionVocabulary()
        {
            VocabularyName = "Request Group Action Action";
            KeyPrefix = "commonDataModel.requestgroupactionaction.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RequestGroupActionAction";

            AddGroup("RequestGroupActionAction Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupActionActionId = group.Add(new VocabularyKey(nameof(RequestGroupActionActionId), "Request Group Action Action", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequestGroupActionActionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}