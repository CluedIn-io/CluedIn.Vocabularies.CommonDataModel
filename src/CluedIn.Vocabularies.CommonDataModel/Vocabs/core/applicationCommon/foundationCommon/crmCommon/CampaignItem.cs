using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class CampaignItemVocabulary : SimpleVocabulary
    {
        public CampaignItemVocabulary()
        {
            VocabularyName = "Campaign Item";
            KeyPrefix = "commonDataModel.campaignitem";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.CampaignItem;

            AddGroup("CampaignItem Details for CrmCommon", group =>
            {
			    CampaignItemId = group.Add(new VocabularyKey(nameof(CampaignItemId), "Unique identifier of the campaign item.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityType = group.Add(new VocabularyKey(nameof(EntityType), "Object type of entity for the campaign item.", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OwningBusinessUnit = group.Add(new VocabularyKey(nameof(OwningBusinessUnit), "Unique identifier of the business unit that owns the campaign item.", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), "Unique identifier of the user that owns the campaign item.", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="OwnerId"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey CampaignItemId { get; private set; }
        public VocabularyKey EntityType { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey OwningBusinessUnit { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}