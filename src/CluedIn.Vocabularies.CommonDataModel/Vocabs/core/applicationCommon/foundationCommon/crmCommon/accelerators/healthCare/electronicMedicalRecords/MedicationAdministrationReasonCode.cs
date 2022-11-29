using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationAdministrationReasonCodeVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationReasonCodeVocabulary()
        {
            VocabularyName = "Medication Administration Reason Code";
            KeyPrefix = "commonDataModel.medicationadministrationreasoncode.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationAdministrationReasonCode";

            AddGroup("MedicationAdministrationReasonCode Details for ElectronicMedicalRecords", group =>
            {
			    MedicationAdministrationReasonCodeId = group.Add(new VocabularyKey(nameof(MedicationAdministrationReasonCodeId), "Medication Administration Reason Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationAdministrationReasonCodeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}