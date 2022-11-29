using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CommunicationRequestBasedOnVocabulary : SimpleVocabulary
    {
        public CommunicationRequestBasedOnVocabulary()
        {
            VocabularyName = "Communication Request Based On";
            KeyPrefix = "commonDataModel.communicationrequestbasedon.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestBasedOn";

            AddGroup("CommunicationRequestBasedOn Details for ElectronicMedicalRecords", group =>
            {
			    BasedOn = group.Add(new VocabularyKey(nameof(BasedOn), "Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommunicationRequestBasedOnId = group.Add(new VocabularyKey(nameof(CommunicationRequestBasedOnId), "Communication Request Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BasedOn { get; private set; }
        public VocabularyKey CommunicationRequestBasedOnId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}