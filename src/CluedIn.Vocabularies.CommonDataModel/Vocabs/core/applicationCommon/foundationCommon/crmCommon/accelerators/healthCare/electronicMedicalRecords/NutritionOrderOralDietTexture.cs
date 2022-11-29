using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class NutritionOrderOralDietTextureVocabulary : SimpleVocabulary
    {
        public NutritionOrderOralDietTextureVocabulary()
        {
            VocabularyName = "Nutrition Order Oral Diet Texture";
            KeyPrefix = "commonDataModel.nutritionorderoraldiettexture.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/NutritionOrderOralDietTexture";

            AddGroup("NutritionOrderOralDietTexture Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NutritionOrderOralDietTextureId = group.Add(new VocabularyKey(nameof(NutritionOrderOralDietTextureId), "Nutrition Order Oral Diet Texture", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey NutritionOrderOralDietTextureId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}