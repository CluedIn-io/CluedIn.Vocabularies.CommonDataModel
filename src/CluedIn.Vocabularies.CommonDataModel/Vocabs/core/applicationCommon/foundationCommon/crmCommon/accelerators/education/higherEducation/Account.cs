using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.HigherEducation
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.highereducation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Account;

            AddGroup("Account Details for HigherEducation", group =>
            {
			    AccountType = group.Add(new VocabularyKey(nameof(AccountType), "Account Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberofContacts = group.Add(new VocabularyKey(nameof(NumberofContacts), "# of Contacts", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PreferredSystemUserId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="AccountId"/> from Vocab 'Account.cdm.json/Account' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'Account.cdm.json/Account' with Property 'MasterId'
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
            ///Property <see cref="AccountId"/> from Vocab 'Address.cdm.json/Address' with Property 'ParentId'
            ///Property <see cref="AccountId"/> from Vocab 'CourseSection.cdm.json/CourseSection' with Property 'CampusId'
            ///Property <see cref="AccountId"/> from Vocab 'ExtraCurricularActivity.cdm.json/ExtraCurricularActivity' with Property 'SchoolId'
            ///Property <see cref="AccountId"/> from Vocab 'Grant.cdm.json/Grant' with Property 'BusinessPartnerId'
            ///Property <see cref="AccountId"/> from Vocab 'GrantApplicant.cdm.json/GrantApplicant' with Property 'BusinessPartnerId'
            ///Property <see cref="AccountId"/> from Vocab 'Internship.cdm.json/Internship' with Property 'BusinessPartnerId'
            ///Property <see cref="AccountId"/> from Vocab 'InternshipApplicant.cdm.json/InternshipApplicant' with Property 'BusinessPartnerId'
            ///Property <see cref="AccountId"/> from Vocab 'PreviousEducation.cdm.json/PreviousEducation' with Property 'SchoolNameId'
            ///Property <see cref="AccountId"/> from Vocab 'Scholarship.cdm.json/Scholarship' with Property 'BusinessPartnerId'
            ///Property <see cref="AccountId"/> from Vocab 'ScholarshipApplicant.cdm.json/ScholarshipApplicant' with Property 'BusinessPartnerId'
            #endregion
        }

        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
        public VocabularyKey NumberofContacts { get; private set; }
    }
}