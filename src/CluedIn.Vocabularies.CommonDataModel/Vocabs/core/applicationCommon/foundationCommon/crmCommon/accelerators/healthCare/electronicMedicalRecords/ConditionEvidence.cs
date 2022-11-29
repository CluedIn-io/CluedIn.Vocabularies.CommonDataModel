using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ConditionEvidenceVocabulary : SimpleVocabulary
    {
        public ConditionEvidenceVocabulary()
        {
            VocabularyName = "Condition Evidence";
            KeyPrefix = "commonDataModel.conditionevidence.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ConditionEvidence";

            AddGroup("ConditionEvidence Details for ElectronicMedicalRecords", group =>
            {
			    ConditionEvidenceId = group.Add(new VocabularyKey(nameof(ConditionEvidenceId), "Condition Evidence", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Detail = group.Add(new VocabularyKey(nameof(Detail), "Evidence Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ConditionEvidenceId { get; private set; }
        public VocabularyKey Detail { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}