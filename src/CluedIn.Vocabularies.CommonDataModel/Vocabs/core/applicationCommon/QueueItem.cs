using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class QueueItemVocabulary : SimpleVocabulary
    {
        public QueueItemVocabulary()
        {
            VocabularyName = "Queue Item";
            KeyPrefix = "commonDataModel.queueitem.applicationcommon";
            KeySeparator = ".";
            Grouping = "/QueueItem";

            AddGroup("QueueItem Details for ApplicationCommon", group =>
            {
			    QueueItemId = group.Add(new VocabularyKey(nameof(QueueItemId), "Queue Item", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObjectTypeCode = group.Add(new VocabularyKey(nameof(ObjectTypeCode), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EnteredOn = group.Add(new VocabularyKey(nameof(EnteredOn), "Entered Queue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Priority = group.Add(new VocabularyKey(nameof(Priority), "Priority", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    State = group.Add(new VocabularyKey(nameof(State), "Status (deprecated)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status Reason (deprecated)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ToRecipients = group.Add(new VocabularyKey(nameof(ToRecipients), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Sender = group.Add(new VocabularyKey(nameof(Sender), "From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkerIdModifiedOn = group.Add(new VocabularyKey(nameof(WorkerIdModifiedOn), "Worked On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), "Owning User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningBusinessUnit = group.Add(new VocabularyKey(nameof(OwningBusinessUnit), "Owning Business Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey QueueItemId { get; private set; }
        public VocabularyKey ObjectTypeCode { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey EnteredOn { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ToRecipients { get; private set; }
        public VocabularyKey Sender { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey WorkerIdModifiedOn { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey OwningBusinessUnit { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
    }
}