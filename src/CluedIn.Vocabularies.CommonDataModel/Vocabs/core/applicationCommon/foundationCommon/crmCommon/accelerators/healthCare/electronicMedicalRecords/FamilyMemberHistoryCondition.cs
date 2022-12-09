using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class FamilyMemberHistoryConditionVocabulary : SimpleVocabulary
    {
        public FamilyMemberHistoryConditionVocabulary()
        {
            VocabularyName = "Family Member History Condition";
            KeyPrefix = "commonDataModel.familymemberhistorycondition";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.FamilyMemberHistoryCondition;

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
            
            #region Incoming Relationships
            ///Property <see cref="ConditionCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ConditionOutcomeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="FamilyMemberHistoryId"/> to Vocab 'FamilyMemberHistory.cdm.json/FamilyMemberHistory' with Property 'FamilyMemberHistoryId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
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