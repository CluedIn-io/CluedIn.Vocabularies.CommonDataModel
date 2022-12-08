using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitForSales
{
    public class OpportunityVocabulary : SimpleVocabulary
    {
        public OpportunityVocabulary()
        {
            VocabularyName = "Opportunity";
            KeyPrefix = "commonDataModel.opportunity.nonprofitforsales";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Opportunity;

            AddGroup("Opportunity Details for NonProfitForSales", group =>
            {
			    AskReadiness = group.Add(new VocabularyKey(nameof(AskReadiness), "Ask Readiness", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedGivingAmount = group.Add(new VocabularyKey(nameof(ExpectedGivingAmount), "Expected Giving Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExpectedGivingAmount_Base = group.Add(new VocabularyKey(nameof(ExpectedGivingAmount_Base), "Expected Giving Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ProspectiveGiftType = group.Add(new VocabularyKey(nameof(ProspectiveGiftType), "Prospective Gift Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SolicitationType = group.Add(new VocabularyKey(nameof(SolicitationType), "Solicitation Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SourceCode = group.Add(new VocabularyKey(nameof(SourceCode), "Source Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="PrimaryProposalId"/> to Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'DonorCommitmentId'
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
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentContactId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PriceLevelId"/> to Vocab '/core/applicationCommon/foundationCommon/PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="Opportunity_DefaultDesignationId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Designation.cdm.json/Designation' with Property 'DesignationId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="OpportunityId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'QualifyingOpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'DesignationPlan.cdm.json/DesignationPlan' with Property 'DesignationPlan_OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'Preference.cdm.json/Preference' with Property 'Preference_OpportunityId'
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

        public VocabularyKey AskReadiness { get; private set; }
        public VocabularyKey ExpectedGivingAmount { get; private set; }
        public VocabularyKey ExpectedGivingAmount_Base { get; private set; }
        public VocabularyKey ProspectiveGiftType { get; private set; }
        public VocabularyKey SolicitationType { get; private set; }
        public VocabularyKey SourceCode { get; private set; }
    }
}