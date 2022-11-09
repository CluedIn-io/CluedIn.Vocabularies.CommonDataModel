using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CaseDetailBaseEntityVocabulary : SimpleVocabulary
    {
        public CaseDetailBaseEntityVocabulary()
        {
            VocabularyName = "Common Data Model CaseDetailBaseEntity";
            KeyPrefix = "commonDataModel.casedetailbaseentity";
            KeySeparator = ".";
            Grouping = "/CaseDetailBaseEntity";

            AddGroup("Common Data Model CaseDetailBaseEntity Details", group =>
            {
                AnswerId = group.Add(new VocabularyKey(nameof(AnswerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillingProjectId = group.Add(new VocabularyKey(nameof(BillingProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CaseCategoryHierarchyDetail = group.Add(new VocabularyKey(nameof(CaseCategoryHierarchyDetail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CaseId = group.Add(new VocabularyKey(nameof(CaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CaseStatus = group.Add(new VocabularyKey(nameof(CaseStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryType = group.Add(new VocabularyKey(nameof(CategoryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClosedBy = group.Add(new VocabularyKey(nameof(ClosedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClosedDateAndTime = group.Add(new VocabularyKey(nameof(ClosedDateAndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Compliance = group.Add(new VocabularyKey(nameof(Compliance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CaseCreatedDateAndTime = group.Add(new VocabularyKey(nameof(CaseCreatedDateAndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactId = group.Add(new VocabularyKey(nameof(ContactId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Department = group.Add(new VocabularyKey(nameof(Department), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DirParty = group.Add(new VocabularyKey(nameof(DirParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmployeeResponsibleName = group.Add(new VocabularyKey(nameof(EmployeeResponsibleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmployeeResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(EmployeeResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLAApproved = group.Add(new VocabularyKey(nameof(FMLAApproved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLAApprovedBy = group.Add(new VocabularyKey(nameof(FMLAApprovedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLAApprovedHours = group.Add(new VocabularyKey(nameof(FMLAApprovedHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLAEstimatedLeaveEndDate = group.Add(new VocabularyKey(nameof(FMLAEstimatedLeaveEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLAHoursWorked = group.Add(new VocabularyKey(nameof(FMLAHoursWorked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLALeaveReason = group.Add(new VocabularyKey(nameof(FMLALeaveReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLALeaveRequestDate = group.Add(new VocabularyKey(nameof(FMLALeaveRequestDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLALeaveSchedule = group.Add(new VocabularyKey(nameof(FMLALeaveSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLALeaveStartDate = group.Add(new VocabularyKey(nameof(FMLALeaveStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLALengthOfEmployment = group.Add(new VocabularyKey(nameof(FMLALengthOfEmployment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLAMaintainHoursManually = group.Add(new VocabularyKey(nameof(FMLAMaintainHoursManually), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLAMilitaryHoursAvailable = group.Add(new VocabularyKey(nameof(FMLAMilitaryHoursAvailable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FMLAStandardHoursAvailable = group.Add(new VocabularyKey(nameof(FMLAStandardHoursAvailable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HCMWorker = group.Add(new VocabularyKey(nameof(HCMWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InstanceRelationType = group.Add(new VocabularyKey(nameof(InstanceRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DepartmentNumber = group.Add(new VocabularyKey(nameof(DepartmentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlannedEffectiveDate = group.Add(new VocabularyKey(nameof(PlannedEffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuestionnaireId = group.Add(new VocabularyKey(nameof(QuestionnaireId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Resolution = group.Add(new VocabularyKey(nameof(Resolution), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceStageId = group.Add(new VocabularyKey(nameof(ServiceStageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceLevelAgreementId = group.Add(new VocabularyKey(nameof(ServiceLevelAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceLevelAgreementStatus = group.Add(new VocabularyKey(nameof(ServiceLevelAgreementStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceLevelCompletionDate = group.Add(new VocabularyKey(nameof(ServiceLevelCompletionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmailId = group.Add(new VocabularyKey(nameof(EmailId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AnswerId { get; private set; }
public VocabularyKey BillingProjectId { get; private set; }
public VocabularyKey CaseCategoryHierarchyDetail { get; private set; }
public VocabularyKey CaseId { get; private set; }
public VocabularyKey CaseStatus { get; private set; }
public VocabularyKey CategoryId { get; private set; }
public VocabularyKey CategoryType { get; private set; }
public VocabularyKey ClosedBy { get; private set; }
public VocabularyKey ClosedDateAndTime { get; private set; }
public VocabularyKey Compliance { get; private set; }
public VocabularyKey CaseCreatedDateAndTime { get; private set; }
public VocabularyKey ContactId { get; private set; }
public VocabularyKey Department { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey DirParty { get; private set; }
public VocabularyKey EmployeeResponsibleName { get; private set; }
public VocabularyKey EmployeeResponsiblePersonnelNumber { get; private set; }
public VocabularyKey FMLAApproved { get; private set; }
public VocabularyKey FMLAApprovedBy { get; private set; }
public VocabularyKey FMLAApprovedHours { get; private set; }
public VocabularyKey FMLAEstimatedLeaveEndDate { get; private set; }
public VocabularyKey FMLAHoursWorked { get; private set; }
public VocabularyKey FMLALeaveReason { get; private set; }
public VocabularyKey FMLALeaveRequestDate { get; private set; }
public VocabularyKey FMLALeaveSchedule { get; private set; }
public VocabularyKey FMLALeaveStartDate { get; private set; }
public VocabularyKey FMLALengthOfEmployment { get; private set; }
public VocabularyKey FMLAMaintainHoursManually { get; private set; }
public VocabularyKey FMLAMilitaryHoursAvailable { get; private set; }
public VocabularyKey FMLAStandardHoursAvailable { get; private set; }
public VocabularyKey HCMWorker { get; private set; }
public VocabularyKey InstanceRelationType { get; private set; }
public VocabularyKey Notes { get; private set; }
public VocabularyKey DepartmentNumber { get; private set; }
public VocabularyKey PartyNumber { get; private set; }
public VocabularyKey PlannedEffectiveDate { get; private set; }
public VocabularyKey Priority { get; private set; }
public VocabularyKey ProcessId { get; private set; }
public VocabularyKey QuestionnaireId { get; private set; }
public VocabularyKey Resolution { get; private set; }
public VocabularyKey ServiceStageId { get; private set; }
public VocabularyKey ServiceLevelAgreementId { get; private set; }
public VocabularyKey ServiceLevelAgreementStatus { get; private set; }
public VocabularyKey ServiceLevelCompletionDate { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey EmailId { get; private set; }


    }
}