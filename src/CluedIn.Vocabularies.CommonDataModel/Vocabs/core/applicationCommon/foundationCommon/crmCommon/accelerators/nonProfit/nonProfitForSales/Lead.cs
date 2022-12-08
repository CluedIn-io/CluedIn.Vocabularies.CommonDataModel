using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitForSales
{
    public class LeadVocabulary : SimpleVocabulary
    {
        public LeadVocabulary()
        {
            VocabularyName = "Lead";
            KeyPrefix = "commonDataModel.lead.nonprofitforsales";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Lead;

            AddGroup("Lead Details for NonProfitForSales", group =>
            {
			    ApplicationDeadline = group.Add(new VocabularyKey(nameof(ApplicationDeadline), "Application Deadline", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedAmountRequested = group.Add(new VocabularyKey(nameof(ExpectedAmountRequested), "Expected Amount Requested", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExpectedAmountRequested_Base = group.Add(new VocabularyKey(nameof(ExpectedAmountRequested_Base), "Expected Amount Requested (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExpectedDuration = group.Add(new VocabularyKey(nameof(ExpectedDuration), "Expected Duration (Months)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ExpectedStartDate = group.Add(new VocabularyKey(nameof(ExpectedStartDate), "Expected Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsRenewal = group.Add(new VocabularyKey(nameof(IsRenewal), "Is Renewal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LetterOfIntentDeadline = group.Add(new VocabularyKey(nameof(LetterOfIntentDeadline), "Letter of Intent Deadline", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationalBudget = group.Add(new VocabularyKey(nameof(OrganizationalBudget), "Organization Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OrganizationalBudget_Base = group.Add(new VocabularyKey(nameof(OrganizationalBudget_Base), "Organization Budget (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OrganizationType = group.Add(new VocabularyKey(nameof(OrganizationType), "Organization Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestType = group.Add(new VocabularyKey(nameof(RequestType), "Request Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalProjectBudget = group.Add(new VocabularyKey(nameof(TotalProjectBudget), "Total Project Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalProjectBudget_Base = group.Add(new VocabularyKey(nameof(TotalProjectBudget_Base), "Total Project Budget (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ParentAccountId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentContactId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="MasterId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="RelatedObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'ActivityId'
            ///Property <see cref="OriginatingCaseId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="QualifyingOpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="DeliveryFrameworkId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
            ///Property <see cref="Lead_DocketId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Docket.cdm.json/Docket' with Property 'DocketId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="MasterId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="ParentId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="QualifyingOpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="QualifyingOpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="LeadId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'MasterId'
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
            ///Property <see cref="LeadId"/> from Vocab 'OfacMatch.cdm.json/OfacMatch' with Property 'InquiryId'
            ///Property <see cref="LeadId"/> from Vocab 'Recommendation.cdm.json/Recommendation' with Property 'Recommendation_LeadId'
            ///Property <see cref="LeadId"/> from Vocab 'Report.cdm.json/Report' with Property 'Report_LeadId'
            ///Property <see cref="LeadId"/> from Vocab 'Request.cdm.json/Request' with Property 'LeadId'
            ///Property <see cref="LeadId"/> from Vocab 'Review.cdm.json/Review' with Property 'Review_LeadId'
            ///Property <see cref="LeadId"/> from Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitIati/Request.cdm.json/Request' with Property 'LeadId'
            ///Property <see cref="LeadId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitIati/Opportunity.cdm.json/Opportunity' with Property 'OriginatingLeadId'
            #endregion
        }

        public VocabularyKey ApplicationDeadline { get; private set; }
        public VocabularyKey ExpectedAmountRequested { get; private set; }
        public VocabularyKey ExpectedAmountRequested_Base { get; private set; }
        public VocabularyKey ExpectedDuration { get; private set; }
        public VocabularyKey ExpectedStartDate { get; private set; }
        public VocabularyKey IsRenewal { get; private set; }
        public VocabularyKey LetterOfIntentDeadline { get; private set; }
        public VocabularyKey OrganizationalBudget { get; private set; }
        public VocabularyKey OrganizationalBudget_Base { get; private set; }
        public VocabularyKey OrganizationType { get; private set; }
        public VocabularyKey RequestType { get; private set; }
        public VocabularyKey TotalProjectBudget { get; private set; }
        public VocabularyKey TotalProjectBudget_Base { get; private set; }
    }
}