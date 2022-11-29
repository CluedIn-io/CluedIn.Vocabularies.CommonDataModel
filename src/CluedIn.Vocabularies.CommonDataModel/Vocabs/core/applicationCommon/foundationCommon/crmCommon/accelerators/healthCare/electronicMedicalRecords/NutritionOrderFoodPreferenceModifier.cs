using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class NutritionOrderFoodPreferenceModifierVocabulary : SimpleVocabulary
    {
        public NutritionOrderFoodPreferenceModifierVocabulary()
        {
            VocabularyName = "Nutrition Order Food Preference Modifier";
            KeyPrefix = "commonDataModel.nutritionorderfoodpreferencemodifier.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/NutritionOrderFoodPreferenceModifier";

            AddGroup("NutritionOrderFoodPreferenceModifier Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NutritionOrderFoodPreferenceModifierId = group.Add(new VocabularyKey(nameof(NutritionOrderFoodPreferenceModifierId), "Nutrition Order Food Preference Modifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey NutritionOrderFoodPreferenceModifierId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}