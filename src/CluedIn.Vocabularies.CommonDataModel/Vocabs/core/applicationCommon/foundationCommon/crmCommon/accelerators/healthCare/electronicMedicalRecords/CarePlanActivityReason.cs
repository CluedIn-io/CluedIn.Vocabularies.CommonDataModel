using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanActivityReasonVocabulary : SimpleVocabulary
    {
        public CarePlanActivityReasonVocabulary()
        {
            VocabularyName = "Care Plan Activity Reason";
            KeyPrefix = "commonDataModel.careplanactivityreason.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanActivityReason";

            AddGroup("CarePlanActivityReason Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanActivityReasonId = group.Add(new VocabularyKey(nameof(CarePlanActivityReasonId), "Care Plan Activity Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanActivityReasonId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}