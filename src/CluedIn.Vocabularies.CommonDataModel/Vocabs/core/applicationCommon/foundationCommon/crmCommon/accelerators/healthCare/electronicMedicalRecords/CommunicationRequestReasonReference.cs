using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CommunicationRequestReasonReferenceVocabulary : SimpleVocabulary
    {
        public CommunicationRequestReasonReferenceVocabulary()
        {
            VocabularyName = "Communication Request Reason Reference";
            KeyPrefix = "commonDataModel.communicationrequestreasonreference.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestReasonReference";

            AddGroup("CommunicationRequestReasonReference Details for ElectronicMedicalRecords", group =>
            {
			    CommunicationrequestreasnrefId = group.Add(new VocabularyKey(nameof(CommunicationrequestreasnrefId), "Communication Request Reason Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReasonReferenceType = group.Add(new VocabularyKey(nameof(ReasonReferenceType), "Reason Reference Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CommunicationrequestreasnrefId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReasonReferenceType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}