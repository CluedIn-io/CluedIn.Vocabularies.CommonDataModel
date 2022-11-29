using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ConditionStageVocabulary : SimpleVocabulary
    {
        public ConditionStageVocabulary()
        {
            VocabularyName = "Condition Stage";
            KeyPrefix = "commonDataModel.conditionstage.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ConditionStage";

            AddGroup("ConditionStage Details for ElectronicMedicalRecords", group =>
            {
			    ConditionStageId = group.Add(new VocabularyKey(nameof(ConditionStageId), "Condition Stage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ConditionStageId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}