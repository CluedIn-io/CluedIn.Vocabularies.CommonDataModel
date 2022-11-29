using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanPartOfVocabulary : SimpleVocabulary
    {
        public CarePlanPartOfVocabulary()
        {
            VocabularyName = "Care Plan Part Of";
            KeyPrefix = "commonDataModel.careplanpartof.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanPartOf";

            AddGroup("CarePlanPartOf Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanPartOfId = group.Add(new VocabularyKey(nameof(CarePlanPartOfId), "Care Plan Part Of", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanPartOfId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}