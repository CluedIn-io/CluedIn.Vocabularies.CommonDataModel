using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanGoalVocabulary : SimpleVocabulary
    {
        public CarePlanGoalVocabulary()
        {
            VocabularyName = "Care Plan Goal";
            KeyPrefix = "commonDataModel.careplangoal.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanGoal";

            AddGroup("CarePlanGoal Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanGoalId = group.Add(new VocabularyKey(nameof(CarePlanGoalId), "Care Plan Goal", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanGoalId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}