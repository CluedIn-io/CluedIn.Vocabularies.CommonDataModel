using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Marketing
{
    public class LeadVocabulary : SimpleVocabulary
    {
        public LeadVocabulary()
        {
            VocabularyName = "Lead";
            KeyPrefix = "commonDataModel.lead.marketing";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Lead;

            AddGroup("Lead Details for Marketing", group =>
            {
			    LeadSourceCode = group.Add(new VocabularyKey(nameof(LeadSourceCode), "Lead Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LeadSourceType = group.Add(new VocabularyKey(nameof(LeadSourceType), "Lead source type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Scores = group.Add(new VocabularyKey(nameof(Scores), "Scores", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ScoringGrade = group.Add(new VocabularyKey(nameof(ScoringGrade), "Scoring grade", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Profileid = group.Add(new VocabularyKey(nameof(Profileid), "Profile ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LeadId = group.Add(new VocabularyKey(nameof(LeadId), "Lead ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PurchaseNeed = group.Add(new VocabularyKey(nameof(PurchaseNeed), "Purchase need", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TriggerRecycle = group.Add(new VocabularyKey(nameof(TriggerRecycle), "Recycle", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Recycled = group.Add(new VocabularyKey(nameof(Recycled), "Recycled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SalesAccepted = group.Add(new VocabularyKey(nameof(SalesAccepted), "Sales accepted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SalesReady = group.Add(new VocabularyKey(nameof(SalesReady), "Sales ready", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SasToken = group.Add(new VocabularyKey(nameof(SasToken), "SAS token", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TeleProspectAccepted = group.Add(new VocabularyKey(nameof(TeleProspectAccepted), "Teleprospecting accepted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TeleProspectReady = group.Add(new VocabularyKey(nameof(TeleProspectReady), "Teleprospecting ready", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CompanySize = group.Add(new VocabularyKey(nameof(CompanySize), "Company size", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Degree = group.Add(new VocabularyKey(nameof(Degree), "Degree", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FieldOfStudy = group.Add(new VocabularyKey(nameof(FieldOfStudy), "Field of study", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GraduationDate = group.Add(new VocabularyKey(nameof(GraduationDate), "Graduation date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Industry = group.Add(new VocabularyKey(nameof(Industry), "Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    JobFunction = group.Add(new VocabularyKey(nameof(JobFunction), "Job function", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LatestFormSubmissionDate = group.Add(new VocabularyKey(nameof(LatestFormSubmissionDate), "Latest Form Submission Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    School = group.Add(new VocabularyKey(nameof(School), "School", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Seniority = group.Add(new VocabularyKey(nameof(Seniority), "Seniority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInFormSubmissions = group.Add(new VocabularyKey(nameof(LinkedInFormSubmissions), "LinkedIn Form Submissions", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="SourceCustomerJourney"/> to Vocab 'CustomerJourney.cdm.json/CustomerJourney' with Property 'CustomerJourneyId'
            ///Property <see cref="CustomerJourney"/> to Vocab 'CustomerJourney.cdm.json/CustomerJourney' with Property 'CustomerJourneyId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ParentAccountId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="MasterId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="CampaignId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="RelatedObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'ActivityId'
            ///Property <see cref="OriginatingCaseId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="QualifyingOpportunityId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OriginatingEvent"/> to Vocab 'eventManagement/Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="SourceEmail"/> to Vocab 'MarketingEmail.cdm.json/MarketingEmail' with Property 'MarketingEmailId'
            ///Property <see cref="SourceForm"/> to Vocab 'MarketingForm.cdm.json/MarketingForm' with Property 'MarketingFormId'
            ///Property <see cref="SourceLandingPage"/> to Vocab 'MarketingPage.cdm.json/MarketingPage' with Property 'MarketingPageId'
            ///Property <see cref="LinkedInCampaign"/> to Vocab 'LinkedInLeads/LinkedInCampaign.cdm.json/LinkedInCampaign' with Property 'LinkedInCampaignID'
            ///Property <see cref="SourceLinkedInForm"/> to Vocab 'LinkedInLeads/LinkedInLeadGenForm.cdm.json/LinkedInLeadGenForm' with Property 'LinkedinformId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="MasterId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="ParentId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="Lead"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="LeadId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'OriginatingLeadId'
            ///Property <see cref="LinkedInCampaignID"/> from Vocab 'CustomerJourney.cdm.json/CustomerJourney' with Property 'LinkedInCampaign'
            ///Property <see cref="LeadId"/> from Vocab 'GeoPin.cdm.json/GeoPin' with Property 'LeadGeoPinsId'
            ///Property <see cref="LeadId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'MasterId'
            ///Property <see cref="LinkedInCampaignID"/> from Vocab 'Lead.cdm.json/Lead' with Property 'LinkedInCampaign'
            ///Property <see cref="LinkedinformId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'SourceLinkedInForm'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/AccountLeads.cdm.json/AccountLeads' with Property 'LeadId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/ContactLeads.cdm.json/ContactLeads' with Property 'LeadId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'EmailSender'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'MasterId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/LeadAddress.cdm.json/LeadAddress' with Property 'ParentId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/MarketingListMember.cdm.json/MarketingListMember' with Property 'EntityId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/LeadCompetitors.cdm.json/LeadCompetitors' with Property 'LeadId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/LeadProduct.cdm.json/LeadProduct' with Property 'LeadId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Opportunity.cdm.json/Opportunity' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Account.cdm.json/Account' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Contact.cdm.json/Contact' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Opportunity.cdm.json/Opportunity' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab 'eventManagement/Account.cdm.json/Account' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab 'LinkedInLeads/LinkedInLeadGenFormSubmission.cdm.json/LinkedInLeadGenFormSubmission' with Property 'Lead'
            #endregion
        }

        public VocabularyKey LeadSourceCode { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey LeadSourceType { get; private set; }
        public VocabularyKey Scores { get; private set; }
        public VocabularyKey ScoringGrade { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey Profileid { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey LeadId { get; private set; }
        public VocabularyKey PurchaseNeed { get; private set; }
        public VocabularyKey TriggerRecycle { get; private set; }
        public VocabularyKey Recycled { get; private set; }
        public VocabularyKey SalesAccepted { get; private set; }
        public VocabularyKey SalesReady { get; private set; }
        public VocabularyKey SasToken { get; private set; }
        public VocabularyKey TeleProspectAccepted { get; private set; }
        public VocabularyKey TeleProspectReady { get; private set; }
        public VocabularyKey CompanySize { get; private set; }
        public VocabularyKey Degree { get; private set; }
        public VocabularyKey FieldOfStudy { get; private set; }
        public VocabularyKey GraduationDate { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey JobFunction { get; private set; }
        public VocabularyKey LatestFormSubmissionDate { get; private set; }
        public VocabularyKey School { get; private set; }
        public VocabularyKey Seniority { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey LinkedInFormSubmissions { get; private set; }
    }
}