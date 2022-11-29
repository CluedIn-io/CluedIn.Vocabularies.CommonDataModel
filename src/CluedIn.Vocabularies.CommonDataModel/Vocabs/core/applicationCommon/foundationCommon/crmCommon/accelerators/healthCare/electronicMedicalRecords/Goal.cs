using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class GoalVocabulary : SimpleVocabulary
    {
        public GoalVocabulary()
        {
            VocabularyName = "Goal";
            KeyPrefix = "commonDataModel.goal.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Goal";

            AddGroup("Goal Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalExpressedByType = group.Add(new VocabularyKey(nameof(GoalExpressedByType), "Goal Expressed By Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalId = group.Add(new VocabularyKey(nameof(GoalId), "Goal", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalNumber = group.Add(new VocabularyKey(nameof(GoalNumber), "Goal Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalStartDate = group.Add(new VocabularyKey(nameof(GoalStartDate), "Starting Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalStartType = group.Add(new VocabularyKey(nameof(GoalStartType), "Starting Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalStatus = group.Add(new VocabularyKey(nameof(GoalStatus), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalStatusDate = group.Add(new VocabularyKey(nameof(GoalStatusDate), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalStatusReason = group.Add(new VocabularyKey(nameof(GoalStatusReason), "Modify Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalSubjectType = group.Add(new VocabularyKey(nameof(GoalSubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalTargetDetailLowerValue = group.Add(new VocabularyKey(nameof(GoalTargetDetailLowerValue), "Lower Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    GoalTargetDetailQuantityComparator = group.Add(new VocabularyKey(nameof(GoalTargetDetailQuantityComparator), "Quantity Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalTargetDetailQuantitySystem = group.Add(new VocabularyKey(nameof(GoalTargetDetailQuantitySystem), "Quantity System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalTargetDetailQuantityUnit = group.Add(new VocabularyKey(nameof(GoalTargetDetailQuantityUnit), "Quantity Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalTargetDetailQuantityValue = group.Add(new VocabularyKey(nameof(GoalTargetDetailQuantityValue), "Quantity Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    GoalTargetDetailType = group.Add(new VocabularyKey(nameof(GoalTargetDetailType), "Detail Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalTargetDetailUpperValue = group.Add(new VocabularyKey(nameof(GoalTargetDetailUpperValue), "Upper Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    GoalTargetMeasureValueDueDate = group.Add(new VocabularyKey(nameof(GoalTargetMeasureValueDueDate), "Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalTargetMeasureValueDueDuration = group.Add(new VocabularyKey(nameof(GoalTargetMeasureValueDueDuration), "Due Duration", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    GoalTargetMeasureValueDueType = group.Add(new VocabularyKey(nameof(GoalTargetMeasureValueDueType), "Measure Due Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey GoalExpressedByType { get; private set; }
        public VocabularyKey GoalId { get; private set; }
        public VocabularyKey GoalNumber { get; private set; }
        public VocabularyKey GoalStartDate { get; private set; }
        public VocabularyKey GoalStartType { get; private set; }
        public VocabularyKey GoalStatus { get; private set; }
        public VocabularyKey GoalStatusDate { get; private set; }
        public VocabularyKey GoalStatusReason { get; private set; }
        public VocabularyKey GoalSubjectType { get; private set; }
        public VocabularyKey GoalTargetDetailLowerValue { get; private set; }
        public VocabularyKey GoalTargetDetailQuantityComparator { get; private set; }
        public VocabularyKey GoalTargetDetailQuantitySystem { get; private set; }
        public VocabularyKey GoalTargetDetailQuantityUnit { get; private set; }
        public VocabularyKey GoalTargetDetailQuantityValue { get; private set; }
        public VocabularyKey GoalTargetDetailType { get; private set; }
        public VocabularyKey GoalTargetDetailUpperValue { get; private set; }
        public VocabularyKey GoalTargetMeasureValueDueDate { get; private set; }
        public VocabularyKey GoalTargetMeasureValueDueDuration { get; private set; }
        public VocabularyKey GoalTargetMeasureValueDueType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}