using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class AppointmentVocabulary : SimpleVocabulary
    {
        public AppointmentVocabulary()
        {
            VocabularyName = "Appointment";
            KeyPrefix = "commonDataModel.appointment.applicationcommon";
            KeySeparator = ".";
            Grouping = "/Appointment";

            AddGroup("Appointment Details for ApplicationCommon", group =>
            {
			    IsAllDayEvent = group.Add(new VocabularyKey(nameof(IsAllDayEvent), "All Day Event", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GlobalObjectId = group.Add(new VocabularyKey(nameof(GlobalObjectId), "Outlook Appointment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OutlookOwnerApptId = group.Add(new VocabularyKey(nameof(OutlookOwnerApptId), "Outlook Appointment Owner", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Location = group.Add(new VocabularyKey(nameof(Location), "Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedFieldsMask = group.Add(new VocabularyKey(nameof(ModifiedFieldsMask), "Modified Fields Mask", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OriginalStartDate = group.Add(new VocabularyKey(nameof(OriginalStartDate), "Original Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    AttachmentErrors = group.Add(new VocabularyKey(nameof(AttachmentErrors), "AttachmentErrors", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AttachmentCount = group.Add(new VocabularyKey(nameof(AttachmentCount), "Attachment Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsUnsafe = group.Add(new VocabularyKey(nameof(IsUnsafe), "IsUnsafe", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IsDraft = group.Add(new VocabularyKey(nameof(IsDraft), "IsDraft", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey IsAllDayEvent { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey GlobalObjectId { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey OutlookOwnerApptId { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey ModifiedFieldsMask { get; private set; }
        public VocabularyKey OriginalStartDate { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey AttachmentErrors { get; private set; }
        public VocabularyKey AttachmentCount { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey IsUnsafe { get; private set; }
        public VocabularyKey IsDraft { get; private set; }
    }
}