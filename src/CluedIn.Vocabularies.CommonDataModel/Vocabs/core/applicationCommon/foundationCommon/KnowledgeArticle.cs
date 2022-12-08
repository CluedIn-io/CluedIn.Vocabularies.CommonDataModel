using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.FoundationCommon
{
    public class KnowledgeArticleVocabulary : SimpleVocabulary
    {
        public KnowledgeArticleVocabulary()
        {
            VocabularyName = "Knowledge Article";
            KeyPrefix = "commonDataModel.knowledgearticle.foundationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.KnowledgeArticle;

            AddGroup("KnowledgeArticle Details for FoundationCommon", group =>
            {
			    SetProductAssociations = group.Add(new VocabularyKey(nameof(SetProductAssociations), "Set Product Associations", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="ParentArticleContentId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="PrimaryAuthorId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="PreviousArticleContentId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="RootArticleId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="ParentArticleContentId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="PreviousArticleContentId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="RootArticleId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="KnowledgeArticleId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="KnowledgearticleId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="KnowledgearticleId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="KnowledgearticleId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'ParentArticleContentId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'PreviousArticleContentId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'RootArticleId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/Activity.cdm.json/Activity' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/ActivityParty.cdm.json/ActivityParty' with Property 'PartyId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/Email.cdm.json/Email' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/Fax.cdm.json/Fax' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/Feedback.cdm.json/Feedback' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'ParentArticleContentId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'PreviousArticleContentId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'RootArticleId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/KnowledgeArticleCategory.cdm.json/KnowledgeArticleCategory' with Property 'KnowledgeArticleId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/KnowledgeArticleViews.cdm.json/KnowledgeArticleViews' with Property 'KnowledgearticleId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/Letter.cdm.json/Letter' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/Note.cdm.json/Note' with Property 'ObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/QueueItem.cdm.json/QueueItem' with Property 'ObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/RecurringAppointment.cdm.json/RecurringAppointment' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/SocialActivity.cdm.json/SocialActivity' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/AppointmentEMR.cdm.json/AppointmentEMR' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/Activity.cdm.json/Activity' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/Email.cdm.json/Email' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/Fax.cdm.json/Fax' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/Letter.cdm.json/Letter' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/RecurringAppointment.cdm.json/RecurringAppointment' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/SocialActivity.cdm.json/SocialActivity' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/service/ActivityParty.cdm.json/ActivityParty' with Property 'PartyId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/service/KnowledgeArticleIncident.cdm.json/KnowledgeArticleIncident' with Property 'KnowledgearticleId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/service/Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/solutions/marketing/Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/solutions/marketing/Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/solutions/marketing/Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/solutions/marketing/PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/solutions/marketing/Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/solutions/portals/CaseDeflection.cdm.json/CaseDeflection' with Property 'KnowledgeArticle'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/solutions/portals/Feedback.cdm.json/Feedback' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgearticleId"/> from Vocab 'crmCommon/solutions/portals/KnowledgeArticleViews.cdm.json/KnowledgeArticleViews' with Property 'KnowledgearticleId'
            #endregion
        }

        public VocabularyKey SetProductAssociations { get; private set; }
    }
}