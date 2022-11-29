using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CommunicationRequestMediumVocabulary : SimpleVocabulary
    {
        public CommunicationRequestMediumVocabulary()
        {
            VocabularyName = "Communication Request Medium";
            KeyPrefix = "commonDataModel.communicationrequestmedium.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestMedium";

            AddGroup("CommunicationRequestMedium Details for ElectronicMedicalRecords", group =>
            {
			    CommunicationRequestMediumId = group.Add(new VocabularyKey(nameof(CommunicationRequestMediumId), "Communication Request Medium", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CommunicationRequestMediumId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}