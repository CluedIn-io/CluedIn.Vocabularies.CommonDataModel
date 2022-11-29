using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationVocabulary : SimpleVocabulary
    {
        public MedicationVocabulary()
        {
            VocabularyName = "Medication";
            KeyPrefix = "commonDataModel.medication.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Medication";

            AddGroup("Medication Details for ElectronicMedicalRecords", group =>
            {
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsBrand = group.Add(new VocabularyKey(nameof(IsBrand), "Is Brand", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsOverTheCounter = group.Add(new VocabularyKey(nameof(IsOverTheCounter), "Is Over the Counter", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MedicationId = group.Add(new VocabularyKey(nameof(MedicationId), "Medication", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Amount { get; private set; }
        public VocabularyKey IsBrand { get; private set; }
        public VocabularyKey IsOverTheCounter { get; private set; }
        public VocabularyKey MedicationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}