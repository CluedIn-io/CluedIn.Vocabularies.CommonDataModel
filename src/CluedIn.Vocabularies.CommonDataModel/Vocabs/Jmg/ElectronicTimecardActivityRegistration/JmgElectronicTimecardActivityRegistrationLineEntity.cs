using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgElectronicTimecardActivityRegistrationLineEntityVocabulary : SimpleVocabulary
    {
        public JmgElectronicTimecardActivityRegistrationLineEntityVocabulary()
        {
            VocabularyName = "Jmg Electronic Timecard Activity Registration Line Entity";
            KeyPrefix = "commonDataModel.jmgelectronictimecardactivityregistrationlineentity";
            KeySeparator = ".";
            Grouping = "/JmgElectronicTimecardActivityRegistrationLineEntity";

            AddGroup("JmgElectronicTimecardActivityRegistrationLineEntity Details", group =>
            {
                IsWorkInProgress = group.Add(new VocabularyKey(nameof(IsWorkInProgress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobFinished = group.Add(new VocabularyKey(nameof(IsJobFinished), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeAndAttendanceJobId = group.Add(new VocabularyKey(nameof(TimeAndAttendanceJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AbsenceCodeTimeAndAttendanceJobId = group.Add(new VocabularyKey(nameof(AbsenceCodeTimeAndAttendanceJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalRegistrationType = group.Add(new VocabularyKey(nameof(JournalRegistrationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnCallTimeAndAttendanceJobId = group.Add(new VocabularyKey(nameof(OnCallTimeAndAttendanceJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProfileDate = group.Add(new VocabularyKey(nameof(TimeProfileDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculatedTimeSeconds = group.Add(new VocabularyKey(nameof(CalculatedTimeSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StopDateTime = group.Add(new VocabularyKey(nameof(StopDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourcePilotId = group.Add(new VocabularyKey(nameof(OperationsResourcePilotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicTimecardActivityRegistrationEntryNumber = group.Add(new VocabularyKey(nameof(ElectronicTimecardActivityRegistrationEntryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PilotPersonnelNumber = group.Add(new VocabularyKey(nameof(PilotPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionOrderNumber = group.Add(new VocabularyKey(nameof(ProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AbsenceCodeId = group.Add(new VocabularyKey(nameof(AbsenceCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndirectActivityCategoryId = group.Add(new VocabularyKey(nameof(IndirectActivityCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsWorkInProgress { get; private set; }
        public VocabularyKey IsJobFinished { get; private set; }
        public VocabularyKey TimeAndAttendanceJobId { get; private set; }
        public VocabularyKey AbsenceCodeTimeAndAttendanceJobId { get; private set; }
        public VocabularyKey JournalRegistrationType { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey OnCallTimeAndAttendanceJobId { get; private set; }
        public VocabularyKey TimeProfileDate { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey CalculatedTimeSeconds { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey StopDateTime { get; private set; }
        public VocabularyKey OperationsResourceId { get; private set; }
        public VocabularyKey OperationsResourcePilotId { get; private set; }
        public VocabularyKey ElectronicTimecardActivityRegistrationEntryNumber { get; private set; }
        public VocabularyKey WorkerPersonnelNumber { get; private set; }
        public VocabularyKey PilotPersonnelNumber { get; private set; }
        public VocabularyKey ProductionOrderNumber { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey AbsenceCodeId { get; private set; }
        public VocabularyKey IndirectActivityCategoryId { get; private set; }
    }
}