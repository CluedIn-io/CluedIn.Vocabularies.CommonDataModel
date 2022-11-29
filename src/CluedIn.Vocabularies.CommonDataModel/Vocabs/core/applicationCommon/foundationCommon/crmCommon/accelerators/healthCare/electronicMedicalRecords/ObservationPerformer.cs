using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ObservationPerformerVocabulary : SimpleVocabulary
    {
        public ObservationPerformerVocabulary()
        {
            VocabularyName = "Observation Performer";
            KeyPrefix = "commonDataModel.observationperformer.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ObservationPerformer";

            AddGroup("ObservationPerformer Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObservationPerformerId = group.Add(new VocabularyKey(nameof(ObservationPerformerId), "Observation Performer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObsPerformerType = group.Add(new VocabularyKey(nameof(ObsPerformerType), "Performer Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObservationPerformerId { get; private set; }
        public VocabularyKey ObsPerformerType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}