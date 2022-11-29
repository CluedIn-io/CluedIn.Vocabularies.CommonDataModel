using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CommunicationRequestRecipientVocabulary : SimpleVocabulary
    {
        public CommunicationRequestRecipientVocabulary()
        {
            VocabularyName = "Communication Request Recipient";
            KeyPrefix = "commonDataModel.communicationrequestrecipient.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestRecipient";

            AddGroup("CommunicationRequestRecipient Details for ElectronicMedicalRecords", group =>
            {
			    CommunicationRequestRecipientId = group.Add(new VocabularyKey(nameof(CommunicationRequestRecipientId), "Communication Request Recipient", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientType = group.Add(new VocabularyKey(nameof(RecipientType), "Recipient Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CommunicationRequestRecipientId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RecipientType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}