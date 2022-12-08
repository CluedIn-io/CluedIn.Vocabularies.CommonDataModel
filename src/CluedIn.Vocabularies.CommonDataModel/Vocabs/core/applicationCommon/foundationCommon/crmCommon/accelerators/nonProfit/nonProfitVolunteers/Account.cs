using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitVolunteers
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.nonprofitvolunteers";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Account;

            AddGroup("Account Details for NonProfitVolunteers", group =>
            {
			    AccountType = group.Add(new VocabularyKey(nameof(AccountType), "Account Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AcquisitionDate = group.Add(new VocabularyKey(nameof(AcquisitionDate), "Acquisition Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AcquisitionSource = group.Add(new VocabularyKey(nameof(AcquisitionSource), "Acquisition Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryConstituentType = group.Add(new VocabularyKey(nameof(PrimaryConstituentType), "Primary Constituent Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
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
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="AccountId"/> from Vocab 'Account.cdm.json/Account' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'Account.cdm.json/Account' with Property 'MasterId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'MasterId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Address.cdm.json/Address' with Property 'ParentId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Award.cdm.json/Award' with Property 'FiscalSponsorId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Award.cdm.json/Award' with Property 'RecipientId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/BenefitRecipient.cdm.json/BenefitRecipient' with Property 'BeneficiaryId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/CreditPlan.cdm.json/CreditPlan' with Property 'CreditPlanAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/CreditPlanRecipient.cdm.json/CreditPlanRecipient' with Property 'CreditPlanRecipientCustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/DeliveryFramework.cdm.json/DeliveryFramework' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DonorId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Disbursement.cdm.json/Disbursement' with Property 'RecipientAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Docket.cdm.json/Docket' with Property 'AwardRecipientId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Docket.cdm.json/Docket' with Property 'DocketFiscalSponsorId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/DonorCommitment.cdm.json/DonorCommitment' with Property 'PledgedByAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/DonorCommitment.cdm.json/DonorCommitment' with Property 'PledgedOnAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Education.cdm.json/Education' with Property 'DepartmentOrCollegeId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Education.cdm.json/Education' with Property 'InstitutionId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/EmploymentHistory.cdm.json/EmploymentHistory' with Property 'EmployerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Membership.cdm.json/Membership' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Need.cdm.json/Need' with Property 'BeneficiaryId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Objective.cdm.json/Objective' with Property 'ObjectiveAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/OfacMatch.cdm.json/OfacMatch' with Property 'OfacMatchCustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/PaymentMethod.cdm.json/PaymentMethod' with Property 'PayorId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/PaymentSchedule.cdm.json/PaymentSchedule' with Property 'OmtSchedDefaultHardCreditToCustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/PaymentSchedule.cdm.json/PaymentSchedule' with Property 'ReceiptOnAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/PlannedGiving.cdm.json/PlannedGiving' with Property 'FundId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/PlannedGiving.cdm.json/PlannedGiving' with Property 'PledgesOnAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Preference.cdm.json/Preference' with Property 'PreferenceCustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Recommendation.cdm.json/Recommendation' with Property 'RecommenderAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Report.cdm.json/Report' with Property 'ReportAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Request.cdm.json/Request' with Property 'FiscalSponsorId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Request.cdm.json/Request' with Property 'RecipientId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Salutation.cdm.json/Salutation' with Property 'SalutationCustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Stakeholder.cdm.json/Stakeholder' with Property 'StakeholderNameId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Transaction.cdm.json/Transaction' with Property 'TransactionReceiptOnAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/WorkItem.cdm.json/WorkItem' with Property 'BeneficiaryId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/WorkItemAction.cdm.json/WorkItemAction' with Property 'BeneficiaryId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/WorkItemAction.cdm.json/WorkItemAction' with Property 'ReferralToId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitMeasurement/DeliveryFramework.cdm.json/DeliveryFramework' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitMeasurement/DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DonorId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/CreditPlan.cdm.json/CreditPlan' with Property 'CreditPlanAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/DonorCommitment.cdm.json/DonorCommitment' with Property 'PledgedByAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/DonorCommitment.cdm.json/DonorCommitment' with Property 'PledgedOnAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/OfacMatch.cdm.json/OfacMatch' with Property 'OfacMatchCustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/PlannedGiving.cdm.json/PlannedGiving' with Property 'FundId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/PlannedGiving.cdm.json/PlannedGiving' with Property 'PledgesOnAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Preference.cdm.json/Preference' with Property 'PreferenceCustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Recommendation.cdm.json/Recommendation' with Property 'RecommenderAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Report.cdm.json/Report' with Property 'ReportAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Request.cdm.json/Request' with Property 'FiscalSponsorId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Request.cdm.json/Request' with Property 'RecipientId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Transaction.cdm.json/Transaction' with Property 'TransactionReceiptOnAccountId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Opportunity.cdm.json/Opportunity' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Opportunity.cdm.json/Opportunity' with Property 'ParentAccountId'
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
            ///Property <see cref="AccountId"/> from Vocab 'Project.cdm.json/Project' with Property 'Customer'
            #endregion
        }

        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey AcquisitionDate { get; private set; }
        public VocabularyKey AcquisitionSource { get; private set; }
        public VocabularyKey PrimaryConstituentType { get; private set; }
    }
}