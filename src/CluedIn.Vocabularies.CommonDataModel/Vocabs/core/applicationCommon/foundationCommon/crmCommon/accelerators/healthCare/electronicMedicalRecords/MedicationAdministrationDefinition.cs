using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationAdministrationDefinitionVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationDefinitionVocabulary()
        {
            VocabularyName = "Medication Administration Definition";
            KeyPrefix = "commonDataModel.medicationadministrationdefinition.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationAdministrationDefinition";

            AddGroup("MedicationAdministrationDefinition Details for ElectronicMedicalRecords", group =>
            {
			    DefinitionType = group.Add(new VocabularyKey(nameof(DefinitionType), "Definition Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicationAdministrationDefinitionId = group.Add(new VocabularyKey(nameof(MedicationAdministrationDefinitionId), "Medication Administration Definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DefinitionType { get; private set; }
        public VocabularyKey MedicationAdministrationDefinitionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}