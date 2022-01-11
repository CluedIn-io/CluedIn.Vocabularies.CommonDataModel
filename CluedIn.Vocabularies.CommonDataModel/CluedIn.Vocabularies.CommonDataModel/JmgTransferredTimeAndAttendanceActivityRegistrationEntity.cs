using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgTransferredTimeAndAttendanceActivityRegistrationEntityVocabulary : SimpleVocabulary
    {
        public JmgTransferredTimeAndAttendanceActivityRegistrationEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgTransferredTimeAndAttendanceActivityRegistrationEntity";
            KeyPrefix = "commonDataModel.jmgtransferredtimeandattendanceactivityregistrationentity";
            KeySeparator = ".";
            Grouping = "/JmgTransferredTimeAndAttendanceActivityRegistrationEntity";

            AddGroup("Common Data Model JmgTransferredTimeAndAttendanceActivityRegistrationEntity Details", group =>
            {
                AbsencePayUnits = group.Add(new VocabularyKey(nameof(AbsencePayUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IndirectActivityName = group.Add(new VocabularyKey(nameof(IndirectActivityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BreakSeconds = group.Add(new VocabularyKey(nameof(BreakSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BreakToleranceSeconds = group.Add(new VocabularyKey(nameof(BreakToleranceSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CorrectedStartDate = group.Add(new VocabularyKey(nameof(CorrectedStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CorrectedStartTime = group.Add(new VocabularyKey(nameof(CorrectedStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CorrectedEndDate = group.Add(new VocabularyKey(nameof(CorrectedEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CorrectedEndTime = group.Add(new VocabularyKey(nameof(CorrectedEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostAbsenceTime = group.Add(new VocabularyKey(nameof(CostAbsenceTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostBreakTime = group.Add(new VocabularyKey(nameof(CostBreakTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostPriceFactor = group.Add(new VocabularyKey(nameof(CostPriceFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostFlexTimePlus = group.Add(new VocabularyKey(nameof(CostFlexTimePlus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostFlexTimeMinus = group.Add(new VocabularyKey(nameof(CostFlexTimeMinus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostNormTime = group.Add(new VocabularyKey(nameof(CostNormTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostOverTime = group.Add(new VocabularyKey(nameof(CostOverTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostAutomaticPremiums = group.Add(new VocabularyKey(nameof(CostAutomaticPremiums), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostManualPremiums = group.Add(new VocabularyKey(nameof(CostManualPremiums), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ErrorCause = group.Add(new VocabularyKey(nameof(ErrorCause), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ErrorSpecification = group.Add(new VocabularyKey(nameof(ErrorSpecification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostPriceHour = group.Add(new VocabularyKey(nameof(CostPriceHour), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsJobFinished = group.Add(new VocabularyKey(nameof(IsJobFinished), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TimeAndAttendanceJobId = group.Add(new VocabularyKey(nameof(TimeAndAttendanceJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AbsenceCodeTimeAndAttendanceJobId = group.Add(new VocabularyKey(nameof(AbsenceCodeTimeAndAttendanceJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobPayRateMethod = group.Add(new VocabularyKey(nameof(JobPayRateMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActivityType = group.Add(new VocabularyKey(nameof(ActivityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TimeAllocationType = group.Add(new VocabularyKey(nameof(TimeAllocationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalRegistrationType = group.Add(new VocabularyKey(nameof(JournalRegistrationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OnCallTimeAndAttendanceJobId = group.Add(new VocabularyKey(nameof(OnCallTimeAndAttendanceJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationNumber = group.Add(new VocabularyKey(nameof(OperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportedErrorCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReportedErrorCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportedGoodCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReportedGoodCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(StartedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TimeProfileDate = group.Add(new VocabularyKey(nameof(TimeProfileDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportedErrorQuantity = group.Add(new VocabularyKey(nameof(ReportedErrorQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportedGoodQuantity = group.Add(new VocabularyKey(nameof(ReportedGoodQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartedQuantity = group.Add(new VocabularyKey(nameof(StartedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RouteJobType = group.Add(new VocabularyKey(nameof(RouteJobType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CalculatedTimeSeconds = group.Add(new VocabularyKey(nameof(CalculatedTimeSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CalculatedTimeBeforeAllocationSeconds = group.Add(new VocabularyKey(nameof(CalculatedTimeBeforeAllocationSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CalculatedTimeAfterAllocationSeconds = group.Add(new VocabularyKey(nameof(CalculatedTimeAfterAllocationSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RegistrationType = group.Add(new VocabularyKey(nameof(RegistrationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RegistrationSubType = group.Add(new VocabularyKey(nameof(RegistrationSubType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndTime = group.Add(new VocabularyKey(nameof(EndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartRegistrationTerminalId = group.Add(new VocabularyKey(nameof(StartRegistrationTerminalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransferredActivityRegistrationTransactionId = group.Add(new VocabularyKey(nameof(TransferredActivityRegistrationTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StopRegistrationTerminalId = group.Add(new VocabularyKey(nameof(StopRegistrationTerminalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VoucherNumber = group.Add(new VocabularyKey(nameof(VoucherNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowStatus = group.Add(new VocabularyKey(nameof(WorkflowStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationsResourcePilotId = group.Add(new VocabularyKey(nameof(OperationsResourcePilotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PilotPersonnelNumber = group.Add(new VocabularyKey(nameof(PilotPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransferredActivityRegistrationEntryNumber = group.Add(new VocabularyKey(nameof(TransferredActivityRegistrationEntryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IndirectActivityCategoryId = group.Add(new VocabularyKey(nameof(IndirectActivityCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderNumber = group.Add(new VocabularyKey(nameof(ProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AbsencePayUnits { get; private set; }
public VocabularyKey IndirectActivityName { get; private set; }
public VocabularyKey BreakSeconds { get; private set; }
public VocabularyKey BreakToleranceSeconds { get; private set; }
public VocabularyKey CorrectedStartDate { get; private set; }
public VocabularyKey CorrectedStartTime { get; private set; }
public VocabularyKey CorrectedEndDate { get; private set; }
public VocabularyKey CorrectedEndTime { get; private set; }
public VocabularyKey CostAbsenceTime { get; private set; }
public VocabularyKey CostBreakTime { get; private set; }
public VocabularyKey CostPriceFactor { get; private set; }
public VocabularyKey CostFlexTimePlus { get; private set; }
public VocabularyKey CostFlexTimeMinus { get; private set; }
public VocabularyKey CostNormTime { get; private set; }
public VocabularyKey CostOverTime { get; private set; }
public VocabularyKey CostAutomaticPremiums { get; private set; }
public VocabularyKey CostManualPremiums { get; private set; }
public VocabularyKey DefaultDimension { get; private set; }
public VocabularyKey ErrorCause { get; private set; }
public VocabularyKey ErrorSpecification { get; private set; }
public VocabularyKey CostPriceHour { get; private set; }
public VocabularyKey IsJobFinished { get; private set; }
public VocabularyKey TimeAndAttendanceJobId { get; private set; }
public VocabularyKey AbsenceCodeTimeAndAttendanceJobId { get; private set; }
public VocabularyKey JobPayRateMethod { get; private set; }
public VocabularyKey ActivityType { get; private set; }
public VocabularyKey TimeAllocationType { get; private set; }
public VocabularyKey JournalRegistrationType { get; private set; }
public VocabularyKey OnCallTimeAndAttendanceJobId { get; private set; }
public VocabularyKey OperationNumber { get; private set; }
public VocabularyKey ReportedErrorCatchWeightQuantity { get; private set; }
public VocabularyKey ReportedGoodCatchWeightQuantity { get; private set; }
public VocabularyKey StartedCatchWeightQuantity { get; private set; }
public VocabularyKey TimeProfileDate { get; private set; }
public VocabularyKey ProjectCategoryId { get; private set; }
public VocabularyKey ReportedErrorQuantity { get; private set; }
public VocabularyKey ReportedGoodQuantity { get; private set; }
public VocabularyKey StartedQuantity { get; private set; }
public VocabularyKey RouteJobType { get; private set; }
public VocabularyKey CalculatedTimeSeconds { get; private set; }
public VocabularyKey CalculatedTimeBeforeAllocationSeconds { get; private set; }
public VocabularyKey CalculatedTimeAfterAllocationSeconds { get; private set; }
public VocabularyKey RegistrationType { get; private set; }
public VocabularyKey RegistrationSubType { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey StartTime { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey EndTime { get; private set; }
public VocabularyKey StartRegistrationTerminalId { get; private set; }
public VocabularyKey TransferredActivityRegistrationTransactionId { get; private set; }
public VocabularyKey StopRegistrationTerminalId { get; private set; }
public VocabularyKey VoucherNumber { get; private set; }
public VocabularyKey WorkflowStatus { get; private set; }
public VocabularyKey OperationsResourceId { get; private set; }
public VocabularyKey OperationsResourcePilotId { get; private set; }
public VocabularyKey WorkerPersonnelNumber { get; private set; }
public VocabularyKey PilotPersonnelNumber { get; private set; }
public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
public VocabularyKey TransferredActivityRegistrationEntryNumber { get; private set; }
public VocabularyKey IndirectActivityCategoryId { get; private set; }
public VocabularyKey ProductionOrderNumber { get; private set; }
public VocabularyKey ProjectId { get; private set; }


    }
}