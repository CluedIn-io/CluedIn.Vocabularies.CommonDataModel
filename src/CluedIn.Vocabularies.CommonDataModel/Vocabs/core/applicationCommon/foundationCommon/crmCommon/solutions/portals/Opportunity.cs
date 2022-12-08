using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Portals
{
    public class OpportunityVocabulary : SimpleVocabulary
    {
        public OpportunityVocabulary()
        {
            VocabularyName = "Opportunity";
            KeyPrefix = "commonDataModel.opportunity.portals";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Opportunity;

            AddGroup("Opportunity Details for Portals", group =>
            {
			                 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="Partnerid"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PartnerContact"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="PriceLevelId"/> to Vocab '/core/applicationCommon/foundationCommon/PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="CampaignId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="OpportunityId"/> from Vocab 'InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Lead.cdm.json/Lead' with Property 'QualifyingOpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'QualifyingOpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'QualifyingOpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/AutoLeadToOpportunitySalesProcess.cdm.json/AutoLeadToOpportunitySalesProcess' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/DealFile.cdm.json/DealFile' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/LeadDisposition.cdm.json/LeadDisposition' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/TestDrive.cdm.json/TestDrive' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Invoice.cdm.json/Invoice' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityCompetitors.cdm.json/OpportunityCompetitors' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityRelationship.cdm.json/OpportunityRelationship' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Order.cdm.json/Order' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Quote.cdm.json/Quote' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            #endregion
        }

        
    }
}