using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RequestGroupActionCodeVocabulary : SimpleVocabulary
    {
        public RequestGroupActionCodeVocabulary()
        {
            VocabularyName = "Request Group Action Code";
            KeyPrefix = "commonDataModel.requestgroupactioncode.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RequestGroupActionCode";

            AddGroup("RequestGroupActionCode Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupActionCodeId = group.Add(new VocabularyKey(nameof(RequestGroupActionCodeId), "Request Group Action Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequestGroupActionCodeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}