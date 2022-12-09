using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class GoalVocabulary : SimpleVocabulary
    {
        public GoalVocabulary()
        {
            VocabularyName = "Goal";
            KeyPrefix = "commonDataModel.goal";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Goal;

            AddGroup("Goal Details for ApplicationCommon", group =>
            {
			    GoalId = group.Add(new VocabularyKey(nameof(GoalId), "Goal", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FiscalPeriod = group.Add(new VocabularyKey(nameof(FiscalPeriod), "Fiscal Period", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FiscalYear = group.Add(new VocabularyKey(nameof(FiscalYear), "Fiscal Year", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalStartDate = group.Add(new VocabularyKey(nameof(GoalStartDate), "From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalEndDate = group.Add(new VocabularyKey(nameof(GoalEndDate), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    TreeId = group.Add(new VocabularyKey(nameof(TreeId), "Tree ID", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    Depth = group.Add(new VocabularyKey(nameof(Depth), "Depth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StretchTargetMoney = group.Add(new VocabularyKey(nameof(StretchTargetMoney), "Stretch Target (Money)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StretchTargetMoneyBase = group.Add(new VocabularyKey(nameof(StretchTargetMoneyBase), "Stretch Target (Money) (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StretchTargetDecimal = group.Add(new VocabularyKey(nameof(StretchTargetDecimal), "Stretch Target (Decimal)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    StretchTargetInteger = group.Add(new VocabularyKey(nameof(StretchTargetInteger), "Stretch Target (Integer)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TargetMoney = group.Add(new VocabularyKey(nameof(TargetMoney), "Target (Money)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TargetMoneyBase = group.Add(new VocabularyKey(nameof(TargetMoneyBase), "Target (Money) (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TargetDecimal = group.Add(new VocabularyKey(nameof(TargetDecimal), "Target (Decimal)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    TargetInteger = group.Add(new VocabularyKey(nameof(TargetInteger), "Target (Integer)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ActualMoney = group.Add(new VocabularyKey(nameof(ActualMoney), "Actual (Money)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActualMoneyBase = group.Add(new VocabularyKey(nameof(ActualMoneyBase), "Actual (Money) (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomRollupFieldMoney = group.Add(new VocabularyKey(nameof(CustomRollupFieldMoney), "Custom Rollup Field (Money)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CustomRollupFieldMoneyBase = group.Add(new VocabularyKey(nameof(CustomRollupFieldMoneyBase), "Custom Rollup Field (Money) (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InProgressMoney = group.Add(new VocabularyKey(nameof(InProgressMoney), "In-progress (Money)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InProgressMoneyBase = group.Add(new VocabularyKey(nameof(InProgressMoneyBase), "In-progress (Money) (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualDecimal = group.Add(new VocabularyKey(nameof(ActualDecimal), "Actual (Decimal)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CustomRollupFieldDecimal = group.Add(new VocabularyKey(nameof(CustomRollupFieldDecimal), "Custom Rollup Field (Decimal)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    InProgressDecimal = group.Add(new VocabularyKey(nameof(InProgressDecimal), "In-progress (Decimal)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActualInteger = group.Add(new VocabularyKey(nameof(ActualInteger), "Actual (Integer)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    CustomRollupFieldInteger = group.Add(new VocabularyKey(nameof(CustomRollupFieldInteger), "Custom Rollup Field (Integer)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    InProgressInteger = group.Add(new VocabularyKey(nameof(InProgressInteger), "In-progress (Integer)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Percentage = group.Add(new VocabularyKey(nameof(Percentage), "Percentage Achieved", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    IsFiscalPeriodGoal = group.Add(new VocabularyKey(nameof(IsFiscalPeriodGoal), "Goal Period Type", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ConsiderOnlyGoalOwnersRecords = group.Add(new VocabularyKey(nameof(ConsiderOnlyGoalOwnersRecords), "Record Set for Rollup", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastRolledupDate = group.Add(new VocabularyKey(nameof(LastRolledupDate), "Last Rolled Up Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TargetString = group.Add(new VocabularyKey(nameof(TargetString), "Target", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StretchTargetString = group.Add(new VocabularyKey(nameof(StretchTargetString), "Stretched Target", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualString = group.Add(new VocabularyKey(nameof(ActualString), "Actual", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomRollupFieldString = group.Add(new VocabularyKey(nameof(CustomRollupFieldString), "Custom Rollup Field", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InProgressString = group.Add(new VocabularyKey(nameof(InProgressString), "In-Progress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AmountDataType = group.Add(new VocabularyKey(nameof(AmountDataType), "Amount Data Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsAmount = group.Add(new VocabularyKey(nameof(IsAmount), "Metric Type", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RollupQueryActualIntegerId = group.Add(new VocabularyKey(nameof(RollupQueryActualIntegerId), "Rollup Query - Actual(Integer)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RollUpQueryActualMoneyId = group.Add(new VocabularyKey(nameof(RollUpQueryActualMoneyId), "Rollup Query - Actual(Money)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RollUpQueryActualDecimalId = group.Add(new VocabularyKey(nameof(RollUpQueryActualDecimalId), "Rollup Query - Actual(Decimal)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RollUpQueryCustomIntegerId = group.Add(new VocabularyKey(nameof(RollUpQueryCustomIntegerId), "Rollup Query - Custom Rollup Field (Integer)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RollUpQueryCustomMoneyId = group.Add(new VocabularyKey(nameof(RollUpQueryCustomMoneyId), "Rollup Query - Custom Rollup Field (Money)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RollUpQueryCustomDecimalId = group.Add(new VocabularyKey(nameof(RollUpQueryCustomDecimalId), "Rollup Query - Custom Rollup Field (Decimal)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RollUpQueryInprogressIntegerId = group.Add(new VocabularyKey(nameof(RollUpQueryInprogressIntegerId), "Rollup Query - In-progress(Integer)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RollUpQueryInprogressMoneyId = group.Add(new VocabularyKey(nameof(RollUpQueryInprogressMoneyId), "Rollup Query - In-progress(Money)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RollUpQueryInprogressDecimalId = group.Add(new VocabularyKey(nameof(RollUpQueryInprogressDecimalId), "Rollup Query - In-progress(Decimal)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RollupOnlyFromChildGoals = group.Add(new VocabularyKey(nameof(RollupOnlyFromChildGoals), "Roll Up Only from Child Goals", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RollupErrorCode = group.Add(new VocabularyKey(nameof(RollupErrorCode), "Rollup Error Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ComputedTargetAsOfTodayPercentageAchieved = group.Add(new VocabularyKey(nameof(ComputedTargetAsOfTodayPercentageAchieved), "Today's Target (Percentage Achieved)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ComputedTargetAsOfTodayMoney = group.Add(new VocabularyKey(nameof(ComputedTargetAsOfTodayMoney), "Today's Target (Money)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ComputedTargetAsOfTodayMoneyBase = group.Add(new VocabularyKey(nameof(ComputedTargetAsOfTodayMoneyBase), "Today's Target (Money) (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ComputedTargetAsOfTodayDecimal = group.Add(new VocabularyKey(nameof(ComputedTargetAsOfTodayDecimal), "Today's Target (Decimal)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ComputedTargetAsOfTodayInteger = group.Add(new VocabularyKey(nameof(ComputedTargetAsOfTodayInteger), "Today's Target (Integer)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IsOverride = group.Add(new VocabularyKey(nameof(IsOverride), "Override", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsOverridden = group.Add(new VocabularyKey(nameof(IsOverridden), "Overridden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), "Entity Image Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Goal Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalExpressedByType = group.Add(new VocabularyKey(nameof(GoalExpressedByType), "Goal Expressed By Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GoalNumber = group.Add(new VocabularyKey(nameof(GoalNumber), "Goal Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="GoalOwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="GoalOwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ParentGoalId"/> to Vocab 'Goal.cdm.json/Goal' with Property 'GoalId'
            ///Property <see cref="MetricId"/> to Vocab 'GoalMetric.cdm.json/GoalMetric' with Property 'MetricId'
            ///Property <see cref="GoalWithErrorId"/> to Vocab 'Goal.cdm.json/Goal' with Property 'GoalId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="MetricId"/> to Vocab 'GoalMetric.cdm.json/GoalMetric' with Property 'MetricId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="GoalOwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="GoalOwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="GoalId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="GoalId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="GoalId"/> from Vocab 'Goal.cdm.json/Goal' with Property 'ParentGoalId'
            ///Property <see cref="MetricId"/> from Vocab 'Goal.cdm.json/Goal' with Property 'MetricId'
            ///Property <see cref="GoalId"/> from Vocab 'Goal.cdm.json/Goal' with Property 'GoalWithErrorId'
            ///Property <see cref="GoalId"/> from Vocab 'Note.cdm.json/Note' with Property 'ObjectId'
            ///Property <see cref="GoalId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="GoalId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="MetricId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Goal.cdm.json/Goal' with Property 'MetricId'
            #endregion
        }

        public VocabularyKey ActualDecimal { get; private set; }
        public VocabularyKey ActualInteger { get; private set; }
        public VocabularyKey ActualMoney { get; private set; }
        public VocabularyKey ActualMoneyBase { get; private set; }
        public VocabularyKey ActualString { get; private set; }
        public VocabularyKey AmountDataType { get; private set; }
        public VocabularyKey ComputedTargetAsOfTodayDecimal { get; private set; }
        public VocabularyKey ComputedTargetAsOfTodayInteger { get; private set; }
        public VocabularyKey ComputedTargetAsOfTodayMoney { get; private set; }
        public VocabularyKey ComputedTargetAsOfTodayMoneyBase { get; private set; }
        public VocabularyKey ComputedTargetAsOfTodayPercentageAchieved { get; private set; }
        public VocabularyKey ConsiderOnlyGoalOwnersRecords { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey CustomRollupFieldDecimal { get; private set; }
        public VocabularyKey CustomRollupFieldInteger { get; private set; }
        public VocabularyKey CustomRollupFieldMoney { get; private set; }
        public VocabularyKey CustomRollupFieldMoneyBase { get; private set; }
        public VocabularyKey CustomRollupFieldString { get; private set; }
        public VocabularyKey Depth { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey FiscalPeriod { get; private set; }
        public VocabularyKey FiscalYear { get; private set; }
        public VocabularyKey GoalEndDate { get; private set; }
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
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey InProgressDecimal { get; private set; }
        public VocabularyKey InProgressInteger { get; private set; }
        public VocabularyKey InProgressMoney { get; private set; }
        public VocabularyKey InProgressMoneyBase { get; private set; }
        public VocabularyKey InProgressString { get; private set; }
        public VocabularyKey IsAmount { get; private set; }
        public VocabularyKey IsFiscalPeriodGoal { get; private set; }
        public VocabularyKey IsOverridden { get; private set; }
        public VocabularyKey IsOverride { get; private set; }
        public VocabularyKey LastRolledupDate { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey Percentage { get; private set; }
        public VocabularyKey RollupErrorCode { get; private set; }
        public VocabularyKey RollupOnlyFromChildGoals { get; private set; }
        public VocabularyKey RollUpQueryActualDecimalId { get; private set; }
        public VocabularyKey RollupQueryActualIntegerId { get; private set; }
        public VocabularyKey RollUpQueryActualMoneyId { get; private set; }
        public VocabularyKey RollUpQueryCustomDecimalId { get; private set; }
        public VocabularyKey RollUpQueryCustomIntegerId { get; private set; }
        public VocabularyKey RollUpQueryCustomMoneyId { get; private set; }
        public VocabularyKey RollUpQueryInprogressDecimalId { get; private set; }
        public VocabularyKey RollUpQueryInprogressIntegerId { get; private set; }
        public VocabularyKey RollUpQueryInprogressMoneyId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StretchTargetDecimal { get; private set; }
        public VocabularyKey StretchTargetInteger { get; private set; }
        public VocabularyKey StretchTargetMoney { get; private set; }
        public VocabularyKey StretchTargetMoneyBase { get; private set; }
        public VocabularyKey StretchTargetString { get; private set; }
        public VocabularyKey TargetDecimal { get; private set; }
        public VocabularyKey TargetInteger { get; private set; }
        public VocabularyKey TargetMoney { get; private set; }
        public VocabularyKey TargetMoneyBase { get; private set; }
        public VocabularyKey TargetString { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey TreeId { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}