using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationAdministrationReasonNotGivenVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationReasonNotGivenVocabulary()
        {
            VocabularyName = "Medication Administration Reason Not Given";
            KeyPrefix = "commonDataModel.medicationadministrationreasonnotgiven.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationAdministrationReasonNotGiven";

            AddGroup("MedicationAdministrationReasonNotGiven Details for ElectronicMedicalRecords", group =>
            {
			    MedicationAdministrationReasonNotGivenId = group.Add(new VocabularyKey(nameof(MedicationAdministrationReasonNotGivenId), "Medication Administration Reason Not Given", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationAdministrationReasonNotGivenId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}