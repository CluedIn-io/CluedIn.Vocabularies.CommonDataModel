using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterHospitalizationCourtesyVocabulary : SimpleVocabulary
    {
        public EncounterHospitalizationCourtesyVocabulary()
        {
            VocabularyName = "Encounter Hospitalization Courtesy";
            KeyPrefix = "commonDataModel.encounterhospitalizationcourtesy.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/EncounterHospitalizationCourtesy";

            AddGroup("EncounterHospitalizationCourtesy Details for ElectronicMedicalRecords", group =>
            {
			    EncounterHospitalizationCourtesyId = group.Add(new VocabularyKey(nameof(EncounterHospitalizationCourtesyId), "Encounter Hospitalization Courtesy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EncounterHospitalizationCourtesyId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}