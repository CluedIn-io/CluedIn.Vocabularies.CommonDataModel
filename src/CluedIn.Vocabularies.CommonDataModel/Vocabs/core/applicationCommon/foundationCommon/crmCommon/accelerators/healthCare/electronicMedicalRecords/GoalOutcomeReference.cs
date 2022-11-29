using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class GoalOutcomeReferenceVocabulary : SimpleVocabulary
    {
        public GoalOutcomeReferenceVocabulary()
        {
            VocabularyName = "Goal Outcome Reference";
            KeyPrefix = "commonDataModel.goaloutcomereference.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/GoalOutcomeReference";

            AddGroup("GoalOutcomeReference Details for ElectronicMedicalRecords", group =>
            {
			    GoalOutcomeReferenceId = group.Add(new VocabularyKey(nameof(GoalOutcomeReferenceId), "Goal Outcome Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey GoalOutcomeReferenceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}