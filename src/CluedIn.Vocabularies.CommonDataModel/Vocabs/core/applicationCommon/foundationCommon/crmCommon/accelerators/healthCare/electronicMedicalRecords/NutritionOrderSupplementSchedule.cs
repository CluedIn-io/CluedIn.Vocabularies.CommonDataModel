using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class NutritionOrderSupplementScheduleVocabulary : SimpleVocabulary
    {
        public NutritionOrderSupplementScheduleVocabulary()
        {
            VocabularyName = "Nutrition Order Supplement Schedule";
            KeyPrefix = "commonDataModel.nutritionordersupplementschedule.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/NutritionOrderSupplementSchedule";

            AddGroup("NutritionOrderSupplementSchedule Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NutritionOrderSupplementScheduleId = group.Add(new VocabularyKey(nameof(NutritionOrderSupplementScheduleId), "Nutrition Order Supplement Schedule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey NutritionOrderSupplementScheduleId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}