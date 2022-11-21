using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgTimeAndAttendanceActivityRegistrationCalculationEntityVocabulary : SimpleVocabulary
    {
        public JmgTimeAndAttendanceActivityRegistrationCalculationEntityVocabulary()
        {
            VocabularyName = "Jmg Time And Attendance Activity Registration Calculation Entity";
            KeyPrefix = "commonDataModel.jmgtimeandattendanceactivityregistrationcalculationentity";
            KeySeparator = ".";
            Grouping = "/JmgTimeAndAttendanceActivityRegistrationCalculationEntity";

            AddGroup("JmgTimeAndAttendanceActivityRegistrationCalculationEntity Details", group =>
            {
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorLogText = group.Add(new VocabularyKey(nameof(ErrorLogText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HasErrors = group.Add(new VocabularyKey(nameof(HasErrors), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsApproved = group.Add(new VocabularyKey(nameof(IsApproved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCalculated = group.Add(new VocabularyKey(nameof(IsCalculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsClockInToleranceDropped = group.Add(new VocabularyKey(nameof(IsClockInToleranceDropped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsClockOutToleranceDropped = group.Add(new VocabularyKey(nameof(IsClockOutToleranceDropped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFlexTimeAllowed = group.Add(new VocabularyKey(nameof(IsFlexTimeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTimeProfileChanged = group.Add(new VocabularyKey(nameof(IsTimeProfileChanged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransferred = group.Add(new VocabularyKey(nameof(IsTransferred), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayAgreementId = group.Add(new VocabularyKey(nameof(PayAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayEndDate = group.Add(new VocabularyKey(nameof(PayEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayEndTime = group.Add(new VocabularyKey(nameof(PayEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStartTime = group.Add(new VocabularyKey(nameof(PayStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStartDate = group.Add(new VocabularyKey(nameof(PayStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeAndAttendanceApprovalGroupId = group.Add(new VocabularyKey(nameof(TimeAndAttendanceApprovalGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeAndAttendanceCalculationGroupId = group.Add(new VocabularyKey(nameof(TimeAndAttendanceCalculationGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProfileDate = group.Add(new VocabularyKey(nameof(TimeProfileDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProfileEndTime = group.Add(new VocabularyKey(nameof(TimeProfileEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProfileEndDate = group.Add(new VocabularyKey(nameof(TimeProfileEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProfileId = group.Add(new VocabularyKey(nameof(TimeProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProfileNormFlexTimeSeconds = group.Add(new VocabularyKey(nameof(TimeProfileNormFlexTimeSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProfileNormSeconds = group.Add(new VocabularyKey(nameof(TimeProfileNormSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProfileSeconds = group.Add(new VocabularyKey(nameof(TimeProfileSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProfileStartTime = group.Add(new VocabularyKey(nameof(TimeProfileStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProfileStartDate = group.Add(new VocabularyKey(nameof(TimeProfileStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalNonPaidBreakSeconds = group.Add(new VocabularyKey(nameof(TotalNonPaidBreakSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalPaidBreakSeconds = group.Add(new VocabularyKey(nameof(TotalPaidBreakSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalPayAbsenceSeconds = group.Add(new VocabularyKey(nameof(TotalPayAbsenceSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalPayFlexTimeAddSeconds = group.Add(new VocabularyKey(nameof(TotalPayFlexTimeAddSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalPayFlexTimeBalanceSeconds = group.Add(new VocabularyKey(nameof(TotalPayFlexTimeBalanceSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalPayFlexTimeCorrectionSeconds = group.Add(new VocabularyKey(nameof(TotalPayFlexTimeCorrectionSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalPayFlexTimeSubSeconds = group.Add(new VocabularyKey(nameof(TotalPayFlexTimeSubSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalPayIllegalAbsenceSeconds = group.Add(new VocabularyKey(nameof(TotalPayIllegalAbsenceSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalPayLegalAbsenceSeconds = group.Add(new VocabularyKey(nameof(TotalPayLegalAbsenceSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalPayOverTimeSeconds = group.Add(new VocabularyKey(nameof(TotalPayOverTimeSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalPaySeconds = group.Add(new VocabularyKey(nameof(TotalPaySeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalWorkSeconds = group.Add(new VocabularyKey(nameof(TotalWorkSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalWorkSecondsNotAllocated = group.Add(new VocabularyKey(nameof(TotalWorkSecondsNotAllocated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkEndTime = group.Add(new VocabularyKey(nameof(WorkEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkEndDate = group.Add(new VocabularyKey(nameof(WorkEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowStatus = group.Add(new VocabularyKey(nameof(WorkflowStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkStartTime = group.Add(new VocabularyKey(nameof(WorkStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkStartDate = group.Add(new VocabularyKey(nameof(WorkStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverPersonnelNumber = group.Add(new VocabularyKey(nameof(ApproverPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculatorPersonnelNumber = group.Add(new VocabularyKey(nameof(CalculatorPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferrerPeronnelNumber = group.Add(new VocabularyKey(nameof(TransferrerPeronnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey ErrorLogText { get; private set; }
        public VocabularyKey HasErrors { get; private set; }
        public VocabularyKey IsApproved { get; private set; }
        public VocabularyKey IsCalculated { get; private set; }
        public VocabularyKey IsClockInToleranceDropped { get; private set; }
        public VocabularyKey IsClockOutToleranceDropped { get; private set; }
        public VocabularyKey IsFlexTimeAllowed { get; private set; }
        public VocabularyKey IsTimeProfileChanged { get; private set; }
        public VocabularyKey IsTransferred { get; private set; }
        public VocabularyKey PayAgreementId { get; private set; }
        public VocabularyKey PayEndDate { get; private set; }
        public VocabularyKey PayEndTime { get; private set; }
        public VocabularyKey PayStartTime { get; private set; }
        public VocabularyKey PayStartDate { get; private set; }
        public VocabularyKey TimeAndAttendanceApprovalGroupId { get; private set; }
        public VocabularyKey TimeAndAttendanceCalculationGroupId { get; private set; }
        public VocabularyKey TimeProfileDate { get; private set; }
        public VocabularyKey TimeProfileEndTime { get; private set; }
        public VocabularyKey TimeProfileEndDate { get; private set; }
        public VocabularyKey TimeProfileId { get; private set; }
        public VocabularyKey TimeProfileNormFlexTimeSeconds { get; private set; }
        public VocabularyKey TimeProfileNormSeconds { get; private set; }
        public VocabularyKey TimeProfileSeconds { get; private set; }
        public VocabularyKey TimeProfileStartTime { get; private set; }
        public VocabularyKey TimeProfileStartDate { get; private set; }
        public VocabularyKey TotalNonPaidBreakSeconds { get; private set; }
        public VocabularyKey TotalPaidBreakSeconds { get; private set; }
        public VocabularyKey TotalPayAbsenceSeconds { get; private set; }
        public VocabularyKey TotalPayFlexTimeAddSeconds { get; private set; }
        public VocabularyKey TotalPayFlexTimeBalanceSeconds { get; private set; }
        public VocabularyKey TotalPayFlexTimeCorrectionSeconds { get; private set; }
        public VocabularyKey TotalPayFlexTimeSubSeconds { get; private set; }
        public VocabularyKey TotalPayIllegalAbsenceSeconds { get; private set; }
        public VocabularyKey TotalPayLegalAbsenceSeconds { get; private set; }
        public VocabularyKey TotalPayOverTimeSeconds { get; private set; }
        public VocabularyKey TotalPaySeconds { get; private set; }
        public VocabularyKey TotalWorkSeconds { get; private set; }
        public VocabularyKey TotalWorkSecondsNotAllocated { get; private set; }
        public VocabularyKey WorkEndTime { get; private set; }
        public VocabularyKey WorkEndDate { get; private set; }
        public VocabularyKey WorkflowStatus { get; private set; }
        public VocabularyKey WorkStartTime { get; private set; }
        public VocabularyKey WorkStartDate { get; private set; }
        public VocabularyKey WorkerPersonnelNumber { get; private set; }
        public VocabularyKey ApproverPersonnelNumber { get; private set; }
        public VocabularyKey CalculatorPersonnelNumber { get; private set; }
        public VocabularyKey TransferrerPeronnelNumber { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
    }
}