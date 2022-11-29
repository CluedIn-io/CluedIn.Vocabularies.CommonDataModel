using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanBasedOnVocabulary : SimpleVocabulary
    {
        public CarePlanBasedOnVocabulary()
        {
            VocabularyName = "Care Plan Based On";
            KeyPrefix = "commonDataModel.careplanbasedon.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanBasedOn";

            AddGroup("CarePlanBasedOn Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanBasedOnId = group.Add(new VocabularyKey(nameof(CarePlanBasedOnId), "Care Plan Based On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanBasedOnId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}