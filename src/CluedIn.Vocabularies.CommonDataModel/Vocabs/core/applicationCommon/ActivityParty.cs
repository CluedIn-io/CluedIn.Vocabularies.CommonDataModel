using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class ActivityPartyVocabulary : SimpleVocabulary
    {
        public ActivityPartyVocabulary()
        {
            VocabularyName = "Activity Party";
            KeyPrefix = "commonDataModel.activityparty.applicationcommon";
            KeySeparator = ".";
            Grouping = "/ActivityParty";

            AddGroup("ActivityParty Details for ApplicationCommon", group =>
            {
			    ActivityPartyId = group.Add(new VocabularyKey(nameof(ActivityPartyId), "Activity Party", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipationTypeMask = group.Add(new VocabularyKey(nameof(ParticipationTypeMask), "Participation Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressUsed = group.Add(new VocabularyKey(nameof(AddressUsed), "Address ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DoNotFax = group.Add(new VocabularyKey(nameof(DoNotFax), "Do not allow Faxes", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ScheduledStart = group.Add(new VocabularyKey(nameof(ScheduledStart), "Scheduled Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledEnd = group.Add(new VocabularyKey(nameof(ScheduledEnd), "Scheduled End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Effort = group.Add(new VocabularyKey(nameof(Effort), "Effort", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DoNotEMail = group.Add(new VocabularyKey(nameof(DoNotEMail), "Do not allow Emails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExchangeEntryId = group.Add(new VocabularyKey(nameof(ExchangeEntryId), "Exchange Entry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DoNotPostalMail = group.Add(new VocabularyKey(nameof(DoNotPostalMail), "Do not allow Postal Mails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotPhone = group.Add(new VocabularyKey(nameof(DoNotPhone), "Do not allow Phone Calls", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    InstanceTypeCode = group.Add(new VocabularyKey(nameof(InstanceTypeCode), "Appointment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsPartyDeleted = group.Add(new VocabularyKey(nameof(IsPartyDeleted), "Is Party Deleted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AddressUsedEmailColumnNumber = group.Add(new VocabularyKey(nameof(AddressUsedEmailColumnNumber), "Email column number of party", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActivityPartyId { get; private set; }
        public VocabularyKey ParticipationTypeMask { get; private set; }
        public VocabularyKey AddressUsed { get; private set; }
        public VocabularyKey DoNotFax { get; private set; }
        public VocabularyKey ScheduledStart { get; private set; }
        public VocabularyKey ScheduledEnd { get; private set; }
        public VocabularyKey Effort { get; private set; }
        public VocabularyKey DoNotEMail { get; private set; }
        public VocabularyKey ExchangeEntryId { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey DoNotPostalMail { get; private set; }
        public VocabularyKey DoNotPhone { get; private set; }
        public VocabularyKey InstanceTypeCode { get; private set; }
        public VocabularyKey IsPartyDeleted { get; private set; }
        public VocabularyKey AddressUsedEmailColumnNumber { get; private set; }
    }
}