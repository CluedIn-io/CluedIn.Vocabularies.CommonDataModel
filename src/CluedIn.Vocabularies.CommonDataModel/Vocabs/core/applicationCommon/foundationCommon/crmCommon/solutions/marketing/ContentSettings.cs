using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ContentSettingsVocabulary : SimpleVocabulary
    {
        public ContentSettingsVocabulary()
        {
            VocabularyName = "Content Settings";
            KeyPrefix = "commonDataModel.contentsettings";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ContentSettings;

            AddGroup("ContentSettings Details for Marketing", group =>
            {
			    ContentSettingsId = group.Add(new VocabularyKey(nameof(ContentSettingsId), "Content settings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), "Address Line 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressMain = group.Add(new VocabularyKey(nameof(AddressMain), "Address main", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Default = group.Add(new VocabularyKey(nameof(Default), "Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    FacebookUrl = group.Add(new VocabularyKey(nameof(FacebookUrl), "Facebook URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    ForwardToAFriend = group.Add(new VocabularyKey(nameof(ForwardToAFriend), "Forward to a friend", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInUrl = group.Add(new VocabularyKey(nameof(LinkedInUrl), "LinkedIn URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    SubscriptionCenter = group.Add(new VocabularyKey(nameof(SubscriptionCenter), "Subscription center", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TwitterUrl = group.Add(new VocabularyKey(nameof(TwitterUrl), "Twitter URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    GooglePlusUrl = group.Add(new VocabularyKey(nameof(GooglePlusUrl), "Google Plus URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    YoutubeUrl = group.Add(new VocabularyKey(nameof(YoutubeUrl), "YouTube URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ContentSettingsId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/financialServices/banking/CustomerJourney.cdm.json/CustomerJourney' with Property 'ContentSettingsId'
            ///Property <see cref="ContentSettingsId"/> from Vocab 'CustomerJourney.cdm.json/CustomerJourney' with Property 'ContentSettingsId'
            #endregion
        }

        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressMain { get; private set; }
        public VocabularyKey ContentSettingsId { get; private set; }
        public VocabularyKey Default { get; private set; }
        public VocabularyKey FacebookUrl { get; private set; }
        public VocabularyKey ForwardToAFriend { get; private set; }
        public VocabularyKey GooglePlusUrl { get; private set; }
        public VocabularyKey LinkedInUrl { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubscriptionCenter { get; private set; }
        public VocabularyKey TwitterUrl { get; private set; }
        public VocabularyKey YoutubeUrl { get; private set; }
    }
}