using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Banking
{
    public class OpportunityVocabulary : SimpleVocabulary
    {
        public OpportunityVocabulary()
        {
            VocabularyName = "Opportunity";
            KeyPrefix = "commonDataModel.opportunity.banking";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Opportunity;

            AddGroup("Opportunity Details for Banking", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CostOfProperty = group.Add(new VocabularyKey(nameof(CostOfProperty), "Cost of Property", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostOfPropertyBase = group.Add(new VocabularyKey(nameof(CostOfPropertyBase), "Cost of Property (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DownPayment = group.Add(new VocabularyKey(nameof(DownPayment), "Down Payment", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DownPaymentBase = group.Add(new VocabularyKey(nameof(DownPaymentBase), "Down Payment (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InterestRate = group.Add(new VocabularyKey(nameof(InterestRate), "Interest Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PreferredFollowUpTime = group.Add(new VocabularyKey(nameof(PreferredFollowUpTime), "Preferred Follow-up Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PurposeOfLoan = group.Add(new VocabularyKey(nameof(PurposeOfLoan), "Purpose of Loan", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestedAmount = group.Add(new VocabularyKey(nameof(RequestedAmount), "Requested Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RequestedAmountBase = group.Add(new VocabularyKey(nameof(RequestedAmountBase), "Requested Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TermOfLoan = group.Add(new VocabularyKey(nameof(TermOfLoan), "Term of Loan", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
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
            ///Property <see cref="PriceLevelId"/> to Vocab '/core/applicationCommon/foundationCommon/PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="CampaignId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="OpportunityId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'QualifyingOpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'BusinessCheckingAccount.cdm.json/BusinessCheckingAccount' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'CertificateOfDeposit.cdm.json/CertificateOfDeposit' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'CommercialDeposit.cdm.json/CommercialDeposit' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'CommercialLoan.cdm.json/CommercialLoan' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'RequestedFacility.cdm.json/RequestedFacility' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'MortgageApplication.cdm.json/MortgageApplication' with Property 'OpportunityId'
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

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CostOfProperty { get; private set; }
        public VocabularyKey CostOfPropertyBase { get; private set; }
        public VocabularyKey DownPayment { get; private set; }
        public VocabularyKey DownPaymentBase { get; private set; }
        public VocabularyKey InterestRate { get; private set; }
        public VocabularyKey PreferredFollowUpTime { get; private set; }
        public VocabularyKey PurposeOfLoan { get; private set; }
        public VocabularyKey RequestedAmount { get; private set; }
        public VocabularyKey RequestedAmountBase { get; private set; }
        public VocabularyKey TermOfLoan { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}