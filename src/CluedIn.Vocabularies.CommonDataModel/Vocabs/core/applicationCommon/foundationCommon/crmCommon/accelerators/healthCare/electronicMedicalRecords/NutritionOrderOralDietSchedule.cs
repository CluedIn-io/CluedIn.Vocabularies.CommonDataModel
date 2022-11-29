using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class NutritionOrderOralDietScheduleVocabulary : SimpleVocabulary
    {
        public NutritionOrderOralDietScheduleVocabulary()
        {
            VocabularyName = "Nutrition Order Oral Diet Schedule";
            KeyPrefix = "commonDataModel.nutritionorderoraldietschedule.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/NutritionOrderOralDietSchedule";

            AddGroup("NutritionOrderOralDietSchedule Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NutritionOrderOralDietScheduleId = group.Add(new VocabularyKey(nameof(NutritionOrderOralDietScheduleId), "Nutrition Order Oral Diet Schedule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey NutritionOrderOralDietScheduleId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}