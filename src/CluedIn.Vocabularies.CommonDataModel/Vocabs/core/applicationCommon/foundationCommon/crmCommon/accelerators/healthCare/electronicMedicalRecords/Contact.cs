using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Contact;

            AddGroup("Contact Details for ElectronicMedicalRecords", group =>
            {
			    FamilyStatusCode = group.Add(new VocabularyKey(nameof(FamilyStatusCode), "Marital Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GenderCode = group.Add(new VocabularyKey(nameof(GenderCode), "Gender", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityStartDate = group.Add(new VocabularyKey(nameof(ActivityStartDate), "Activity Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PeriodEndDate = group.Add(new VocabularyKey(nameof(Address1PeriodEndDate), "Permanent - Address Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PeriodStartDate = group.Add(new VocabularyKey(nameof(Address1PeriodStartDate), "Permanent- Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PeriodEndDate = group.Add(new VocabularyKey(nameof(Address2PeriodEndDate), "Current - Address Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PeriodStartDate = group.Add(new VocabularyKey(nameof(Address2PeriodStartDate), "Current - Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address3PeriodEndDate = group.Add(new VocabularyKey(nameof(Address3PeriodEndDate), "Billing  - Address Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address3PeriodStartDate = group.Add(new VocabularyKey(nameof(Address3PeriodStartDate), "Billing  - Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Animal = group.Add(new VocabularyKey(nameof(Animal), "Animal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Communication1Preferred = group.Add(new VocabularyKey(nameof(Communication1Preferred), "Primary Language Preferred", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Communication2Preferred = group.Add(new VocabularyKey(nameof(Communication2Preferred), "Secondary Language Preferred", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Contac1tEndDate = group.Add(new VocabularyKey(nameof(Contac1tEndDate), "Emergency Contact End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Contac2tEndDate = group.Add(new VocabularyKey(nameof(Contac2tEndDate), "Primary Contact End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Contact1StartDate = group.Add(new VocabularyKey(nameof(Contact1StartDate), "Emergency Contact Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Contact2StartDate = group.Add(new VocabularyKey(nameof(Contact2StartDate), "Primary Contact Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactType = group.Add(new VocabularyKey(nameof(ContactType), "Contact Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeceasedDate = group.Add(new VocabularyKey(nameof(DeceasedDate), "Deceased Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicalRecordNumber = group.Add(new VocabularyKey(nameof(MedicalRecordNumber), "Medical Record Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MultipleBirth = group.Add(new VocabularyKey(nameof(MultipleBirth), "Multiple Birth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name1EndDate = group.Add(new VocabularyKey(nameof(Name1EndDate), "Usual-Name End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name1StartDate = group.Add(new VocabularyKey(nameof(Name1StartDate), "Usual-Name Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name1Use = group.Add(new VocabularyKey(nameof(Name1Use), "Use of Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2 = group.Add(new VocabularyKey(nameof(Name2), "Official Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2EndDate = group.Add(new VocabularyKey(nameof(Name2EndDate), "Official-Name End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2FamilyName = group.Add(new VocabularyKey(nameof(Name2FamilyName), "Official- Family Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2GivenName = group.Add(new VocabularyKey(nameof(Name2GivenName), "Official - Given Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2Prefix = group.Add(new VocabularyKey(nameof(Name2Prefix), "Official- Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2StartDate = group.Add(new VocabularyKey(nameof(Name2StartDate), "Official-Name Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2Suffix = group.Add(new VocabularyKey(nameof(Name2Suffix), "Official- Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2Use = group.Add(new VocabularyKey(nameof(Name2Use), "Use of Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3 = group.Add(new VocabularyKey(nameof(Name3), "Temporary Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3FamilyName = group.Add(new VocabularyKey(nameof(Name3FamilyName), "Official- Family Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3GivenName = group.Add(new VocabularyKey(nameof(Name3GivenName), "Official - Given Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3NameEndDate = group.Add(new VocabularyKey(nameof(Name3NameEndDate), "Official-Name End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3NameStartDate = group.Add(new VocabularyKey(nameof(Name3NameStartDate), "Official-Name Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3Prefix = group.Add(new VocabularyKey(nameof(Name3Prefix), "Official- Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3Suffix = group.Add(new VocabularyKey(nameof(Name3Suffix), "Official- Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3Use = group.Add(new VocabularyKey(nameof(Name3Use), "Use of Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Qualification1Identifier = group.Add(new VocabularyKey(nameof(Qualification1Identifier), "Provider NPI Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Qualification1PeriodEndDate = group.Add(new VocabularyKey(nameof(Qualification1PeriodEndDate), "Qualification Expiry Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Qualification1PeriodStartDate = group.Add(new VocabularyKey(nameof(Qualification1PeriodStartDate), "Qualification Issue Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1EndDate = group.Add(new VocabularyKey(nameof(Telecom1EndDate), "Primary Day Time Phone End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1Rank = group.Add(new VocabularyKey(nameof(Telecom1Rank), "Rank of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom1StartDate = group.Add(new VocabularyKey(nameof(Telecom1StartDate), "Primary Day Time Phone Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1System = group.Add(new VocabularyKey(nameof(Telecom1System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1Use = group.Add(new VocabularyKey(nameof(Telecom1Use), "Use of contact point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2EndDate = group.Add(new VocabularyKey(nameof(Telecom2EndDate), "Primary Evening Phone End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2Rank = group.Add(new VocabularyKey(nameof(Telecom2Rank), "Rank of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom2StartDate = group.Add(new VocabularyKey(nameof(Telecom2StartDate), "Primary Evening Phone Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2System = group.Add(new VocabularyKey(nameof(Telecom2System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2Use = group.Add(new VocabularyKey(nameof(Telecom2Use), "Use of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3EndDate = group.Add(new VocabularyKey(nameof(Telecom3EndDate), "Primary Email End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3Rank = group.Add(new VocabularyKey(nameof(Telecom3Rank), "Rank of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom3StartDate = group.Add(new VocabularyKey(nameof(Telecom3StartDate), "Primary Email Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3System = group.Add(new VocabularyKey(nameof(Telecom3System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3Use = group.Add(new VocabularyKey(nameof(Telecom3Use), "Use of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ManagingOrganizationId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="Qualification1IssuerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
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
            ///Property <see cref="AnimalBreedId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="AnimalGenderStatusId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="AnimalSpeciesId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="Communication1LanguageId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="Communication2LanguageId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="Contact1Id"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Contact1RelationshipId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="Contact2Id"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Contact2RelationshipId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="GeneralPractionerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Link1Id"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Link1TypeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="Link2Id"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Link2TypeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="MasterId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="LinkId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ActivityDefinitionId"/> to Vocab 'ActivityDefinition.cdm.json/ActivityDefinition' with Property 'IdentifiesspecifictimeswhentheeventoccuId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="ActivityContributorId"/> to Vocab 'ActivityDefinitionContributor.cdm.json/ActivityDefinitionContributor' with Property 'ActivityDefinitionContributorId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="LinkTypeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
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
            ///Property <see cref="DeviceIdentifierId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
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
            ///Property <see cref="EndpointId"/> to Vocab 'Endpoint.cdm.json/Endpoint' with Property 'EndpointId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="PlanContributorId"/> to Vocab 'PlanDefinitionContributor.cdm.json/PlanDefinitionContributor' with Property 'PlanDefinitionContributorId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ContactId"/> from Vocab 'Account.cdm.json/Account' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Account.cdm.json/Account' with Property 'Contact2Id'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'MasterId'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'Contact1Id'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'Contact2Id'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'GeneralPractionerId'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'Link1Id'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'Link2Id'
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
            ///Property <see cref="ContactId"/> from Vocab 'Address.cdm.json/Address' with Property 'ParentId'
            ///Property <see cref="ContactId"/> from Vocab 'ActivityDefinitionContact.cdm.json/ActivityDefinitionContact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'ActivityDefinitionContributorContact.cdm.json/ActivityDefinitionContributorContact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'AdditionalName.cdm.json/AdditionalName' with Property 'PatientId'
            ///Property <see cref="ContactId"/> from Vocab 'AllergyIntolerance.cdm.json/AllergyIntolerance' with Property 'PatientId'
            ///Property <see cref="ContactId"/> from Vocab 'AppointmentEMR.cdm.json/AppointmentEMR' with Property 'ActorPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'AppointmentEMR.cdm.json/AppointmentEMR' with Property 'ActorPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'AppointmentEMR.cdm.json/AppointmentEMR' with Property 'ActorRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'AppointmentEMR.cdm.json/AppointmentEMR' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'AppointmentEMRParticipant.cdm.json/AppointmentEMRParticipant' with Property 'ActorPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'AppointmentEMRParticipant.cdm.json/AppointmentEMRParticipant' with Property 'ActorPhysicianId'
            ///Property <see cref="ContactId"/> from Vocab 'AppointmentEMRParticipant.cdm.json/AppointmentEMRParticipant' with Property 'ActorRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'CarePlan.cdm.json/CarePlan' with Property 'PatientIdentifierId'
            ///Property <see cref="ContactId"/> from Vocab 'CarePlanActivityPerformer.cdm.json/CarePlanActivityPerformer' with Property 'PerformerTypePatientId'
            ///Property <see cref="ContactId"/> from Vocab 'CarePlanActivityPerformer.cdm.json/CarePlanActivityPerformer' with Property 'PerformerTypePractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'CarePlanActivityPerformer.cdm.json/CarePlanActivityPerformer' with Property 'PerformerTypeRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'CarePlanAuthor.cdm.json/CarePlanAuthor' with Property 'PlanAuthorPatientIdentifierId'
            ///Property <see cref="ContactId"/> from Vocab 'CarePlanAuthor.cdm.json/CarePlanAuthor' with Property 'PlanAuthorPractitionerIdentifierId'
            ///Property <see cref="ContactId"/> from Vocab 'CarePlanAuthor.cdm.json/CarePlanAuthor' with Property 'PlanAuthorRelatedPersonIdentifierId'
            ///Property <see cref="ContactId"/> from Vocab 'CareTeam.cdm.json/CareTeam' with Property 'SubjectPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'CareTeamParticipant.cdm.json/CareTeamParticipant' with Property 'MemberPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'CareTeamParticipant.cdm.json/CareTeamParticipant' with Property 'MemberPractionerId'
            ///Property <see cref="ContactId"/> from Vocab 'CareTeamParticipant.cdm.json/CareTeamParticipant' with Property 'MemberRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'ClinicalImpression.cdm.json/ClinicalImpression' with Property 'AssessorId'
            ///Property <see cref="ContactId"/> from Vocab 'ClinicalImpression.cdm.json/ClinicalImpression' with Property 'SubjectPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'Communication.cdm.json/Communication' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'CommunicationRequest.cdm.json/CommunicationRequest' with Property 'LookupId'
            ///Property <see cref="ContactId"/> from Vocab 'CommunicationRequest.cdm.json/CommunicationRequest' with Property 'RequesterAgentPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'CommunicationRequest.cdm.json/CommunicationRequest' with Property 'RequesterAgentRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'CommunicationRequest.cdm.json/CommunicationRequest' with Property 'SenderPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'CommunicationRequest.cdm.json/CommunicationRequest' with Property 'SenderPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'CommunicationRequest.cdm.json/CommunicationRequest' with Property 'SenderRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'CommunicationRequest.cdm.json/CommunicationRequest' with Property 'SubjectPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'CommunicationRequestRecipient.cdm.json/CommunicationRequestRecipient' with Property 'RecipientPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'CommunicationRequestRecipient.cdm.json/CommunicationRequestRecipient' with Property 'RecipientPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'CommunicationRequestRecipient.cdm.json/CommunicationRequestRecipient' with Property 'RecipientRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'Condition.cdm.json/Condition' with Property 'AsserterId'
            ///Property <see cref="ContactId"/> from Vocab 'Condition.cdm.json/Condition' with Property 'PractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'Condition.cdm.json/Condition' with Property 'SubjectTypePatientId'
            ///Property <see cref="ContactId"/> from Vocab 'ContactLink.cdm.json/ContactLink' with Property 'LinkId'
            ///Property <see cref="ContactId"/> from Vocab 'ContactLink.cdm.json/ContactLink' with Property 'PatientId'
            ///Property <see cref="ContactId"/> from Vocab 'Device.cdm.json/Device' with Property 'PatientId'
            ///Property <see cref="ContactId"/> from Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'PerformerTypePatientId'
            ///Property <see cref="ContactId"/> from Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'PerformerTypePractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'PerformerTypeRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'RequesterAgentTypePractitonerId'
            ///Property <see cref="ContactId"/> from Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'SubjectTypePatientId'
            ///Property <see cref="ContactId"/> from Vocab 'Encounter.cdm.json/Encounter' with Property 'EncounterPatientIdentifierId'
            ///Property <see cref="ContactId"/> from Vocab 'Encounter.cdm.json/Encounter' with Property 'SubjectPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'EncounterParticipant.cdm.json/EncounterParticipant' with Property 'EncounterParticipantsId'
            ///Property <see cref="ContactId"/> from Vocab 'EncounterParticipant.cdm.json/EncounterParticipant' with Property 'IndividualTypePractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'EncounterParticipant.cdm.json/EncounterParticipant' with Property 'IndividualTypeRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'EpisodeOfCare.cdm.json/EpisodeOfCare' with Property 'CareManagerId'
            ///Property <see cref="ContactId"/> from Vocab 'EpisodeOfCare.cdm.json/EpisodeOfCare' with Property 'PatientId'
            ///Property <see cref="ContactId"/> from Vocab 'FamilyMemberHistory.cdm.json/FamilyMemberHistory' with Property 'PatientId'
            ///Property <see cref="ContactId"/> from Vocab 'Goal.cdm.json/Goal' with Property 'GoalExpressedByPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'Goal.cdm.json/Goal' with Property 'GoalExpressedByPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'Goal.cdm.json/Goal' with Property 'GoalExpressedByRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'Goal.cdm.json/Goal' with Property 'GoalSubjectPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'MedicalIdentifier.cdm.json/MedicalIdentifier' with Property 'AssigneeId'
            ///Property <see cref="ContactId"/> from Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'SubjectTypePatientId'
            ///Property <see cref="ContactId"/> from Vocab 'MedicationAdministrationPerformer.cdm.json/MedicationAdministrationPerformer' with Property 'PerformerActorTypePatientId'
            ///Property <see cref="ContactId"/> from Vocab 'MedicationAdministrationPerformer.cdm.json/MedicationAdministrationPerformer' with Property 'PerformerActorTypePractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'MedicationAdministrationPerformer.cdm.json/MedicationAdministrationPerformer' with Property 'PerformerActorTypeRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'RecorderId'
            ///Property <see cref="ContactId"/> from Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'RequesterAgentTypePatientId'
            ///Property <see cref="ContactId"/> from Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'RequesterAgentTypePractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'RequesterAgentTypeRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'SubjectTypePatientId'
            ///Property <see cref="ContactId"/> from Vocab 'NutritionOrder.cdm.json/NutritionOrder' with Property 'OrdererId'
            ///Property <see cref="ContactId"/> from Vocab 'NutritionOrder.cdm.json/NutritionOrder' with Property 'PatientId'
            ///Property <see cref="ContactId"/> from Vocab 'Observation.cdm.json/Observation' with Property 'SubjectTypePatientId'
            ///Property <see cref="ContactId"/> from Vocab 'ObservationPerformer.cdm.json/ObservationPerformer' with Property 'ObsPerformerPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'ObservationPerformer.cdm.json/ObservationPerformer' with Property 'ObsPerformerPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'ObservationPerformer.cdm.json/ObservationPerformer' with Property 'ObsPerformerRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'PlanDefinitionContributorContact.cdm.json/PlanDefinitionContributorContact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'PractitionerQualification.cdm.json/PractitionerQualification' with Property 'PractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'PractitionerRole.cdm.json/PractitionerRole' with Property 'PractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'Procedure.cdm.json/Procedure' with Property 'PatientId'
            ///Property <see cref="ContactId"/> from Vocab 'ProcedurePerformer.cdm.json/ProcedurePerformer' with Property 'PerformerActorPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'ProcedurePerformer.cdm.json/ProcedurePerformer' with Property 'PerformerActorPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'ProcedurePerformer.cdm.json/ProcedurePerformer' with Property 'PerformerActorRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'PerformerAgentPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'PerformerPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'PerformertRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'RequesterAgentPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'SubjectPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'RequesterAgentPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'RequesterAgentPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'RequesterAgentRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'RequestorId'
            ///Property <see cref="ContactId"/> from Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'SubjectPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'ReferralRequestRecipient.cdm.json/ReferralRequestRecipient' with Property 'RecipientPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'RelatedPerson.cdm.json/RelatedPerson' with Property 'PatientId'
            ///Property <see cref="ContactId"/> from Vocab 'RequestGroup.cdm.json/RequestGroup' with Property 'AuthorTypePractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'RequestGroup.cdm.json/RequestGroup' with Property 'SubjectTypePatientId'
            ///Property <see cref="ContactId"/> from Vocab 'RequestGroupActionParticipant.cdm.json/RequestGroupActionParticipant' with Property 'ActionParticipantTypePatientId'
            ///Property <see cref="ContactId"/> from Vocab 'RequestGroupActionParticipant.cdm.json/RequestGroupActionParticipant' with Property 'ActionParticipantTypePersonId'
            ///Property <see cref="ContactId"/> from Vocab 'RequestGroupActionParticipant.cdm.json/RequestGroupActionParticipant' with Property 'ActionParticipantTypePractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'RequestGroupActionParticipant.cdm.json/RequestGroupActionParticipant' with Property 'ActionParticipantTypeRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'RiskAssessment.cdm.json/RiskAssessment' with Property 'PerformerPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'RiskAssessment.cdm.json/RiskAssessment' with Property 'SubjectpatientId'
            ///Property <see cref="ContactId"/> from Vocab 'Schedule.cdm.json/Schedule' with Property 'ActorPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'Schedule.cdm.json/Schedule' with Property 'ActorPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'ScheduleActor.cdm.json/ScheduleActor' with Property 'ActorPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'ScheduleActor.cdm.json/ScheduleActor' with Property 'ActorPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'Specimen.cdm.json/Specimen' with Property 'CollectionCollectorId'
            ///Property <see cref="ContactId"/> from Vocab 'Specimen.cdm.json/Specimen' with Property 'SubjectTypePatientId'
            ///Property <see cref="ContactId"/> from Vocab 'TaskRestrictionRecipient.cdm.json/TaskRestrictionRecipient' with Property 'RestrictionRecipientPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'TaskRestrictionRecipient.cdm.json/TaskRestrictionRecipient' with Property 'RestrictionRecipientPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'TaskRestrictionRecipient.cdm.json/TaskRestrictionRecipient' with Property 'RestrictionRecipientRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'VisionPrescription.cdm.json/VisionPrescription' with Property 'PatientId'
            ///Property <see cref="ContactId"/> from Vocab 'VisionPrescription.cdm.json/VisionPrescription' with Property 'PrescriberId'
            ///Property <see cref="ContactId"/> from Vocab 'Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'Task.cdm.json/Task' with Property 'PerformerOwnerPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'Task.cdm.json/Task' with Property 'PerformerOwnerPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'Task.cdm.json/Task' with Property 'PerformerOwnerRelatedPersonId'
            ///Property <see cref="ContactId"/> from Vocab 'Task.cdm.json/Task' with Property 'RequesterAgentPatientId'
            ///Property <see cref="ContactId"/> from Vocab 'Task.cdm.json/Task' with Property 'RequesterAgentPractitionerId'
            ///Property <see cref="ContactId"/> from Vocab 'Task.cdm.json/Task' with Property 'RequesterAgentRelatedPersonId'
            #endregion
        }

        public VocabularyKey FamilyStatusCode { get; private set; }
        public VocabularyKey GenderCode { get; private set; }
        public VocabularyKey ActivityStartDate { get; private set; }
        public VocabularyKey Address1PeriodEndDate { get; private set; }
        public VocabularyKey Address1PeriodStartDate { get; private set; }
        public VocabularyKey Address2PeriodEndDate { get; private set; }
        public VocabularyKey Address2PeriodStartDate { get; private set; }
        public VocabularyKey Address3PeriodEndDate { get; private set; }
        public VocabularyKey Address3PeriodStartDate { get; private set; }
        public VocabularyKey Animal { get; private set; }
        public VocabularyKey Communication1Preferred { get; private set; }
        public VocabularyKey Communication2Preferred { get; private set; }
        public VocabularyKey Contac1tEndDate { get; private set; }
        public VocabularyKey Contac2tEndDate { get; private set; }
        public VocabularyKey Contact1StartDate { get; private set; }
        public VocabularyKey Contact2StartDate { get; private set; }
        public VocabularyKey ContactType { get; private set; }
        public VocabularyKey DeceasedDate { get; private set; }
        public VocabularyKey MedicalRecordNumber { get; private set; }
        public VocabularyKey MultipleBirth { get; private set; }
        public VocabularyKey Name1EndDate { get; private set; }
        public VocabularyKey Name1StartDate { get; private set; }
        public VocabularyKey Name1Use { get; private set; }
        public VocabularyKey Name2 { get; private set; }
        public VocabularyKey Name2EndDate { get; private set; }
        public VocabularyKey Name2FamilyName { get; private set; }
        public VocabularyKey Name2GivenName { get; private set; }
        public VocabularyKey Name2Prefix { get; private set; }
        public VocabularyKey Name2StartDate { get; private set; }
        public VocabularyKey Name2Suffix { get; private set; }
        public VocabularyKey Name2Use { get; private set; }
        public VocabularyKey Name3 { get; private set; }
        public VocabularyKey Name3FamilyName { get; private set; }
        public VocabularyKey Name3GivenName { get; private set; }
        public VocabularyKey Name3NameEndDate { get; private set; }
        public VocabularyKey Name3NameStartDate { get; private set; }
        public VocabularyKey Name3Prefix { get; private set; }
        public VocabularyKey Name3Suffix { get; private set; }
        public VocabularyKey Name3Use { get; private set; }
        public VocabularyKey Qualification1Identifier { get; private set; }
        public VocabularyKey Qualification1PeriodEndDate { get; private set; }
        public VocabularyKey Qualification1PeriodStartDate { get; private set; }
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