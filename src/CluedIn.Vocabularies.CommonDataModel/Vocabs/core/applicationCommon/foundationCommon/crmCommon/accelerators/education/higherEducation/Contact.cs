using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.HigherEducation
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.highereducation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Contact;

            AddGroup("Contact Details for HigherEducation", group =>
            {
			    ContactType = group.Add(new VocabularyKey(nameof(ContactType), "Contact Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CountryofBirth = group.Add(new VocabularyKey(nameof(CountryofBirth), "Country of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EthnicGroup = group.Add(new VocabularyKey(nameof(EthnicGroup), "Ethnic Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FERPAPrivacy = group.Add(new VocabularyKey(nameof(FERPAPrivacy), "FERPA Privacy", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    FirstGeneration = group.Add(new VocabularyKey(nameof(FirstGeneration), "First Generation", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    HIPAAIndicator = group.Add(new VocabularyKey(nameof(HIPAAIndicator), "HIPAA Indicator", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsDeceased = group.Add(new VocabularyKey(nameof(IsDeceased), "Is Deceased?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastPermanentResidenceCountry = group.Add(new VocabularyKey(nameof(LastPermanentResidenceCountry), "Last Permanent Residence Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Legacy = group.Add(new VocabularyKey(nameof(Legacy), "Legacy", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MaidenName = group.Add(new VocabularyKey(nameof(MaidenName), "Maiden Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ManualRiskScore = group.Add(new VocabularyKey(nameof(ManualRiskScore), "Manual Risk Score", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MiltaryStatus = group.Add(new VocabularyKey(nameof(MiltaryStatus), "Miltary Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NationalIdentifier = group.Add(new VocabularyKey(nameof(NationalIdentifier), "National Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Nationality = group.Add(new VocabularyKey(nameof(Nationality), "Nationality", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Race = group.Add(new VocabularyKey(nameof(Race), "Race", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="PreferredSystemUserId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="MasterId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="CurrentAcademicPeriodId"/> to Vocab 'AcademicPeriod.cdm.json/AcademicPeriod' with Property 'AcademicPeriodId'
            ///Property <see cref="CurrentProgramId"/> to Vocab 'Program.cdm.json/Program' with Property 'ProgramId'
            ///Property <see cref="CurrentProgramLevelId"/> to Vocab 'ProgramLevel.cdm.json/ProgramLevel' with Property 'ProgramLevelId'
            ///Property <see cref="StudentStatusId"/> to Vocab 'StudentStatus.cdm.json/StudentStatus' with Property 'StudentStatusId'
            ///Property <see cref="MasterId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ContactId"/> from Vocab 'Account.cdm.json/Account' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'MasterId'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'ParentCustomerId'
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
            ///Property <see cref="ContactId"/> from Vocab 'AcademicPeriodDetail.cdm.json/AcademicPeriodDetail' with Property 'StudentId'
            ///Property <see cref="ContactId"/> from Vocab 'Accomplishments.cdm.json/Accomplishments' with Property 'StudentId'
            ///Property <see cref="ContactId"/> from Vocab 'CourseHistory.cdm.json/CourseHistory' with Property 'StudentId'
            ///Property <see cref="ContactId"/> from Vocab 'CourseSection.cdm.json/CourseSection' with Property 'InstructorId'
            ///Property <see cref="ContactId"/> from Vocab 'ExtraCurricularActivity.cdm.json/ExtraCurricularActivity' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab 'ExtraCurricularParticipant.cdm.json/ExtraCurricularParticipant' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Grant.cdm.json/Grant' with Property 'BusinessPartnerContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Grant.cdm.json/Grant' with Property 'ResponsibleFacultyContactId'
            ///Property <see cref="ContactId"/> from Vocab 'GrantApplicant.cdm.json/GrantApplicant' with Property 'ApplicantId'
            ///Property <see cref="ContactId"/> from Vocab 'Internship.cdm.json/Internship' with Property 'BusinessPartnerContactId'
            ///Property <see cref="ContactId"/> from Vocab 'InternshipApplicant.cdm.json/InternshipApplicant' with Property 'ApplicantId'
            ///Property <see cref="ContactId"/> from Vocab 'PreviousEducation.cdm.json/PreviousEducation' with Property 'StudentId'
            ///Property <see cref="ContactId"/> from Vocab 'Scholarship.cdm.json/Scholarship' with Property 'BusinessPartnerContactId'
            ///Property <see cref="ContactId"/> from Vocab 'ScholarshipApplicant.cdm.json/ScholarshipApplicant' with Property 'ApplicantId'
            ///Property <see cref="ContactId"/> from Vocab 'TestScore.cdm.json/TestScore' with Property 'StudentID'
            #endregion
        }

        public VocabularyKey ContactType { get; private set; }
        public VocabularyKey CountryofBirth { get; private set; }
        public VocabularyKey EthnicGroup { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
        public VocabularyKey FERPAPrivacy { get; private set; }
        public VocabularyKey FirstGeneration { get; private set; }
        public VocabularyKey HIPAAIndicator { get; private set; }
        public VocabularyKey IsDeceased { get; private set; }
        public VocabularyKey LastPermanentResidenceCountry { get; private set; }
        public VocabularyKey Legacy { get; private set; }
        public VocabularyKey MaidenName { get; private set; }
        public VocabularyKey ManualRiskScore { get; private set; }
        public VocabularyKey MiltaryStatus { get; private set; }
        public VocabularyKey NationalIdentifier { get; private set; }
        public VocabularyKey Nationality { get; private set; }
        public VocabularyKey Race { get; private set; }
    }
}