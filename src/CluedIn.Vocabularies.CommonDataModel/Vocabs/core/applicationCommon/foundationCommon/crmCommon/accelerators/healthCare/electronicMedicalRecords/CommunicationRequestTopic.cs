using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CommunicationRequestTopicVocabulary : SimpleVocabulary
    {
        public CommunicationRequestTopicVocabulary()
        {
            VocabularyName = "Communication Request Topic";
            KeyPrefix = "commonDataModel.communicationrequesttopic.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestTopic";

            AddGroup("CommunicationRequestTopic Details for ElectronicMedicalRecords", group =>
            {
			    CommunicationRequestTopicId = group.Add(new VocabularyKey(nameof(CommunicationRequestTopicId), "Communication Request Topic", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Topic = group.Add(new VocabularyKey(nameof(Topic), "Topic", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CommunicationRequestTopicId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Topic { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}