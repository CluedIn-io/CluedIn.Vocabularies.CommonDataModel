using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CommunicationRequestReasonVocabulary : SimpleVocabulary
    {
        public CommunicationRequestReasonVocabulary()
        {
            VocabularyName = "Communication Request Reason";
            KeyPrefix = "commonDataModel.communicationrequestreason.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestReason";

            AddGroup("CommunicationRequestReason Details for ElectronicMedicalRecords", group =>
            {
			    CommunicationRequestReasonId = group.Add(new VocabularyKey(nameof(CommunicationRequestReasonId), "Communication Request Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CommunicationRequestReasonId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}