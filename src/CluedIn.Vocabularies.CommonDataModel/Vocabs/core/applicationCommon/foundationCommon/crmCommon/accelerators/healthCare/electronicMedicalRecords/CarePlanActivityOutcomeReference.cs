using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanActivityOutcomeReferenceVocabulary : SimpleVocabulary
    {
        public CarePlanActivityOutcomeReferenceVocabulary()
        {
            VocabularyName = "Care Plan Activity Outcome Reference";
            KeyPrefix = "commonDataModel.careplanactivityoutcomereference.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanActivityOutcomeReference";

            AddGroup("CarePlanActivityOutcomeReference Details for ElectronicMedicalRecords", group =>
            {
			    ActivityOutcomeRefIdentifier = group.Add(new VocabularyKey(nameof(ActivityOutcomeRefIdentifier), "Activity Outcome Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CarePlanActivityOutReferenceId = group.Add(new VocabularyKey(nameof(CarePlanActivityOutReferenceId), "Care Plan Activity Out Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActivityOutcomeRefIdentifier { get; private set; }
        public VocabularyKey CarePlanActivityOutReferenceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}