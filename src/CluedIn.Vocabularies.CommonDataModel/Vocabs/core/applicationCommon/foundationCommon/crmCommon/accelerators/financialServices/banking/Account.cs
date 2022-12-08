using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Banking
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.banking";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Account;

            AddGroup("Account Details for Banking", group =>
            {
			    AnnualReviewDate = group.Add(new VocabularyKey(nameof(AnnualReviewDate), "Annual Review Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AvailableLimit = group.Add(new VocabularyKey(nameof(AvailableLimit), "Available Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AvailableLimitBase = group.Add(new VocabularyKey(nameof(AvailableLimitBase), "Available Limit (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BanksYTDRevenue = group.Add(new VocabularyKey(nameof(BanksYTDRevenue), "Bank’s YTD Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BanksYTDRevenueBase = group.Add(new VocabularyKey(nameof(BanksYTDRevenueBase), "Bank’s YTD Revenue (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CompanysProfitInTheLastYear = group.Add(new VocabularyKey(nameof(CompanysProfitInTheLastYear), "Company’s Profit in the Last Year", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CompanysProfitInTheLastYearBase = group.Add(new VocabularyKey(nameof(CompanysProfitInTheLastYearBase), "Company’s Profit in the Last Year (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CompanyTurnoverInTheLastYear = group.Add(new VocabularyKey(nameof(CompanyTurnoverInTheLastYear), "Company Turnover in the last Year", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CompanyTurnoverInTheLastYearBase = group.Add(new VocabularyKey(nameof(CompanyTurnoverInTheLastYearBase), "Company Turnover in the last Year (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DaysPastDue = group.Add(new VocabularyKey(nameof(DaysPastDue), "Days Past Due", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ImplementedLimit = group.Add(new VocabularyKey(nameof(ImplementedLimit), "Implemented Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ImplementedLimitBase = group.Add(new VocabularyKey(nameof(ImplementedLimitBase), "Implemented Limit (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    LimitReviewDate = group.Add(new VocabularyKey(nameof(LimitReviewDate), "Limit Review Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PastDueSince = group.Add(new VocabularyKey(nameof(PastDueSince), "Past Due Since", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfitTier = group.Add(new VocabularyKey(nameof(ProfitTier), "Profit Tier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReturnOnCapital = group.Add(new VocabularyKey(nameof(ReturnOnCapital), "Return on Capital", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RiskRating = group.Add(new VocabularyKey(nameof(RiskRating), "Risk Rating", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalDeposits = group.Add(new VocabularyKey(nameof(TotalDeposits), "Total Deposits", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalDepositsBase = group.Add(new VocabularyKey(nameof(TotalDepositsBase), "Total Deposits (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLimit = group.Add(new VocabularyKey(nameof(TotalLimit), "Total Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLimitBase = group.Add(new VocabularyKey(nameof(TotalLimitBase), "Total Limit (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLoans = group.Add(new VocabularyKey(nameof(TotalLoans), "Total Loans", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLoansBase = group.Add(new VocabularyKey(nameof(TotalLoansBase), "Total Loans (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalPastDue = group.Add(new VocabularyKey(nameof(TotalPastDue), "Total Past Due", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalPastDueBase = group.Add(new VocabularyKey(nameof(TotalPastDueBase), "Total Past Due (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    UtilizedLimit = group.Add(new VocabularyKey(nameof(UtilizedLimit), "Utilized Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    UtilizedLimitBase = group.Add(new VocabularyKey(nameof(UtilizedLimitBase), "Utilized Limit (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
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
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PreferredSystemUserId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="DefaultPriceLevelId"/> to Vocab '/core/applicationCommon/foundationCommon/PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="PreferredEquipmentId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/FacilityEquipment.cdm.json/FacilityEquipment' with Property 'EquipmentId'
            ///Property <see cref="PreferredServiceId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Service.cdm.json/Service' with Property 'ServiceId'
            ///Property <see cref="TerritoryId"/> to Vocab '/core/applicationCommon/Territory.cdm.json/Territory' with Property 'TerritoryId'
            ///Property <see cref="EnrollmentBranchId"/> to Vocab 'Branch.cdm.json/Branch' with Property 'BranchId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="AccountId"/> from Vocab 'Account.cdm.json/Account' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'Account.cdm.json/Account' with Property 'MasterId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'MasterId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/AccountLeads.cdm.json/AccountLeads' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Activity.cdm.json/Activity' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'EmailSender'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Fax.cdm.json/Fax' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Letter.cdm.json/Letter' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/MarketingListMember.cdm.json/MarketingListMember' with Property 'EntityId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/RecurringAppointment.cdm.json/RecurringAppointment' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/SocialActivity.cdm.json/SocialActivity' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthorAccount'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthor'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Invoice.cdm.json/Invoice' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Opportunity.cdm.json/Opportunity' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Opportunity.cdm.json/Opportunity' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityRelationship.cdm.json/OpportunityRelationship' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Order.cdm.json/Order' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Quote.cdm.json/Quote' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ActivityParty.cdm.json/ActivityParty' with Property 'PartyId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Contract.cdm.json/Contract' with Property 'BillingCustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Contract.cdm.json/Contract' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ContractLine.cdm.json/ContractLine' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Entitlement.cdm.json/Entitlement' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Entitlement.cdm.json/Entitlement' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'Regarding'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/customerInsights/CustomerProfile.cdm.json/CustomerProfile' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/Account.cdm.json/Account' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/Account.cdm.json/Account' with Property 'MasterId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/BookableResource.cdm.json/BookableResource' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'MasterId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Activity.cdm.json/Activity' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/ActivityParty.cdm.json/ActivityParty' with Property 'PartyId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Address.cdm.json/Address' with Property 'ParentId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/CustomerRelationship.cdm.json/CustomerRelationship' with Property 'PartnerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/CustomerRelationship.cdm.json/CustomerRelationship' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Email.cdm.json/Email' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Email.cdm.json/Email' with Property 'EmailSender'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Fax.cdm.json/Fax' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Letter.cdm.json/Letter' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Note.cdm.json/Note' with Property 'ObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/RecurringAppointment.cdm.json/RecurringAppointment' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'Regarding'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/SocialActivity.cdm.json/SocialActivity' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthorAccount'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthor'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/SocialProfile.cdm.json/SocialProfile' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/AggregateKPIContext.cdm.json/AggregateKPIContext' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Business.cdm.json/Business' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/BusinessFacility.cdm.json/BusinessFacility' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/BusinessOperation.cdm.json/BusinessOperation' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/BusinessOperationCustomerPreference.cdm.json/BusinessOperationCustomerPreference' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/CustomerIdentifier.cdm.json/CustomerIdentifier' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/DealCustomer.cdm.json/DealCustomer' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/DeviceRegistration.cdm.json/DeviceRegistration' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/FinancingOpportunity.cdm.json/FinancingOpportunity' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Fleet.cdm.json/Fleet' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/SalesContract.cdm.json/SalesContract' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/SalesContractPayment.cdm.json/SalesContractPayment' with Property 'ProviderAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/ServiceAppointment.cdm.json/ServiceAppointment' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/ServiceContract.cdm.json/ServiceContract' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/ServiceContract.cdm.json/ServiceContract' with Property 'ProviderAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/ServiceOrder.cdm.json/ServiceOrder' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/ServiceOrderJobDetail.cdm.json/ServiceOrderJobDetail' with Property 'SubcontractorAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/TestDrive.cdm.json/TestDrive' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/TradeIn.cdm.json/TradeIn' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Warranty.cdm.json/Warranty' with Property 'ProviderAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'EmployerId'
            ///Property <see cref="AccountId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'BusinessCheckingAccount.cdm.json/BusinessCheckingAccount' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'CommercialDeposit.cdm.json/CommercialDeposit' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'CommercialLoan.cdm.json/CommercialLoan' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'Company360.cdm.json/Company360' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'CompanyOnboarding.cdm.json/CompanyOnboarding' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'FinancialProduct.cdm.json/FinancialProduct' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'KYC.cdm.json/KYC' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'Limit.cdm.json/Limit' with Property 'CompanyId'
            ///Property <see cref="AccountId"/> from Vocab 'RequestedFacility.cdm.json/RequestedFacility' with Property 'CompanyId'
            ///Property <see cref="AccountId"/> from Vocab 'Opportunity.cdm.json/Opportunity' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'Opportunity.cdm.json/Opportunity' with Property 'ParentAccountId'
            #endregion
        }

        public VocabularyKey AnnualReviewDate { get; private set; }
        public VocabularyKey AvailableLimit { get; private set; }
        public VocabularyKey AvailableLimitBase { get; private set; }
        public VocabularyKey BanksYTDRevenue { get; private set; }
        public VocabularyKey BanksYTDRevenueBase { get; private set; }
        public VocabularyKey CompanysProfitInTheLastYear { get; private set; }
        public VocabularyKey CompanysProfitInTheLastYearBase { get; private set; }
        public VocabularyKey CompanyTurnoverInTheLastYear { get; private set; }
        public VocabularyKey CompanyTurnoverInTheLastYearBase { get; private set; }
        public VocabularyKey DaysPastDue { get; private set; }
        public VocabularyKey ImplementedLimit { get; private set; }
        public VocabularyKey ImplementedLimitBase { get; private set; }
        public VocabularyKey LimitReviewDate { get; private set; }
        public VocabularyKey PastDueSince { get; private set; }
        public VocabularyKey ProfitTier { get; private set; }
        public VocabularyKey ReturnOnCapital { get; private set; }
        public VocabularyKey RiskRating { get; private set; }
        public VocabularyKey TotalDeposits { get; private set; }
        public VocabularyKey TotalDepositsBase { get; private set; }
        public VocabularyKey TotalLimit { get; private set; }
        public VocabularyKey TotalLimitBase { get; private set; }
        public VocabularyKey TotalLoans { get; private set; }
        public VocabularyKey TotalLoansBase { get; private set; }
        public VocabularyKey TotalPastDue { get; private set; }
        public VocabularyKey TotalPastDueBase { get; private set; }
        public VocabularyKey UtilizedLimit { get; private set; }
        public VocabularyKey UtilizedLimitBase { get; private set; }
    }
}