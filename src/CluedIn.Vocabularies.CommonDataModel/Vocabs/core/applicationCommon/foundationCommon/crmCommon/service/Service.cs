using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class ServiceVocabulary : SimpleVocabulary
    {
        public ServiceVocabulary()
        {
            VocabularyName = "Service";
            KeyPrefix = "commonDataModel.service.service";
            KeySeparator = ".";
            Grouping = "/Service";

            AddGroup("Service Details for Service", group =>
            {
			    ServiceId = group.Add(new VocabularyKey(nameof(ServiceId), "Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AnchorOffset = group.Add(new VocabularyKey(nameof(AnchorOffset), "Anchor Offset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), "Calendar", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Duration = group.Add(new VocabularyKey(nameof(Duration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Granularity = group.Add(new VocabularyKey(nameof(Granularity), "Granularity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InitialStatusCode = group.Add(new VocabularyKey(nameof(InitialStatusCode), "Initial Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsSchedulable = group.Add(new VocabularyKey(nameof(IsSchedulable), "Status", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsVisible = group.Add(new VocabularyKey(nameof(IsVisible), "Is Visible", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ShowResources = group.Add(new VocabularyKey(nameof(ShowResources), "Show Resources", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    StrategyId = group.Add(new VocabularyKey(nameof(StrategyId), "Strategy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ServiceId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AnchorOffset { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey Granularity { get; private set; }
        public VocabularyKey InitialStatusCode { get; private set; }
        public VocabularyKey IsSchedulable { get; private set; }
        public VocabularyKey IsVisible { get; private set; }
        public VocabularyKey ShowResources { get; private set; }
        public VocabularyKey StrategyId { get; private set; }
    }
}