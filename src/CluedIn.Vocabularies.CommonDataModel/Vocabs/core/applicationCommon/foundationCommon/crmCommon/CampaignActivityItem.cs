using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class CampaignActivityItemVocabulary : SimpleVocabulary
    {
        public CampaignActivityItemVocabulary()
        {
            VocabularyName = "Campaign Activity Item";
            KeyPrefix = "commonDataModel.campaignactivityitem.crmcommon";
            KeySeparator = ".";
            Grouping = "/CampaignActivityItem";

            AddGroup("CampaignActivityItem Details for CrmCommon", group =>
            {
			    CampaignActivityItemId = group.Add(new VocabularyKey(nameof(CampaignActivityItemId), "Unique identifier of the campaign activity item.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ItemObjectTypeCode = group.Add(new VocabularyKey(nameof(ItemObjectTypeCode), "Identification of the type of the campaign activity item.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningBusinessUnit = group.Add(new VocabularyKey(nameof(OwningBusinessUnit), "Unique identifier of the business unit that owns the campaign activity item.", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), "Unique identifier of the user that owns the campaign activity item.", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CampaignActivityItemId { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ItemObjectTypeCode { get; private set; }
        public VocabularyKey OwningBusinessUnit { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
    }
}