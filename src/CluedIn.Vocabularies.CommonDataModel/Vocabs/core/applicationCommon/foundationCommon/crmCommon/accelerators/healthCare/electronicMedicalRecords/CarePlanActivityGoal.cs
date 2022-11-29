using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanActivityGoalVocabulary : SimpleVocabulary
    {
        public CarePlanActivityGoalVocabulary()
        {
            VocabularyName = "Care Plan Activity Goal";
            KeyPrefix = "commonDataModel.careplanactivitygoal.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanActivityGoal";

            AddGroup("CarePlanActivityGoal Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanActivityGoalId = group.Add(new VocabularyKey(nameof(CarePlanActivityGoalId), "Care Plan Activity Goal", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanActivityGoalId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}