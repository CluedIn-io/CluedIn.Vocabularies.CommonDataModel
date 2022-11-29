using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanCategoryVocabulary : SimpleVocabulary
    {
        public CarePlanCategoryVocabulary()
        {
            VocabularyName = "Care Plan Category";
            KeyPrefix = "commonDataModel.careplancategory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanCategory";

            AddGroup("CarePlanCategory Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanCategoryId = group.Add(new VocabularyKey(nameof(CarePlanCategoryId), "Care Plan Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanCategoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}