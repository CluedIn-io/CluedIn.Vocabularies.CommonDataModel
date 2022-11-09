using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPositionV2EntityVocabulary : SimpleVocabulary
    {
        public HcmPositionV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmPositionV2Entity";
            KeyPrefix = "commonDataModel.hcmpositionv2entity";
            KeySeparator = ".";
            Grouping = "/HcmPositionV2Entity";

            AddGroup("Common Data Model HcmPositionV2Entity Details", group =>
            {
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AvailableForAssignment = group.Add(new VocabularyKey(nameof(AvailableForAssignment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompensationRegion = group.Add(new VocabularyKey(nameof(CompensationRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Department = group.Add(new VocabularyKey(nameof(Department), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FullTimeEquivalent = group.Add(new VocabularyKey(nameof(FullTimeEquivalent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PositionType = group.Add(new VocabularyKey(nameof(PositionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DetailEffective = group.Add(new VocabularyKey(nameof(DetailEffective), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DetailExpiration = group.Add(new VocabularyKey(nameof(DetailExpiration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DepartmentNumber = group.Add(new VocabularyKey(nameof(DepartmentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompensationRegionId = group.Add(new VocabularyKey(nameof(CompensationRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PositionTypeId = group.Add(new VocabularyKey(nameof(PositionTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TitleId = group.Add(new VocabularyKey(nameof(TitleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Activation = group.Add(new VocabularyKey(nameof(Activation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Retirement = group.Add(new VocabularyKey(nameof(Retirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerAssignmentReasonCode = group.Add(new VocabularyKey(nameof(WorkerAssignmentReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerAssignmentStart = group.Add(new VocabularyKey(nameof(WorkerAssignmentStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerAssignmentEnd = group.Add(new VocabularyKey(nameof(WorkerAssignmentEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerAssignmentReasonCodeId = group.Add(new VocabularyKey(nameof(WorkerAssignmentReasonCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerName = group.Add(new VocabularyKey(nameof(WorkerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaidByLegalEntity = group.Add(new VocabularyKey(nameof(PaidByLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayCycle = group.Add(new VocabularyKey(nameof(PayCycle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayCycleId = group.Add(new VocabularyKey(nameof(PayCycleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AnnualRegularHours = group.Add(new VocabularyKey(nameof(AnnualRegularHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayrollDetailEffective = group.Add(new VocabularyKey(nameof(PayrollDetailEffective), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayrollDetailExpiration = group.Add(new VocabularyKey(nameof(PayrollDetailExpiration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSalaryGenerated = group.Add(new VocabularyKey(nameof(IsSalaryGenerated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultEarningCodeId = group.Add(new VocabularyKey(nameof(DefaultEarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InsuranceBenefit = group.Add(new VocabularyKey(nameof(InsuranceBenefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreEarningsGeneratedFromSchedule = group.Add(new VocabularyKey(nameof(AreEarningsGeneratedFromSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaidBy = group.Add(new VocabularyKey(nameof(PaidBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayPeriodOvertimeHours = group.Add(new VocabularyKey(nameof(PayPeriodOvertimeHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Schedule = group.Add(new VocabularyKey(nameof(Schedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduleLegalEntity = group.Add(new VocabularyKey(nameof(ScheduleLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BenefitId = group.Add(new VocabularyKey(nameof(BenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PositionId { get; private set; }
public VocabularyKey AvailableForAssignment { get; private set; }
public VocabularyKey CompensationRegion { get; private set; }
public VocabularyKey Department { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey FullTimeEquivalent { get; private set; }
public VocabularyKey Job { get; private set; }
public VocabularyKey PositionType { get; private set; }
public VocabularyKey Title { get; private set; }
public VocabularyKey DetailEffective { get; private set; }
public VocabularyKey DetailExpiration { get; private set; }
public VocabularyKey DepartmentNumber { get; private set; }
public VocabularyKey CompensationRegionId { get; private set; }
public VocabularyKey JobId { get; private set; }
public VocabularyKey PositionTypeId { get; private set; }
public VocabularyKey TitleId { get; private set; }
public VocabularyKey Activation { get; private set; }
public VocabularyKey Retirement { get; private set; }
public VocabularyKey WorkerAssignmentReasonCode { get; private set; }
public VocabularyKey WorkerAssignmentStart { get; private set; }
public VocabularyKey WorkerAssignmentEnd { get; private set; }
public VocabularyKey Worker { get; private set; }
public VocabularyKey WorkerPersonnelNumber { get; private set; }
public VocabularyKey WorkerAssignmentReasonCodeId { get; private set; }
public VocabularyKey WorkerName { get; private set; }
public VocabularyKey LegalEntity { get; private set; }
public VocabularyKey PaidByLegalEntity { get; private set; }
public VocabularyKey PayCycle { get; private set; }
public VocabularyKey PayCycleId { get; private set; }
public VocabularyKey AnnualRegularHours { get; private set; }
public VocabularyKey PayrollDetailEffective { get; private set; }
public VocabularyKey PayrollDetailExpiration { get; private set; }
public VocabularyKey IsSalaryGenerated { get; private set; }
public VocabularyKey DefaultEarningCodeId { get; private set; }
public VocabularyKey InsuranceBenefit { get; private set; }
public VocabularyKey AreEarningsGeneratedFromSchedule { get; private set; }
public VocabularyKey PaidBy { get; private set; }
public VocabularyKey PayPeriodOvertimeHours { get; private set; }
public VocabularyKey Schedule { get; private set; }
public VocabularyKey ScheduleLegalEntity { get; private set; }
public VocabularyKey BenefitId { get; private set; }


    }
}