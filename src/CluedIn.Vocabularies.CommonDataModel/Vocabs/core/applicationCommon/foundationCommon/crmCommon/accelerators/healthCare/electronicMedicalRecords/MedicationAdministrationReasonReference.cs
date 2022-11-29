using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationAdministrationReasonReferenceVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationReasonReferenceVocabulary()
        {
            VocabularyName = "Medication Administration Reason Reference";
            KeyPrefix = "commonDataModel.medicationadministrationreasonreference.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationAdministrationReasonReference";

            AddGroup("MedicationAdministrationReasonReference Details for ElectronicMedicalRecords", group =>
            {
			    MedicationAdministrationReasonReferenceId = group.Add(new VocabularyKey(nameof(MedicationAdministrationReasonReferenceId), "Medication Administration Reason Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReasonReferenceType = group.Add(new VocabularyKey(nameof(ReasonReferenceType), "Reason Reference Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationAdministrationReasonReferenceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReasonReferenceType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}