using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Banking
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.banking";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Contact;

            AddGroup("Contact Details for Banking", group =>
            {
			    BirthDate = group.Add(new VocabularyKey(nameof(BirthDate), "Date of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerTypeCode = group.Add(new VocabularyKey(nameof(CustomerTypeCode), "Relationship Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillPay = group.Add(new VocabularyKey(nameof(BillPay), "Bill Pay", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ChargeStartDate = group.Add(new VocabularyKey(nameof(ChargeStartDate), "Charge Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ChurnScore = group.Add(new VocabularyKey(nameof(ChurnScore), "Churn Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CreditScore = group.Add(new VocabularyKey(nameof(CreditScore), "Credit Score", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DebtBurdenRatio = group.Add(new VocabularyKey(nameof(DebtBurdenRatio), "Debt Burden Ratio", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DelinquencyScore = group.Add(new VocabularyKey(nameof(DelinquencyScore), "Delinquency Score", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DelinquentAmount = group.Add(new VocabularyKey(nameof(DelinquentAmount), "Delinquent Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DelinquentAmountBase = group.Add(new VocabularyKey(nameof(DelinquentAmountBase), "Delinquent Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DirectDeposit = group.Add(new VocabularyKey(nameof(DirectDeposit), "Direct Deposit", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EmploymentStatus = group.Add(new VocabularyKey(nameof(EmploymentStatus), "Employment Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IDExpiryDate = group.Add(new VocabularyKey(nameof(IDExpiryDate), "ID Expiry Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IDType = group.Add(new VocabularyKey(nameof(IDType), "ID Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsMinor = group.Add(new VocabularyKey(nameof(IsMinor), "Is Minor", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MonthlyIncome = group.Add(new VocabularyKey(nameof(MonthlyIncome), "Monthly Income", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    MonthlyIncomeBase = group.Add(new VocabularyKey(nameof(MonthlyIncomeBase), "Monthly Income (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    MonthlyLiabilities = group.Add(new VocabularyKey(nameof(MonthlyLiabilities), "Monthly Liabilities", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    MonthlyLiabilitiesBase = group.Add(new VocabularyKey(nameof(MonthlyLiabilitiesBase), "Monthly Liabilities (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PlaceOfBirth = group.Add(new VocabularyKey(nameof(PlaceOfBirth), "Place of birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfitTier = group.Add(new VocabularyKey(nameof(ProfitTier), "Profit Tier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResidencyStatus = group.Add(new VocabularyKey(nameof(ResidencyStatus), "Residency Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResidentInCountrySince = group.Add(new VocabularyKey(nameof(ResidentInCountrySince), "Resident in Country Since", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalDeposits = group.Add(new VocabularyKey(nameof(TotalDeposits), "Total Deposits", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalDepositsBase = group.Add(new VocabularyKey(nameof(TotalDepositsBase), "Total Deposits (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLoans = group.Add(new VocabularyKey(nameof(TotalLoans), "Total Loans", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLoansBase = group.Add(new VocabularyKey(nameof(TotalLoansBase), "Total Loans (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    VisaExpiry = group.Add(new VocabularyKey(nameof(VisaExpiry), "Visa Expiry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WaiveCharges = group.Add(new VocabularyKey(nameof(WaiveCharges), "Waive Charges", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="EmployerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
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
            ///Property <see cref="PreferredSystemUserId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="MasterId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="DefaultPriceLevelId"/> to Vocab '/core/applicationCommon/foundationCommon/PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="PreferredEquipmentId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/FacilityEquipment.cdm.json/FacilityEquipment' with Property 'EquipmentId'
            ///Property <see cref="PreferredServiceId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Service.cdm.json/Service' with Property 'ServiceId'
            ///Property <see cref="DefaultChargeAccountId"/> to Vocab 'FinancialProduct.cdm.json/FinancialProduct' with Property 'FinancialProductId'
            ///Property <see cref="EnrollmentBranchId"/> to Vocab 'Branch.cdm.json/Branch' with Property 'BranchId'
            ///Property <see cref="PreferredBranchId"/> to Vocab 'Branch.cdm.json/Branch' with Property 'BranchId'
            ///Property <see cref="MasterId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="MasterId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="MasterId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="MsfsiKycId"/> to Vocab 'KYC.cdm.json/KYC' with Property 'KYCId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ContactId"/> from Vocab 'Account.cdm.json/Account' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'MasterId'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Activity.cdm.json/Activity' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'MasterId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/ContactLeads.cdm.json/ContactLeads' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'EmailSender'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Fax.cdm.json/Fax' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'ParentContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Letter.cdm.json/Letter' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/MarketingListMember.cdm.json/MarketingListMember' with Property 'EntityId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/RecurringAppointment.cdm.json/RecurringAppointment' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/SocialActivity.cdm.json/SocialActivity' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthorAccount'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthor'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/ContactInvoices.cdm.json/ContactInvoices' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/ContactOrders.cdm.json/ContactOrders' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/ContactQuotes.cdm.json/ContactQuotes' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Invoice.cdm.json/Invoice' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Opportunity.cdm.json/Opportunity' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Opportunity.cdm.json/Opportunity' with Property 'ParentContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityRelationship.cdm.json/OpportunityRelationship' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Order.cdm.json/Order' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Quote.cdm.json/Quote' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ActivityParty.cdm.json/ActivityParty' with Property 'PartyId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'ResponsibleContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Contract.cdm.json/Contract' with Property 'BillingCustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Contract.cdm.json/Contract' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ContractLine.cdm.json/ContractLine' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Entitlement.cdm.json/Entitlement' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Entitlement.cdm.json/Entitlement' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/EntitlementContact.cdm.json/EntitlementContact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ServiceContractContact.cdm.json/ServiceContractContact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'Regarding'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/customerInsights/CustomerProfile.cdm.json/CustomerProfile' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/Account.cdm.json/Account' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/BookableResource.cdm.json/BookableResource' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/Contact.cdm.json/Contact' with Property 'MasterId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Activity.cdm.json/Activity' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/ActivityParty.cdm.json/ActivityParty' with Property 'PartyId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Address.cdm.json/Address' with Property 'ParentId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Contact.cdm.json/Contact' with Property 'MasterId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/CustomerRelationship.cdm.json/CustomerRelationship' with Property 'PartnerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/CustomerRelationship.cdm.json/CustomerRelationship' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Email.cdm.json/Email' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Email.cdm.json/Email' with Property 'EmailSender'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Fax.cdm.json/Fax' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Feedback.cdm.json/Feedback' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Feedback.cdm.json/Feedback' with Property 'CreatedByContact'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Feedback.cdm.json/Feedback' with Property 'CreatedOnBehalfByContact'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Letter.cdm.json/Letter' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Note.cdm.json/Note' with Property 'ObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/RecurringAppointment.cdm.json/RecurringAppointment' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'Regarding'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/SocialActivity.cdm.json/SocialActivity' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthorAccount'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthor'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/SocialProfile.cdm.json/SocialProfile' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'ParentContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/AggregateKPIContext.cdm.json/AggregateKPIContext' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/BusinessOperationCustomerPreference.cdm.json/BusinessOperationCustomerPreference' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/CustomerIdentifier.cdm.json/CustomerIdentifier' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/DealCustomer.cdm.json/DealCustomer' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/DeviceRegistration.cdm.json/DeviceRegistration' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/FinancingOpportunity.cdm.json/FinancingOpportunity' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Fleet.cdm.json/Fleet' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/FleetDevice.cdm.json/FleetDevice' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/LeadProspect.cdm.json/LeadProspect' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/SalesContract.cdm.json/SalesContract' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/ServiceAppointment.cdm.json/ServiceAppointment' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/ServiceContract.cdm.json/ServiceContract' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/ServiceOrder.cdm.json/ServiceOrder' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/TestDrive.cdm.json/TestDrive' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/TestDrive.cdm.json/TestDrive' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/TradeIn.cdm.json/TradeIn' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'ParentContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'ReferredByExtId'
            ///Property <see cref="ContactId"/> from Vocab 'CertificateOfDeposit.cdm.json/CertificateOfDeposit' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'ContactOnboardingFromProspect.cdm.json/ContactOnboardingFromProspect' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Customer360Person.cdm.json/Customer360Person' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'CustomerJourney.cdm.json/CustomerJourney' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'FinancialProduct.cdm.json/FinancialProduct' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'KYC.cdm.json/KYC' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'KYC.cdm.json/KYC' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab 'MortgageApplication.cdm.json/MortgageApplication' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Opportunity.cdm.json/Opportunity' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'Opportunity.cdm.json/Opportunity' with Property 'ParentContactId'
            #endregion
        }

        public VocabularyKey BirthDate { get; private set; }
        public VocabularyKey CustomerTypeCode { get; private set; }
        public VocabularyKey BillPay { get; private set; }
        public VocabularyKey ChargeStartDate { get; private set; }
        public VocabularyKey ChurnScore { get; private set; }
        public VocabularyKey CreditScore { get; private set; }
        public VocabularyKey DebtBurdenRatio { get; private set; }
        public VocabularyKey DelinquencyScore { get; private set; }
        public VocabularyKey DelinquentAmount { get; private set; }
        public VocabularyKey DelinquentAmountBase { get; private set; }
        public VocabularyKey DirectDeposit { get; private set; }
        public VocabularyKey EmploymentStatus { get; private set; }
        public VocabularyKey IDExpiryDate { get; private set; }
        public VocabularyKey IDType { get; private set; }
        public VocabularyKey IsMinor { get; private set; }
        public VocabularyKey MonthlyIncome { get; private set; }
        public VocabularyKey MonthlyIncomeBase { get; private set; }
        public VocabularyKey MonthlyLiabilities { get; private set; }
        public VocabularyKey MonthlyLiabilitiesBase { get; private set; }
        public VocabularyKey PlaceOfBirth { get; private set; }
        public VocabularyKey ProfitTier { get; private set; }
        public VocabularyKey ResidencyStatus { get; private set; }
        public VocabularyKey ResidentInCountrySince { get; private set; }
        public VocabularyKey TotalDeposits { get; private set; }
        public VocabularyKey TotalDepositsBase { get; private set; }
        public VocabularyKey TotalLoans { get; private set; }
        public VocabularyKey TotalLoansBase { get; private set; }
        public VocabularyKey VisaExpiry { get; private set; }
        public VocabularyKey WaiveCharges { get; private set; }
    }
}