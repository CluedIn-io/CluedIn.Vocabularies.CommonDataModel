using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationCodeVocabulary : SimpleVocabulary
    {
        public MedicationCodeVocabulary()
        {
            VocabularyName = "Medication Code";
            KeyPrefix = "commonDataModel.medicationcode.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationCode";

            AddGroup("MedicationCode Details for ElectronicMedicalRecords", group =>
            {
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Display = group.Add(new VocabularyKey(nameof(Display), "Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicationCodeId = group.Add(new VocabularyKey(nameof(MedicationCodeId), "Medication Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    System = group.Add(new VocabularyKey(nameof(System), "System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey Display { get; private set; }
        public VocabularyKey MedicationCodeId { get; private set; }
        public VocabularyKey System { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}