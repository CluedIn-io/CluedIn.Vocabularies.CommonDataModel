using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterHospitalizationArrangementVocabulary : SimpleVocabulary
    {
        public EncounterHospitalizationArrangementVocabulary()
        {
            VocabularyName = "Encounter Hospitalization Arrangement";
            KeyPrefix = "commonDataModel.encounterhospitalizationarrangement.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EncounterHospitalizationArrangement";

            AddGroup("EncounterHospitalizationArrangement Details for ElectronicMedicalRecords", group =>
            {
			    EncounterHospitalizationArrangementId = group.Add(new VocabularyKey(nameof(EncounterHospitalizationArrangementId), "Encounter Hospitalization Arrangement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EncounterHospitalizationArrangementId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}