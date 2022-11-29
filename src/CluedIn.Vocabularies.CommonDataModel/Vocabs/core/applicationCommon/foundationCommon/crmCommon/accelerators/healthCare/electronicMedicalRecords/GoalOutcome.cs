using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class GoalOutcomeVocabulary : SimpleVocabulary
    {
        public GoalOutcomeVocabulary()
        {
            VocabularyName = "Goal Outcome";
            KeyPrefix = "commonDataModel.goaloutcome.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/GoalOutcome";

            AddGroup("GoalOutcome Details for ElectronicMedicalRecords", group =>
            {
			    GoalOutcomeId = group.Add(new VocabularyKey(nameof(GoalOutcomeId), "Goal Outcome", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey GoalOutcomeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}