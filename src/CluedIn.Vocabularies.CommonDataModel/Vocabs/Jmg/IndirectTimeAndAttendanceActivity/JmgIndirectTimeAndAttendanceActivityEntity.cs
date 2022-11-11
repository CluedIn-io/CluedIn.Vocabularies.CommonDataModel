using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgIndirectTimeAndAttendanceActivityEntityVocabulary : SimpleVocabulary
    {
        public JmgIndirectTimeAndAttendanceActivityEntityVocabulary()
        {
            VocabularyName = "JmgIndirectTimeAndAttendanceActivityEntity";
            KeyPrefix = "commonDataModel.jmgindirecttimeandattendanceactivityentity";
            KeySeparator = ".";
            Grouping = "/JmgIndirectTimeAndAttendanceActivityEntity";

            AddGroup("JmgIndirectTimeAndAttendanceActivityEntity Details", group =>
            {
                ActivityId = group.Add(new VocabularyKey(nameof(ActivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BreakCancelationRule = group.Add(new VocabularyKey(nameof(BreakCancelationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBreakPayable = group.Add(new VocabularyKey(nameof(IsBreakPayable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BreakDurationMinutes = group.Add(new VocabularyKey(nameof(BreakDurationMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BreakToleranceMinutes = group.Add(new VocabularyKey(nameof(BreakToleranceMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndirectTimeAndAttendanceCategoryId = group.Add(new VocabularyKey(nameof(IndirectTimeAndAttendanceCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityDescription = group.Add(new VocabularyKey(nameof(ActivityDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSwitchCodeApprovalRequired = group.Add(new VocabularyKey(nameof(IsSwitchCodeApprovalRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeAndAttendanceJobId = group.Add(new VocabularyKey(nameof(TimeAndAttendanceJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountId = group.Add(new VocabularyKey(nameof(OffsetAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkerRegistrationAllowed = group.Add(new VocabularyKey(nameof(IsWorkerRegistrationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobSystemFunction = group.Add(new VocabularyKey(nameof(JobSystemFunction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActivityId { get; private set; }
        public VocabularyKey BreakCancelationRule { get; private set; }
        public VocabularyKey IsBreakPayable { get; private set; }
        public VocabularyKey BreakDurationMinutes { get; private set; }
        public VocabularyKey BreakToleranceMinutes { get; private set; }
        public VocabularyKey IndirectTimeAndAttendanceCategoryId { get; private set; }
        public VocabularyKey ActivityDescription { get; private set; }
        public VocabularyKey IsSwitchCodeApprovalRequired { get; private set; }
        public VocabularyKey TimeAndAttendanceJobId { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey OffsetAccountId { get; private set; }
        public VocabularyKey IsWorkerRegistrationAllowed { get; private set; }
        public VocabularyKey JobSystemFunction { get; private set; }
        public VocabularyKey MainAccountIdDisplayValue { get; private set; }
        public VocabularyKey OffsetAccountIdDisplayValue { get; private set; }


    }
}