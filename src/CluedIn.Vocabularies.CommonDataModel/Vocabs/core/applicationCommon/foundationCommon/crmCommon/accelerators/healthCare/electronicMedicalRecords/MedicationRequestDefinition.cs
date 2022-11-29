using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationRequestDefinitionVocabulary : SimpleVocabulary
    {
        public MedicationRequestDefinitionVocabulary()
        {
            VocabularyName = "Medication Request Definition";
            KeyPrefix = "commonDataModel.medicationrequestdefinition.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationRequestDefinition";

            AddGroup("MedicationRequestDefinition Details for ElectronicMedicalRecords", group =>
            {
			    MedicationRequestDefinitionId = group.Add(new VocabularyKey(nameof(MedicationRequestDefinitionId), "Medication Request Definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicationRequestDefinitionType = group.Add(new VocabularyKey(nameof(MedicationRequestDefinitionType), "Definition Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationRequestDefinitionId { get; private set; }
        public VocabularyKey MedicationRequestDefinitionType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}