using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ObservationInterpretationVocabulary : SimpleVocabulary
    {
        public ObservationInterpretationVocabulary()
        {
            VocabularyName = "Observation Interpretation";
            KeyPrefix = "commonDataModel.observationinterpretation.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ObservationInterpretation";

            AddGroup("ObservationInterpretation Details for ElectronicMedicalRecords", group =>
            {
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Display = group.Add(new VocabularyKey(nameof(Display), "Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObservationInterpretationId = group.Add(new VocabularyKey(nameof(ObservationInterpretationId), "Observation Interpretation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    System = group.Add(new VocabularyKey(nameof(System), "System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey Display { get; private set; }
        public VocabularyKey ObservationInterpretationId { get; private set; }
        public VocabularyKey System { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}