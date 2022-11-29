using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ObservationBasedOnVocabulary : SimpleVocabulary
    {
        public ObservationBasedOnVocabulary()
        {
            VocabularyName = "Observation Based On";
            KeyPrefix = "commonDataModel.observationbasedon.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ObservationBasedOn";

            AddGroup("ObservationBasedOn Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObsBasedOnType = group.Add(new VocabularyKey(nameof(ObsBasedOnType), "Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObservationBasedOnId = group.Add(new VocabularyKey(nameof(ObservationBasedOnId), "Observation Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObsBasedOnType { get; private set; }
        public VocabularyKey ObservationBasedOnId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}