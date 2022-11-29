using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationAdministrationPartOfVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationPartOfVocabulary()
        {
            VocabularyName = "Medication Administration Part Of";
            KeyPrefix = "commonDataModel.medicationadministrationpartof.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationAdministrationPartOf";

            AddGroup("MedicationAdministrationPartOf Details for ElectronicMedicalRecords", group =>
            {
			    MedicationAdministrationPartOfId = group.Add(new VocabularyKey(nameof(MedicationAdministrationPartOfId), "Medication Administration Part Of", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartOfType = group.Add(new VocabularyKey(nameof(PartOfType), "Part Of Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationAdministrationPartOfId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PartOfType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}