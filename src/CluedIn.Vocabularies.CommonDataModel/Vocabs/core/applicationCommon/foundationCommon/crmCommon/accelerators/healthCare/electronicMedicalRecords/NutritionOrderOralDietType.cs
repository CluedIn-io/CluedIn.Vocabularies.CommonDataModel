using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class NutritionOrderOralDietTypeVocabulary : SimpleVocabulary
    {
        public NutritionOrderOralDietTypeVocabulary()
        {
            VocabularyName = "Nutrition Order Oral Diet Type";
            KeyPrefix = "commonDataModel.nutritionorderoraldiettype.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/NutritionOrderOralDietType";

            AddGroup("NutritionOrderOralDietType Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NutritionOrderOralDietTypeId = group.Add(new VocabularyKey(nameof(NutritionOrderOralDietTypeId), "Nutrition Order Oral Diet Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey NutritionOrderOralDietTypeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}