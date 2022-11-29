using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class FamilyMemberHistoryConditionVocabulary : SimpleVocabulary
    {
        public FamilyMemberHistoryConditionVocabulary()
        {
            VocabularyName = "Family Member History Condition";
            KeyPrefix = "commonDataModel.familymemberhistorycondition.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/FamilyMemberHistoryCondition";

            AddGroup("FamilyMemberHistoryCondition Details for ElectronicMedicalRecords", group =>
            {
			    ConditionOnsetAge = group.Add(new VocabularyKey(nameof(ConditionOnsetAge), "Condition Onset Age", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ConditionOnsetPeriodEndDate = group.Add(new VocabularyKey(nameof(ConditionOnsetPeriodEndDate), "Condition Onset Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ConditionOnsetPeriodStartDate = group.Add(new VocabularyKey(nameof(ConditionOnsetPeriodStartDate), "Condition Onset Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ConditionOnsetRangeHigh = group.Add(new VocabularyKey(nameof(ConditionOnsetRangeHigh), "Condition Onset Range High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ConditionOnsetRangeLow = group.Add(new VocabularyKey(nameof(ConditionOnsetRangeLow), "Condition Onset Range Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ConditionOnsetString = group.Add(new VocabularyKey(nameof(ConditionOnsetString), "Condition Onset Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ConditionOnsetType = group.Add(new VocabularyKey(nameof(ConditionOnsetType), "Condition Onset Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FamilyMemberHistoryConditionId = group.Add(new VocabularyKey(nameof(FamilyMemberHistoryConditionId), "Family Member History Condition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ConditionOnsetAge { get; private set; }
        public VocabularyKey ConditionOnsetPeriodEndDate { get; private set; }
        public VocabularyKey ConditionOnsetPeriodStartDate { get; private set; }
        public VocabularyKey ConditionOnsetRangeHigh { get; private set; }
        public VocabularyKey ConditionOnsetRangeLow { get; private set; }
        public VocabularyKey ConditionOnsetString { get; private set; }
        public VocabularyKey ConditionOnsetType { get; private set; }
        public VocabularyKey FamilyMemberHistoryConditionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}