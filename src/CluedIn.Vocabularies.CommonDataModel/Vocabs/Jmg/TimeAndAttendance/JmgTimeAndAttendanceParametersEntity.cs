using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgTimeAndAttendanceParametersEntityVocabulary : SimpleVocabulary
    {
        public JmgTimeAndAttendanceParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgTimeAndAttendanceParametersEntity";
            KeyPrefix = "commonDataModel.jmgtimeandattendanceparametersentity";
            KeySeparator = ".";
            Grouping = "/JmgTimeAndAttendanceParametersEntity";

            AddGroup("Common Data Model JmgTimeAndAttendanceParametersEntity Details", group =>
            {
                AutomaticAbsenceRegistrationAbsenceCodeJobId = group.Add(new VocabularyKey(nameof(AutomaticAbsenceRegistrationAbsenceCodeJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillReachingMaximumWorkingMinutesAutomaticallyRegisterClockOut = group.Add(new VocabularyKey(nameof(WillReachingMaximumWorkingMinutesAutomaticallyRegisterClockOut), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarcodeSetupId = group.Add(new VocabularyKey(nameof(BarcodeSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AbsencePayrollCostInclusionMethod = group.Add(new VocabularyKey(nameof(AbsencePayrollCostInclusionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaidBreakPayrollCostInclusionMethod = group.Add(new VocabularyKey(nameof(PaidBreakPayrollCostInclusionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayrollCostCalculationFactor = group.Add(new VocabularyKey(nameof(PayrollCostCalculationFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FlextimeDirectPayrollCostInclusionMethod = group.Add(new VocabularyKey(nameof(FlextimeDirectPayrollCostInclusionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FlextimeIndirectPayrollCostInclusionMethod = group.Add(new VocabularyKey(nameof(FlextimeIndirectPayrollCostInclusionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StandardTimePayrollCostInclusionMethod = group.Add(new VocabularyKey(nameof(StandardTimePayrollCostInclusionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OvertimePayrollCostInclusionMethod = group.Add(new VocabularyKey(nameof(OvertimePayrollCostInclusionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutomaticPremiumsPayrollCostInclusionMethod = group.Add(new VocabularyKey(nameof(AutomaticPremiumsPayrollCostInclusionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualPremiumsPayrollCostInclusionMethod = group.Add(new VocabularyKey(nameof(ManualPremiumsPayrollCostInclusionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillIndirectActivityCostCalculationUseIndirectActivityCostCategory = group.Add(new VocabularyKey(nameof(WillIndirectActivityCostCalculationUseIndirectActivityCostCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProjectCostCalculationUseProjectCostCategory = group.Add(new VocabularyKey(nameof(WillProjectCostCalculationUseProjectCostCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRegistrationJobFeedbackStatus = group.Add(new VocabularyKey(nameof(DefaultRegistrationJobFeedbackStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayrollExportRollbackErrorLevel = group.Add(new VocabularyKey(nameof(PayrollExportRollbackErrorLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationTimeOrigin = group.Add(new VocabularyKey(nameof(RegistrationTimeOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaterialConsumptionInventoryAdjustmentJournalNameId = group.Add(new VocabularyKey(nameof(MaterialConsumptionInventoryAdjustmentJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AbsenceRegistrationLedgerDimensionSelectionRule = group.Add(new VocabularyKey(nameof(AbsenceRegistrationLedgerDimensionSelectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BreakRegistrationLedgerDimensionSelectionRule = group.Add(new VocabularyKey(nameof(BreakRegistrationLedgerDimensionSelectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndirectActivityRegistrationLedgerDimensionSelectionRule = group.Add(new VocabularyKey(nameof(IndirectActivityRegistrationLedgerDimensionSelectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeAndAttendanceJobsSynchronizationMode = group.Add(new VocabularyKey(nameof(TimeAndAttendanceJobsSynchronizationMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndirectActivitiesHoursLedgerJournalNameId = group.Add(new VocabularyKey(nameof(IndirectActivitiesHoursLedgerJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePilotAndAssistantTeamRelationsPreserved = group.Add(new VocabularyKey(nameof(ArePilotAndAssistantTeamRelationsPreserved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWorkingMinutes = group.Add(new VocabularyKey(nameof(MaximumWorkingMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutomaticFlextimeRegistrationAbsenceCodeJobId = group.Add(new VocabularyKey(nameof(AutomaticFlextimeRegistrationAbsenceCodeJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayrollExportFileFormat = group.Add(new VocabularyKey(nameof(PayrollExportFileFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRegistrationTransferPostProjectHourJournal = group.Add(new VocabularyKey(nameof(WillRegistrationTransferPostProjectHourJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectRegistrationLedgerDimensionSelectionRule = group.Add(new VocabularyKey(nameof(ProjectRegistrationLedgerDimensionSelectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeProjectJournalNameId = group.Add(new VocabularyKey(nameof(FeeProjectJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectMaterialConsumptionInventoryJournalNameId = group.Add(new VocabularyKey(nameof(ProjectMaterialConsumptionInventoryJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HoursProjectJournalNameId = group.Add(new VocabularyKey(nameof(HoursProjectJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectStatusUpdateMode = group.Add(new VocabularyKey(nameof(ProjectStatusUpdateMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationErrorHandlingRule = group.Add(new VocabularyKey(nameof(RegistrationErrorHandlingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillClockInRestartUnfinishedJob = group.Add(new VocabularyKey(nameof(WillClockInRestartUnfinishedJob), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeDisplayMode = group.Add(new VocabularyKey(nameof(TimeDisplayMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicTimecardPageInputMode = group.Add(new VocabularyKey(nameof(ElectronicTimecardPageInputMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillElectronicTimecardPageDisplayStartDate = group.Add(new VocabularyKey(nameof(WillElectronicTimecardPageDisplayStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillElectronicTimecardPageDisplayEndDate = group.Add(new VocabularyKey(nameof(WillElectronicTimecardPageDisplayEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreAbsenceRegistrationsTransferredToHRM = group.Add(new VocabularyKey(nameof(AreAbsenceRegistrationsTransferredToHRM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBadgeIdUsedAsIdentification = group.Add(new VocabularyKey(nameof(IsBadgeIdUsedAsIdentification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPasswordIdentificationRequired = group.Add(new VocabularyKey(nameof(IsPasswordIdentificationRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AutomaticAbsenceRegistrationAbsenceCodeJobId { get; private set; }
        public VocabularyKey WillReachingMaximumWorkingMinutesAutomaticallyRegisterClockOut { get; private set; }
        public VocabularyKey BarcodeSetupId { get; private set; }
        public VocabularyKey AbsencePayrollCostInclusionMethod { get; private set; }
        public VocabularyKey PaidBreakPayrollCostInclusionMethod { get; private set; }
        public VocabularyKey PayrollCostCalculationFactor { get; private set; }
        public VocabularyKey FlextimeDirectPayrollCostInclusionMethod { get; private set; }
        public VocabularyKey FlextimeIndirectPayrollCostInclusionMethod { get; private set; }
        public VocabularyKey StandardTimePayrollCostInclusionMethod { get; private set; }
        public VocabularyKey OvertimePayrollCostInclusionMethod { get; private set; }
        public VocabularyKey AutomaticPremiumsPayrollCostInclusionMethod { get; private set; }
        public VocabularyKey ManualPremiumsPayrollCostInclusionMethod { get; private set; }
        public VocabularyKey WillIndirectActivityCostCalculationUseIndirectActivityCostCategory { get; private set; }
        public VocabularyKey WillProjectCostCalculationUseProjectCostCategory { get; private set; }
        public VocabularyKey DefaultRegistrationJobFeedbackStatus { get; private set; }
        public VocabularyKey PayrollExportRollbackErrorLevel { get; private set; }
        public VocabularyKey RegistrationTimeOrigin { get; private set; }
        public VocabularyKey MaterialConsumptionInventoryAdjustmentJournalNameId { get; private set; }
        public VocabularyKey AbsenceRegistrationLedgerDimensionSelectionRule { get; private set; }
        public VocabularyKey BreakRegistrationLedgerDimensionSelectionRule { get; private set; }
        public VocabularyKey IndirectActivityRegistrationLedgerDimensionSelectionRule { get; private set; }
        public VocabularyKey TimeAndAttendanceJobsSynchronizationMode { get; private set; }
        public VocabularyKey IndirectActivitiesHoursLedgerJournalNameId { get; private set; }
        public VocabularyKey ArePilotAndAssistantTeamRelationsPreserved { get; private set; }
        public VocabularyKey MaximumWorkingMinutes { get; private set; }
        public VocabularyKey AutomaticFlextimeRegistrationAbsenceCodeJobId { get; private set; }
        public VocabularyKey PayrollExportFileFormat { get; private set; }
        public VocabularyKey WillRegistrationTransferPostProjectHourJournal { get; private set; }
        public VocabularyKey ProjectRegistrationLedgerDimensionSelectionRule { get; private set; }
        public VocabularyKey FeeProjectJournalNameId { get; private set; }
        public VocabularyKey ProjectMaterialConsumptionInventoryJournalNameId { get; private set; }
        public VocabularyKey HoursProjectJournalNameId { get; private set; }
        public VocabularyKey ProjectStatusUpdateMode { get; private set; }
        public VocabularyKey RegistrationErrorHandlingRule { get; private set; }
        public VocabularyKey WillClockInRestartUnfinishedJob { get; private set; }
        public VocabularyKey TimeDisplayMode { get; private set; }
        public VocabularyKey ElectronicTimecardPageInputMode { get; private set; }
        public VocabularyKey WillElectronicTimecardPageDisplayStartDate { get; private set; }
        public VocabularyKey WillElectronicTimecardPageDisplayEndDate { get; private set; }
        public VocabularyKey AreAbsenceRegistrationsTransferredToHRM { get; private set; }
        public VocabularyKey IsBadgeIdUsedAsIdentification { get; private set; }
        public VocabularyKey IsPasswordIdentificationRequired { get; private set; }


    }
}