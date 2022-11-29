using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CommunicationRequestPayloadVocabulary : SimpleVocabulary
    {
        public CommunicationRequestPayloadVocabulary()
        {
            VocabularyName = "Communication Request Payload";
            KeyPrefix = "commonDataModel.communicationrequestpayload.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestPayload";

            AddGroup("CommunicationRequestPayload Details for ElectronicMedicalRecords", group =>
            {
			    CommunicationRequestPayloadId = group.Add(new VocabularyKey(nameof(CommunicationRequestPayloadId), "Communication Request Payload", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PayloadContentReference = group.Add(new VocabularyKey(nameof(PayloadContentReference), "Payload Content Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PayloadContentString = group.Add(new VocabularyKey(nameof(PayloadContentString), "Payload Content String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CommunicationRequestPayloadId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PayloadContentReference { get; private set; }
        public VocabularyKey PayloadContentString { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}