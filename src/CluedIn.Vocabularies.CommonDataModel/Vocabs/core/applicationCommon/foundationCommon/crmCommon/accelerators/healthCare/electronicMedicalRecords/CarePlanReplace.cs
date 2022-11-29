using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanReplaceVocabulary : SimpleVocabulary
    {
        public CarePlanReplaceVocabulary()
        {
            VocabularyName = "Care Plan Replace";
            KeyPrefix = "commonDataModel.careplanreplace.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanReplace";

            AddGroup("CarePlanReplace Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanReplaceId = group.Add(new VocabularyKey(nameof(CarePlanReplaceId), "Care Plan Replace", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanReplaceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}