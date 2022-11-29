using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class NutritionOrderAllergyIntoleranceVocabulary : SimpleVocabulary
    {
        public NutritionOrderAllergyIntoleranceVocabulary()
        {
            VocabularyName = "Nutrition Order Allergy Intolerance";
            KeyPrefix = "commonDataModel.nutritionorderallergyintolerance.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/NutritionOrderAllergyIntolerance";

            AddGroup("NutritionOrderAllergyIntolerance Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NutritionOrderAllergyIntoleranceId = group.Add(new VocabularyKey(nameof(NutritionOrderAllergyIntoleranceId), "Nutrition Order Allergy Intolerance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey NutritionOrderAllergyIntoleranceId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}