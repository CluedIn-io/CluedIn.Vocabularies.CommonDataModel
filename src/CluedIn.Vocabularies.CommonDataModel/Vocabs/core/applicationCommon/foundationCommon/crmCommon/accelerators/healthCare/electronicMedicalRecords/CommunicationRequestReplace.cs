using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CommunicationRequestReplaceVocabulary : SimpleVocabulary
    {
        public CommunicationRequestReplaceVocabulary()
        {
            VocabularyName = "Communication Request Replace";
            KeyPrefix = "commonDataModel.communicationrequestreplace.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestReplace";

            AddGroup("CommunicationRequestReplace Details for ElectronicMedicalRecords", group =>
            {
			    CommunicationRequestReplaceId = group.Add(new VocabularyKey(nameof(CommunicationRequestReplaceId), "Communication Request Replace", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CommunicationRequestReplaceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}