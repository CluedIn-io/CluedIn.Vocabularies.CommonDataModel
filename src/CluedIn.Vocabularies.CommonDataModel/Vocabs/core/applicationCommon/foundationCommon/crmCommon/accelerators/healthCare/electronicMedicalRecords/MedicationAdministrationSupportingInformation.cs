using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationAdministrationSupportingInformationVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationSupportingInformationVocabulary()
        {
            VocabularyName = "Medication Administration Supporting Information";
            KeyPrefix = "commonDataModel.medicationadministrationsupportinginformation.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationAdministrationSupportingInformation";

            AddGroup("MedicationAdministrationSupportingInformation Details for ElectronicMedicalRecords", group =>
            {
			    MedicationadministrationsupportinginfoId = group.Add(new VocabularyKey(nameof(MedicationadministrationsupportinginfoId), "Medication Administration Supporting Information", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SupportingInformation = group.Add(new VocabularyKey(nameof(SupportingInformation), "Supporting Information", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationadministrationsupportinginfoId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SupportingInformation { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}