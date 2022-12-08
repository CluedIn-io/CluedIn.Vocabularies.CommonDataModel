using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Marketing
{
    public class FormPageVocabulary : SimpleVocabulary
    {
        public FormPageVocabulary()
        {
            VocabularyName = "Form Page";
            KeyPrefix = "commonDataModel.formpage.marketing";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.FormPage;

            AddGroup("FormPage Details for Marketing", group =>
            {
			    FormpageId = group.Add(new VocabularyKey(nameof(FormpageId), "Form page", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ConfirmationMessage = group.Add(new VocabularyKey(nameof(ConfirmationMessage), "Confirmation message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ErrorMessage = group.Add(new VocabularyKey(nameof(ErrorMessage), "Error message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LimitExceededMessage = group.Add(new VocabularyKey(nameof(LimitExceededMessage), "Limit exceeded message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RedirectURL = group.Add(new VocabularyKey(nameof(RedirectURL), "Redirect URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Javascriptcode = group.Add(new VocabularyKey(nameof(Javascriptcode), "Javascript code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
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
            ///Property <see cref="MarketingFormId"/> to Vocab 'MarketingForm.cdm.json/MarketingForm' with Property 'MarketingFormId'
            ///Property <see cref="MarketingPage"/> to Vocab 'MarketingPage.cdm.json/MarketingPage' with Property 'MarketingPageId'
            ///Property <see cref="WebSite"/> to Vocab 'MarketingWebsite.cdm.json/MarketingWebsite' with Property 'WebsiteId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey FormpageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ConfirmationMessage { get; private set; }
        public VocabularyKey ErrorMessage { get; private set; }
        public VocabularyKey LimitExceededMessage { get; private set; }
        public VocabularyKey RedirectURL { get; private set; }
        public VocabularyKey Javascriptcode { get; private set; }
    }
}