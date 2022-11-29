using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class FacilityEquipmentVocabulary : SimpleVocabulary
    {
        public FacilityEquipmentVocabulary()
        {
            VocabularyName = "Facility Equipment";
            KeyPrefix = "commonDataModel.facilityequipment.service";
            KeySeparator = ".";
            Grouping = "/FacilityEquipment";

            AddGroup("FacilityEquipment Details for Service", group =>
            {
			    EquipmentId = group.Add(new VocabularyKey(nameof(EquipmentId), "Facility/Equipment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), "Calendar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayInServiceViews = group.Add(new VocabularyKey(nameof(DisplayInServiceViews), "Display in Service Views", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Primary Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    IsDisabled = group.Add(new VocabularyKey(nameof(IsDisabled), "Is Disabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Skills = group.Add(new VocabularyKey(nameof(Skills), "Skills", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneCode = group.Add(new VocabularyKey(nameof(TimeZoneCode), "Time Zone", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EquipmentId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisplayInServiceViews { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey IsDisabled { get; private set; }
        public VocabularyKey Skills { get; private set; }
        public VocabularyKey TimeZoneCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}