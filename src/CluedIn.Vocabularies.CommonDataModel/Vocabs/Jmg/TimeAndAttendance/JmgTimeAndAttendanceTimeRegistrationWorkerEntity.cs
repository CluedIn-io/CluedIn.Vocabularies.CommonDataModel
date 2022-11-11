using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgTimeAndAttendanceTimeRegistrationWorkerEntityVocabulary : SimpleVocabulary
    {
        public JmgTimeAndAttendanceTimeRegistrationWorkerEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgTimeAndAttendanceTimeRegistrationWorkerEntity";
            KeyPrefix = "commonDataModel.jmgtimeandattendancetimeregistrationworkerentity";
            KeySeparator = ".";
            Grouping = "/JmgTimeAndAttendanceTimeRegistrationWorkerEntity";

            AddGroup("Common Data Model JmgTimeAndAttendanceTimeRegistrationWorkerEntity Details", group =>
            {
                ApproverPersonnelNumber = group.Add(new VocabularyKey(nameof(ApproverPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CanBundleNewJobs = group.Add(new VocabularyKey(nameof(CanBundleNewJobs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CanUseElectronicTimecard = group.Add(new VocabularyKey(nameof(CanUseElectronicTimecard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultTimeAndAttedanceCalculationGroupId = group.Add(new VocabularyKey(nameof(DefaultTimeAndAttedanceCalculationGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFlexTimeAllowed = group.Add(new VocabularyKey(nameof(IsFlexTimeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HasSupervisorOptions = group.Add(new VocabularyKey(nameof(HasSupervisorOptions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobCardTerminalConfigurationId = group.Add(new VocabularyKey(nameof(JobCardTerminalConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpeningFlexBalanceSeconds = group.Add(new VocabularyKey(nameof(OpeningFlexBalanceSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayAgreementCode = group.Add(new VocabularyKey(nameof(PayAgreementCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectPeriodId = group.Add(new VocabularyKey(nameof(ProjectPeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StandardTimeProfileId = group.Add(new VocabularyKey(nameof(StandardTimeProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SeniorityDate = group.Add(new VocabularyKey(nameof(SeniorityDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeAndAttendanceApprovalGroupId = group.Add(new VocabularyKey(nameof(TimeAndAttendanceApprovalGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeAndAttendanceCalculationGroupId = group.Add(new VocabularyKey(nameof(TimeAndAttendanceCalculationGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeAndAttendanceFlexGroupId = group.Add(new VocabularyKey(nameof(TimeAndAttendanceFlexGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeAndAttendanceProfileGroupId = group.Add(new VocabularyKey(nameof(TimeAndAttendanceProfileGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerActivationDate = group.Add(new VocabularyKey(nameof(WorkerActivationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerBadgeId = group.Add(new VocabularyKey(nameof(WorkerBadgeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerBadgeVersion = group.Add(new VocabularyKey(nameof(WorkerBadgeVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ApproverPersonnelNumber { get; private set; }
        public VocabularyKey CanBundleNewJobs { get; private set; }
        public VocabularyKey CanUseElectronicTimecard { get; private set; }
        public VocabularyKey DefaultTimeAndAttedanceCalculationGroupId { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey IsFlexTimeAllowed { get; private set; }
        public VocabularyKey HasSupervisorOptions { get; private set; }
        public VocabularyKey JobCardTerminalConfigurationId { get; private set; }
        public VocabularyKey OpeningFlexBalanceSeconds { get; private set; }
        public VocabularyKey PayAgreementCode { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey ProjectPeriodId { get; private set; }
        public VocabularyKey StandardTimeProfileId { get; private set; }
        public VocabularyKey SeniorityDate { get; private set; }
        public VocabularyKey TimeAndAttendanceApprovalGroupId { get; private set; }
        public VocabularyKey TimeAndAttendanceCalculationGroupId { get; private set; }
        public VocabularyKey TimeAndAttendanceFlexGroupId { get; private set; }
        public VocabularyKey TimeAndAttendanceProfileGroupId { get; private set; }
        public VocabularyKey WorkerActivationDate { get; private set; }
        public VocabularyKey WorkerBadgeId { get; private set; }
        public VocabularyKey WorkerBadgeVersion { get; private set; }


    }
}