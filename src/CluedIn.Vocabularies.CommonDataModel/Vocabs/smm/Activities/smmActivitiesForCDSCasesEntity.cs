using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmActivitiesForCDSCasesEntityVocabulary : SimpleVocabulary
    {
        public smmActivitiesForCDSCasesEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmActivitiesForCDSCasesEntity";
            KeyPrefix = "commonDataModel.smmactivitiesforcdscasesentity";
            KeySeparator = ".";
            Grouping = "/smmActivitiesForCDSCasesEntity";

            AddGroup("Common Data Model smmActivitiesForCDSCasesEntity Details", group =>
            {
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityStatus = group.Add(new VocabularyKey(nameof(ActivityStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualWork = group.Add(new VocabularyKey(nameof(ActualWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllDay = group.Add(new VocabularyKey(nameof(AllDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingInformation = group.Add(new VocabularyKey(nameof(BillingInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CaseId = group.Add(new VocabularyKey(nameof(CaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Closed = group.Add(new VocabularyKey(nameof(Closed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClosedByPersonnelNumber = group.Add(new VocabularyKey(nameof(ClosedByPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompletedPercentage = group.Add(new VocabularyKey(nameof(CompletedPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateAndTimeClosed = group.Add(new VocabularyKey(nameof(DateAndTimeClosed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dispatched = group.Add(new VocabularyKey(nameof(Dispatched), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeepSynchronized = group.Add(new VocabularyKey(nameof(KeepSynchronized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastDateTimeEdited = group.Add(new VocabularyKey(nameof(LastDateTimeEdited), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MasterAppointment = group.Add(new VocabularyKey(nameof(MasterAppointment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mileage = group.Add(new VocabularyKey(nameof(Mileage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Modified = group.Add(new VocabularyKey(nameof(Modified), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalStartDate = group.Add(new VocabularyKey(nameof(OriginalStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutlookCategories = group.Add(new VocabularyKey(nameof(OutlookCategories), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutlookEntryId = group.Add(new VocabularyKey(nameof(OutlookEntryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutlookResources = group.Add(new VocabularyKey(nameof(OutlookResources), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutlookResponseRequested = group.Add(new VocabularyKey(nameof(OutlookResponseRequested), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutlookSharedObjectId = group.Add(new VocabularyKey(nameof(OutlookSharedObjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutlookText = group.Add(new VocabularyKey(nameof(OutlookText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhaseId = group.Add(new VocabularyKey(nameof(PhaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanId = group.Add(new VocabularyKey(nameof(PlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecurrenceState = group.Add(new VocabularyKey(nameof(RecurrenceState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reminder = group.Add(new VocabularyKey(nameof(Reminder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReminderDate = group.Add(new VocabularyKey(nameof(ReminderDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReminderMinutes = group.Add(new VocabularyKey(nameof(ReminderMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponsibleWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(ResponsibleWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponsibilityId = group.Add(new VocabularyKey(nameof(ResponsibilityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Role = group.Add(new VocabularyKey(nameof(Role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Sensitivity = group.Add(new VocabularyKey(nameof(Sensitivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowTimeAs = group.Add(new VocabularyKey(nameof(ShowTimeAs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceApplication = group.Add(new VocabularyKey(nameof(SourceApplication), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamTask = group.Add(new VocabularyKey(nameof(TeamTask), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Template = group.Add(new VocabularyKey(nameof(Template), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalWork = group.Add(new VocabularyKey(nameof(TotalWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey ActivityStatus { get; private set; }
        public VocabularyKey ActualWork { get; private set; }
        public VocabularyKey AllDay { get; private set; }
        public VocabularyKey BillingInformation { get; private set; }
        public VocabularyKey CaseId { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey Closed { get; private set; }
        public VocabularyKey ClosedByPersonnelNumber { get; private set; }
        public VocabularyKey CompletedPercentage { get; private set; }
        public VocabularyKey DateAndTimeClosed { get; private set; }
        public VocabularyKey Dispatched { get; private set; }
        public VocabularyKey EndDateTime { get; private set; }
        public VocabularyKey KeepSynchronized { get; private set; }
        public VocabularyKey LastDateTimeEdited { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey MasterAppointment { get; private set; }
        public VocabularyKey Mileage { get; private set; }
        public VocabularyKey Modified { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey OriginalStartDate { get; private set; }
        public VocabularyKey OutlookCategories { get; private set; }
        public VocabularyKey OutlookEntryId { get; private set; }
        public VocabularyKey OutlookResources { get; private set; }
        public VocabularyKey OutlookResponseRequested { get; private set; }
        public VocabularyKey OutlookSharedObjectId { get; private set; }
        public VocabularyKey OutlookText { get; private set; }
        public VocabularyKey PhaseId { get; private set; }
        public VocabularyKey PlanId { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey RecurrenceState { get; private set; }
        public VocabularyKey Reminder { get; private set; }
        public VocabularyKey ReminderDate { get; private set; }
        public VocabularyKey ReminderMinutes { get; private set; }
        public VocabularyKey ResponsibleWorkerPersonnelNumber { get; private set; }
        public VocabularyKey ResponsibilityId { get; private set; }
        public VocabularyKey Role { get; private set; }
        public VocabularyKey Sensitivity { get; private set; }
        public VocabularyKey ShowTimeAs { get; private set; }
        public VocabularyKey SourceApplication { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey TeamTask { get; private set; }
        public VocabularyKey Template { get; private set; }
        public VocabularyKey TotalWork { get; private set; }
        public VocabularyKey TypeId { get; private set; }


    }
}