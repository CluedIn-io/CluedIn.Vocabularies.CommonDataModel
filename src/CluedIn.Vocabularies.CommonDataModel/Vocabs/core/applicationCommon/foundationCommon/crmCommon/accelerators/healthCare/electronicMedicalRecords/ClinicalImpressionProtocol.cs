using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ClinicalImpressionProtocolVocabulary : SimpleVocabulary
    {
        public ClinicalImpressionProtocolVocabulary()
        {
            VocabularyName = "Clinical Impression Protocol";
            KeyPrefix = "commonDataModel.clinicalimpressionprotocol.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ClinicalImpressionProtocol";

            AddGroup("ClinicalImpressionProtocol Details for ElectronicMedicalRecords", group =>
            {
			    ClinicalImpressionProtocolId = group.Add(new VocabularyKey(nameof(ClinicalImpressionProtocolId), "Clinical Impression Protocol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    URI = group.Add(new VocabularyKey(nameof(URI), "Protocol URI", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ClinicalImpressionProtocolId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey URI { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}