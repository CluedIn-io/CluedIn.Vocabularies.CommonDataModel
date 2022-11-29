using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class NutritionOrderVocabulary : SimpleVocabulary
    {
        public NutritionOrderVocabulary()
        {
            VocabularyName = "Nutrition Order";
            KeyPrefix = "commonDataModel.nutritionorder.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/NutritionOrder";

            AddGroup("NutritionOrder Details for ElectronicMedicalRecords", group =>
            {
			    AdditiveProductName = group.Add(new VocabularyKey(nameof(AdditiveProductName), "Additive Product Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdministrationInstruction = group.Add(new VocabularyKey(nameof(AdministrationInstruction), "Administration Instruction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BaseFormulaProductName = group.Add(new VocabularyKey(nameof(BaseFormulaProductName), "Base Formula Product Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CaloricDensity = group.Add(new VocabularyKey(nameof(CaloricDensity), "Caloric Density", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DateTime = group.Add(new VocabularyKey(nameof(DateTime), "DateTime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MaxVolumeToDeliver = group.Add(new VocabularyKey(nameof(MaxVolumeToDeliver), "Max Volume to Deliver", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NutritionOrderId = group.Add(new VocabularyKey(nameof(NutritionOrderId), "Nutrition Order", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NutritionOrderNumber = group.Add(new VocabularyKey(nameof(NutritionOrderNumber), "Nutrition Order Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OralDietInstruction = group.Add(new VocabularyKey(nameof(OralDietInstruction), "Instruction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AdditiveProductName { get; private set; }
        public VocabularyKey AdministrationInstruction { get; private set; }
        public VocabularyKey BaseFormulaProductName { get; private set; }
        public VocabularyKey CaloricDensity { get; private set; }
        public VocabularyKey DateTime { get; private set; }
        public VocabularyKey MaxVolumeToDeliver { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NutritionOrderId { get; private set; }
        public VocabularyKey NutritionOrderNumber { get; private set; }
        public VocabularyKey OralDietInstruction { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}