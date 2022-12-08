using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Portals
{
    public class AdVocabulary : SimpleVocabulary
    {
        public AdVocabulary()
        {
            VocabularyName = "Ad";
            KeyPrefix = "commonDataModel.ad.portals";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Ad;

            AddGroup("Ad Details for Portals", group =>
            {
			    AdId = group.Add(new VocabularyKey(nameof(AdId), "Ad", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Copy = group.Add(new VocabularyKey(nameof(Copy), "Copy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), "Expiration Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Image = group.Add(new VocabularyKey(nameof(Image), "image URL", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImageAltText = group.Add(new VocabularyKey(nameof(ImageAltText), "Image Alt Text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImageHeight = group.Add(new VocabularyKey(nameof(ImageHeight), "Image Height", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ImageWidth = group.Add(new VocabularyKey(nameof(ImageWidth), "Image Width", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OpenInNewWindow = group.Add(new VocabularyKey(nameof(OpenInNewWindow), "Open In New Window", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ReleaseDate = group.Add(new VocabularyKey(nameof(ReleaseDate), "Release Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    URL = group.Add(new VocabularyKey(nameof(URL), "Redirect URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ParentId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="PublishingStateId"/> to Vocab 'PublishingState.cdm.json/PublishingState' with Property 'PublishingStateId'
            ///Property <see cref="RedirectWebFile"/> to Vocab 'WebFile.cdm.json/WebFile' with Property 'WebFileId'
            ///Property <see cref="WebFileId"/> to Vocab 'WebFile.cdm.json/WebFile' with Property 'WebFileId'
            ///Property <see cref="WebpageId"/> to Vocab 'WebPage.cdm.json/WebPage' with Property 'WebpageId'
            ///Property <see cref="WebsiteId"/> to Vocab 'Website.cdm.json/Website' with Property 'WebsiteId'
            ///Property <see cref="WebTemplateId"/> to Vocab 'WebTemplate.cdm.json/WebTemplate' with Property 'WebTemplateId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="WebsiteId"/> to Vocab 'Website.cdm.json/Website' with Property 'WebsiteId'
            ///Property <see cref="WebTemplateId"/> to Vocab 'WebTemplate.cdm.json/WebTemplate' with Property 'WebTemplateId'
            ///Property <see cref="ParentId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="AdId"/> from Vocab 'InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="AdPlacementId"/> from Vocab 'InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey AdId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Copy { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey Image { get; private set; }
        public VocabularyKey ImageAltText { get; private set; }
        public VocabularyKey ImageHeight { get; private set; }
        public VocabularyKey ImageWidth { get; private set; }
        public VocabularyKey OpenInNewWindow { get; private set; }
        public VocabularyKey ReleaseDate { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey URL { get; private set; }
    }
}