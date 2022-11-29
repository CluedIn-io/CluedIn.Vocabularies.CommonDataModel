using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class ResourceVocabulary : SimpleVocabulary
    {
        public ResourceVocabulary()
        {
            VocabularyName = "Resource";
            KeyPrefix = "commonDataModel.resource.service";
            KeySeparator = ".";
            Grouping = "/Resource";

            AddGroup("Resource Details for Service", group =>
            {
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), "Calendar", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    DisplayInServiceViews = group.Add(new VocabularyKey(nameof(DisplayInServiceViews), "Display in Service Views", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsDisabled = group.Add(new VocabularyKey(nameof(IsDisabled), "Is Disabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ObjectTypeCode = group.Add(new VocabularyKey(nameof(ObjectTypeCode), "Object Type ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey DisplayInServiceViews { get; private set; }
        public VocabularyKey IsDisabled { get; private set; }
        public VocabularyKey ObjectTypeCode { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
    }
}