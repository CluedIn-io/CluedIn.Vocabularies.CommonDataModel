using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationIngredientVocabulary : SimpleVocabulary
    {
        public MedicationIngredientVocabulary()
        {
            VocabularyName = "Medication Ingredient";
            KeyPrefix = "commonDataModel.medicationingredient.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationIngredient";

            AddGroup("MedicationIngredient Details for ElectronicMedicalRecords", group =>
            {
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsActive = group.Add(new VocabularyKey(nameof(IsActive), "Is Active", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MedicationIngredientId = group.Add(new VocabularyKey(nameof(MedicationIngredientId), "Medication Ingredient", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Amount { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey MedicationIngredientId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}