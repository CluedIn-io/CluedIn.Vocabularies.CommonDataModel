using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CommunicationVocabulary : SimpleVocabulary
    {
        public CommunicationVocabulary()
        {
            VocabularyName = "Communication";
            KeyPrefix = "commonDataModel.communication.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Communication";

            AddGroup("Communication Details for ElectronicMedicalRecords", group =>
            {
			    CommunicationId = group.Add(new VocabularyKey(nameof(CommunicationId), "Communication", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Display = group.Add(new VocabularyKey(nameof(Display), "Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PreferredCommunication = group.Add(new VocabularyKey(nameof(PreferredCommunication), "Preferred Communication", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CommunicationId { get; private set; }
        public VocabularyKey Display { get; private set; }
        public VocabularyKey PreferredCommunication { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}