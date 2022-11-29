using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ObservationComponentReferenceRangeVocabulary : SimpleVocabulary
    {
        public ObservationComponentReferenceRangeVocabulary()
        {
            VocabularyName = "Observation Component Reference Range";
            KeyPrefix = "commonDataModel.observationcomponentreferencerange.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ObservationComponentReferenceRange";

            AddGroup("ObservationComponentReferenceRange Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObservationcompreferencerangeId = group.Add(new VocabularyKey(nameof(ObservationcompreferencerangeId), "Observation Component Reference Range", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObservationcompreferencerangeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}