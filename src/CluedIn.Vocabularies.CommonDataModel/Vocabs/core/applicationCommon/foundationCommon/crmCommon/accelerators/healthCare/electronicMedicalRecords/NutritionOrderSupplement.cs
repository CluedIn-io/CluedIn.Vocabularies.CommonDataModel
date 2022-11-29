using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class NutritionOrderSupplementVocabulary : SimpleVocabulary
    {
        public NutritionOrderSupplementVocabulary()
        {
            VocabularyName = "Nutrition Order Supplement";
            KeyPrefix = "commonDataModel.nutritionordersupplement.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/NutritionOrderSupplement";

            AddGroup("NutritionOrderSupplement Details for ElectronicMedicalRecords", group =>
            {
			    Instruction = group.Add(new VocabularyKey(nameof(Instruction), "Instruction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NutritionOrderSupplementId = group.Add(new VocabularyKey(nameof(NutritionOrderSupplementId), "Nutrition Order Supplement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductName = group.Add(new VocabularyKey(nameof(ProductName), "Product Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Instruction { get; private set; }
        public VocabularyKey NutritionOrderSupplementId { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}