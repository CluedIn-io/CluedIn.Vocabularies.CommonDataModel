using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Account;

            AddGroup("Account Details for ElectronicMedicalRecords", group =>
            {
			    AccountType = group.Add(new VocabularyKey(nameof(AccountType), "Account Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PeriodEndDate = group.Add(new VocabularyKey(nameof(Address1PeriodEndDate), "Primary - Primary End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PeriodStartDate = group.Add(new VocabularyKey(nameof(Address1PeriodStartDate), "Primary - Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PeriodEndDate = group.Add(new VocabularyKey(nameof(Address2PeriodEndDate), "Secondary  - Address Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PeriodStartDate = group.Add(new VocabularyKey(nameof(Address2PeriodStartDate), "Secondary  - Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Alias = group.Add(new VocabularyKey(nameof(Alias), "DBA", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1EndDate = group.Add(new VocabularyKey(nameof(Telecom1EndDate), "Primary Phone End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1Rank = group.Add(new VocabularyKey(nameof(Telecom1Rank), "Rank Of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom1StartDate = group.Add(new VocabularyKey(nameof(Telecom1StartDate), "Primary Phone Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1System = group.Add(new VocabularyKey(nameof(Telecom1System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1Use = group.Add(new VocabularyKey(nameof(Telecom1Use), "Use Of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2EndDate = group.Add(new VocabularyKey(nameof(Telecom2EndDate), "Secondary Phone End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2Rank = group.Add(new VocabularyKey(nameof(Telecom2Rank), "Rank Of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom2StartDate = group.Add(new VocabularyKey(nameof(Telecom2StartDate), "Secondary Phone Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2System = group.Add(new VocabularyKey(nameof(Telecom2System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2Use = group.Add(new VocabularyKey(nameof(Telecom2Use), "Use Of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3EndDate = group.Add(new VocabularyKey(nameof(Telecom3EndDate), "Primary Email End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3Rank = group.Add(new VocabularyKey(nameof(Telecom3Rank), "Rank Of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom3StartDate = group.Add(new VocabularyKey(nameof(Telecom3StartDate), "Primary Email Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3System = group.Add(new VocabularyKey(nameof(Telecom3System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3Use = group.Add(new VocabularyKey(nameof(Telecom3Use), "Use Of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
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
            ///Property <see cref="Contact1PuroposeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="Contact2Id"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Contact2PuroposeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
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
            ///Property <see cref="AccountId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="EncounterId"/> to Vocab 'Encounter.cdm.json/Encounter' with Property 'EncounterId'
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
            ///Property <see cref="EpisodeOfCareId"/> to Vocab 'EpisodeOfCare.cdm.json/EpisodeOfCare' with Property 'EpisodeOfCareId'
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
            ///Property <see cref="AccountId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'ManagingOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'Qualification1IssuerId'
            ///Property <see cref="AccountId"/> from Vocab 'Address.cdm.json/Address' with Property 'ParentId'
            ///Property <see cref="AccountId"/> from Vocab 'AppointmentEMR.cdm.json/AppointmentEMR' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'CarePlanActivityPerformer.cdm.json/CarePlanActivityPerformer' with Property 'PerformerTypeOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'CarePlanAuthor.cdm.json/CarePlanAuthor' with Property 'PlanAuthorOrgazniationIdentifierId'
            ///Property <see cref="AccountId"/> from Vocab 'CareTeamManagingOrganization.cdm.json/CareTeamManagingOrganization' with Property 'OrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'CareTeamParticipant.cdm.json/CareTeamParticipant' with Property 'MemberOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'CareTeamParticipant.cdm.json/CareTeamParticipant' with Property 'OnBehalfOfId'
            ///Property <see cref="AccountId"/> from Vocab 'CommunicationRequest.cdm.json/CommunicationRequest' with Property 'RequesterAgentOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'CommunicationRequest.cdm.json/CommunicationRequest' with Property 'RequesterOnBehalfOfId'
            ///Property <see cref="AccountId"/> from Vocab 'CommunicationRequest.cdm.json/CommunicationRequest' with Property 'SenderOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'CommunicationRequestRecipient.cdm.json/CommunicationRequestRecipient' with Property 'RecipientOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'PerformerTypeOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'RequesterAgentTypeOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'RequesterOnBehalfOfId'
            ///Property <see cref="AccountId"/> from Vocab 'Encounter.cdm.json/Encounter' with Property 'OnBehalfOfId'
            ///Property <see cref="AccountId"/> from Vocab 'Endpoint.cdm.json/Endpoint' with Property 'ManagingOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'EpisodeOfCare.cdm.json/EpisodeOfCare' with Property 'OrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'Goal.cdm.json/Goal' with Property 'GoalSubjectOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'ProvidedById'
            ///Property <see cref="AccountId"/> from Vocab 'Location.cdm.json/Location' with Property 'ManagingOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'MedicalIdentifier.cdm.json/MedicalIdentifier' with Property 'AssignerId'
            ///Property <see cref="AccountId"/> from Vocab 'Medication.cdm.json/Medication' with Property 'ManufacturerId'
            ///Property <see cref="AccountId"/> from Vocab 'MedicationAdministrationPerformer.cdm.json/MedicationAdministrationPerformer' with Property 'PerfomerOnBehalfOfId'
            ///Property <see cref="AccountId"/> from Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'DispenseRequestPerformerId'
            ///Property <see cref="AccountId"/> from Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'RequesterAgentTypeOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'RequesterOnBehalfOfId'
            ///Property <see cref="AccountId"/> from Vocab 'ObservationPerformer.cdm.json/ObservationPerformer' with Property 'ObsPerformerOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'PractitionerQualification.cdm.json/PractitionerQualification' with Property 'IssuerId'
            ///Property <see cref="AccountId"/> from Vocab 'PractitionerRole.cdm.json/PractitionerRole' with Property 'OrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'ProcedurePerformer.cdm.json/ProcedurePerformer' with Property 'PerformerActorOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'ProcedurePerformer.cdm.json/ProcedurePerformer' with Property 'PerformerOnBehalfOfId'
            ///Property <see cref="AccountId"/> from Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'PerformerAgentOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'RequesterAgentOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'RequesterOnBehalfOfId'
            ///Property <see cref="AccountId"/> from Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'RequesterAgentOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'RequesterOnBehalfOfId'
            ///Property <see cref="AccountId"/> from Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'RequestorId'
            ///Property <see cref="AccountId"/> from Vocab 'ReferralRequestRecipient.cdm.json/ReferralRequestRecipient' with Property 'RecipientOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'TaskRestrictionRecipient.cdm.json/TaskRestrictionRecipient' with Property 'RestrictionRecipientOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'Task.cdm.json/Task' with Property 'PerformerOwnerOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'Task.cdm.json/Task' with Property 'RequesterAgentOrganizationId'
            ///Property <see cref="AccountId"/> from Vocab 'Task.cdm.json/Task' with Property 'RequesterOnBehalfOfId'
            #endregion
        }

        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey Address1PeriodEndDate { get; private set; }
        public VocabularyKey Address1PeriodStartDate { get; private set; }
        public VocabularyKey Address2PeriodEndDate { get; private set; }
        public VocabularyKey Address2PeriodStartDate { get; private set; }
        public VocabularyKey Alias { get; private set; }
        public VocabularyKey Telecom1EndDate { get; private set; }
        public VocabularyKey Telecom1Rank { get; private set; }
        public VocabularyKey Telecom1StartDate { get; private set; }
        public VocabularyKey Telecom1System { get; private set; }
        public VocabularyKey Telecom1Use { get; private set; }
        public VocabularyKey Telecom2EndDate { get; private set; }
        public VocabularyKey Telecom2Rank { get; private set; }
        public VocabularyKey Telecom2StartDate { get; private set; }
        public VocabularyKey Telecom2System { get; private set; }
        public VocabularyKey Telecom2Use { get; private set; }
        public VocabularyKey Telecom3EndDate { get; private set; }
        public VocabularyKey Telecom3Rank { get; private set; }
        public VocabularyKey Telecom3StartDate { get; private set; }
        public VocabularyKey Telecom3System { get; private set; }
        public VocabularyKey Telecom3Use { get; private set; }
    }
}