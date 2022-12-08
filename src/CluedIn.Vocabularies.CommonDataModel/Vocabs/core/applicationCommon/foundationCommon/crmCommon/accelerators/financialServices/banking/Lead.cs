using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Banking
{
    public class LeadVocabulary : SimpleVocabulary
    {
        public LeadVocabulary()
        {
            VocabularyName = "Lead";
            KeyPrefix = "commonDataModel.lead.banking";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Lead;

            AddGroup("Lead Details for Banking", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Entity Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Employer = group.Add(new VocabularyKey(nameof(Employer), "Employer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IDNumber = group.Add(new VocabularyKey(nameof(IDNumber), "ID Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProspectType = group.Add(new VocabularyKey(nameof(ProspectType), "Prospect Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="AccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ReferredByExtId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
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
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="MasterId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="CampaignId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="RelatedObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'ActivityId'
            ///Property <see cref="OriginatingCaseId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="QualifyingOpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="InterestedProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ReferredByInternalId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
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
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="LeadId"/> from Vocab 'Account.cdm.json/Account' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'OriginatingLeadId'
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
            ///Property <see cref="LeadId"/> from Vocab 'CompanyOnboarding.cdm.json/CompanyOnboarding' with Property 'LeadId'
            ///Property <see cref="LeadId"/> from Vocab 'ContactOnboardingFromProspect.cdm.json/ContactOnboardingFromProspect' with Property 'LeadId'
            ///Property <see cref="LeadId"/> from Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OriginatingLeadId'
            ///Property <see cref="LinkedInCampaignID"/> from Vocab 'CustomerJourney.cdm.json/CustomerJourney' with Property 'LinkedInCampaign'
            #endregion
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Employer { get; private set; }
        public VocabularyKey IDNumber { get; private set; }
        public VocabularyKey ProspectType { get; private set; }
    }
}