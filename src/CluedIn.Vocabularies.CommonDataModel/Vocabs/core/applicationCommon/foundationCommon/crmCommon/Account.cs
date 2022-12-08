using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.CrmCommon
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.crmcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Account;

            AddGroup("Account Details for CrmCommon", group =>
            {
			    OpenDeals = group.Add(new VocabularyKey(nameof(OpenDeals), "Open Deals", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OpenDealsDate = group.Add(new VocabularyKey(nameof(OpenDealsDate), "Open Deals (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OpenDealsState = group.Add(new VocabularyKey(nameof(OpenDealsState), "Open Deals (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OpenRevenue = group.Add(new VocabularyKey(nameof(OpenRevenue), "Open Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OpenRevenueBase = group.Add(new VocabularyKey(nameof(OpenRevenueBase), "Open Revenue (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OpenRevenueDate = group.Add(new VocabularyKey(nameof(OpenRevenueDate), "Open Revenue (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OpenRevenueState = group.Add(new VocabularyKey(nameof(OpenRevenueState), "Open Revenue (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PreferredSystemUserId"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="DefaultPriceLevelId"/> to Vocab '/core/applicationCommon/foundationCommon/PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="PreferredEquipmentId"/> to Vocab 'service/FacilityEquipment.cdm.json/FacilityEquipment' with Property 'EquipmentId'
            ///Property <see cref="PreferredServiceId"/> to Vocab 'service/Service.cdm.json/Service' with Property 'ServiceId'
            ///Property <see cref="TerritoryId"/> to Vocab '/core/applicationCommon/Territory.cdm.json/Territory' with Property 'TerritoryId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="AccountId"/> from Vocab 'Account.cdm.json/Account' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'Account.cdm.json/Account' with Property 'MasterId'
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
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/Lead.cdm.json/Lead' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/Lead.cdm.json/Lead' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/AggregateKPIContext.cdm.json/AggregateKPIContext' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/Business.cdm.json/Business' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/BusinessFacility.cdm.json/BusinessFacility' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/BusinessOperation.cdm.json/BusinessOperation' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/BusinessOperationCustomerPreference.cdm.json/BusinessOperationCustomerPreference' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/CustomerIdentifier.cdm.json/CustomerIdentifier' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/DealCustomer.cdm.json/DealCustomer' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/DeviceRegistration.cdm.json/DeviceRegistration' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/FinancingOpportunity.cdm.json/FinancingOpportunity' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/Fleet.cdm.json/Fleet' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/SalesContract.cdm.json/SalesContract' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/SalesContractPayment.cdm.json/SalesContractPayment' with Property 'ProviderAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/ServiceAppointment.cdm.json/ServiceAppointment' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/ServiceContract.cdm.json/ServiceContract' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/ServiceContract.cdm.json/ServiceContract' with Property 'ProviderAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/ServiceOrder.cdm.json/ServiceOrder' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/ServiceOrderJobDetail.cdm.json/ServiceOrderJobDetail' with Property 'SubcontractorAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/TestDrive.cdm.json/TestDrive' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/TradeIn.cdm.json/TradeIn' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'accelerators/automotive/Warranty.cdm.json/Warranty' with Property 'ProviderAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'AccountLeads.cdm.json/AccountLeads' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'Activity.cdm.json/Activity' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'Email.cdm.json/Email' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'Email.cdm.json/Email' with Property 'EmailSender'
            ///Property <see cref="AccountId"/> from Vocab 'Fax.cdm.json/Fax' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'Letter.cdm.json/Letter' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'MarketingListMember.cdm.json/MarketingListMember' with Property 'EntityId'
            ///Property <see cref="AccountId"/> from Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'RecurringAppointment.cdm.json/RecurringAppointment' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthorAccount'
            ///Property <see cref="AccountId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthor'
            ///Property <see cref="AccountId"/> from Vocab 'sales/Invoice.cdm.json/Invoice' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'sales/Opportunity.cdm.json/Opportunity' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'sales/Opportunity.cdm.json/Opportunity' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'sales/OpportunityRelationship.cdm.json/OpportunityRelationship' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'sales/Order.cdm.json/Order' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'sales/Quote.cdm.json/Quote' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'service/ActivityParty.cdm.json/ActivityParty' with Property 'PartyId'
            ///Property <see cref="AccountId"/> from Vocab 'service/Case.cdm.json/Case' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'service/Contract.cdm.json/Contract' with Property 'BillingCustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'service/Contract.cdm.json/Contract' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'service/ContractLine.cdm.json/ContractLine' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'service/Entitlement.cdm.json/Entitlement' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'service/Entitlement.cdm.json/Entitlement' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'service/SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'Regarding'
            ///Property <see cref="AccountId"/> from Vocab 'service/Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'solutions/customerInsights/CustomerProfile.cdm.json/CustomerProfile' with Property 'CustomerId'
            #endregion
        }

        public VocabularyKey OpenDeals { get; private set; }
        public VocabularyKey OpenDealsDate { get; private set; }
        public VocabularyKey OpenDealsState { get; private set; }
        public VocabularyKey OpenRevenue { get; private set; }
        public VocabularyKey OpenRevenueBase { get; private set; }
        public VocabularyKey OpenRevenueDate { get; private set; }
        public VocabularyKey OpenRevenueState { get; private set; }
    }
}