using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RequestGroupReplaceVocabulary : SimpleVocabulary
    {
        public RequestGroupReplaceVocabulary()
        {
            VocabularyName = "Request Group Replace";
            KeyPrefix = "commonDataModel.requestgroupreplace.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RequestGroupReplace";

            AddGroup("RequestGroupReplace Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Replaces = group.Add(new VocabularyKey(nameof(Replaces), "Replaces", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupReplaceId = group.Add(new VocabularyKey(nameof(RequestGroupReplaceId), "Request Group Replace", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Replaces { get; private set; }
        public VocabularyKey RequestGroupReplaceId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}