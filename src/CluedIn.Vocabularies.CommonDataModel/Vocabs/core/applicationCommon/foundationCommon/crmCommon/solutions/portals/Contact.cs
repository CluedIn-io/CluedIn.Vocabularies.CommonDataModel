using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Portals
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.portals";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Contact;

            AddGroup("Contact Details for Portals", group =>
            {
			    AdxCreatedByIPAddress = group.Add(new VocabularyKey(nameof(AdxCreatedByIPAddress), "Created By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByUsername = group.Add(new VocabularyKey(nameof(AdxCreatedByUsername), "Created By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByIPAddress = group.Add(new VocabularyKey(nameof(AdxModifiedByIPAddress), "Modified By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByUsername = group.Add(new VocabularyKey(nameof(AdxModifiedByUsername), "Modified By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxOrganizationName = group.Add(new VocabularyKey(nameof(AdxOrganizationName), "Organization Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxTimeZone = group.Add(new VocabularyKey(nameof(AdxTimeZone), "Time Zone", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    DisableWebTracking = group.Add(new VocabularyKey(nameof(DisableWebTracking), "Disable Web Tracking", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsMinor = group.Add(new VocabularyKey(nameof(IsMinor), "Is Minor", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsMinorWithParentalConsent = group.Add(new VocabularyKey(nameof(IsMinorWithParentalConsent), "Is Minor with Parental Consent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PortalTermsAgreementDate = group.Add(new VocabularyKey(nameof(PortalTermsAgreementDate), "Portal Terms Agreement Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfileAlert = group.Add(new VocabularyKey(nameof(ProfileAlert), "Profile Alert", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ProfileAlertDate = group.Add(new VocabularyKey(nameof(ProfileAlertDate), "Profile Alert Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfileAlertInstructions = group.Add(new VocabularyKey(nameof(ProfileAlertInstructions), "Profile Alert Instructions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxProfileIsAnonymous = group.Add(new VocabularyKey(nameof(AdxProfileIsAnonymous), "Profile Is Anonymous", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AdxProfileLastActivity = group.Add(new VocabularyKey(nameof(AdxProfileLastActivity), "Profile Last Activity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfileModifiedOn = group.Add(new VocabularyKey(nameof(ProfileModifiedOn), "Profile Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PublicProfileCopy = group.Add(new VocabularyKey(nameof(PublicProfileCopy), "Public Profile Copy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccessFailedCount = group.Add(new VocabularyKey(nameof(AccessFailedCount), "Access Failed Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EmailConfirmed = group.Add(new VocabularyKey(nameof(EmailConfirmed), "Email Confirmed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastSuccessfulLogin = group.Add(new VocabularyKey(nameof(LastSuccessfulLogin), "Last Successful Login", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocalLoginDisabled = group.Add(new VocabularyKey(nameof(LocalLoginDisabled), "Local Login Disabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LockoutEnabled = group.Add(new VocabularyKey(nameof(LockoutEnabled), "Lockout Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LockoutEndDate = group.Add(new VocabularyKey(nameof(LockoutEndDate), "Lockout End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LoginEnabled = group.Add(new VocabularyKey(nameof(LoginEnabled), "Login Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MobilePhoneConfirmed = group.Add(new VocabularyKey(nameof(MobilePhoneConfirmed), "Mobile Phone Confirmed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PasswordHash = group.Add(new VocabularyKey(nameof(PasswordHash), "Password Hash", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SecurityStamp = group.Add(new VocabularyKey(nameof(SecurityStamp), "Security Stamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TwoFactorEnabled = group.Add(new VocabularyKey(nameof(TwoFactorEnabled), "Two Factor Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    UserName = group.Add(new VocabularyKey(nameof(UserName), "User Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ManagingPartner"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ManagingPartner"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
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
            ///Property <see cref="DefaultPriceLevelId"/> to Vocab '/core/applicationCommon/foundationCommon/PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="PreferredEquipmentId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/FacilityEquipment.cdm.json/FacilityEquipment' with Property 'EquipmentId'
            ///Property <see cref="PreferredServiceId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Service.cdm.json/Service' with Property 'ServiceId'
            ///Property <see cref="PreferredLanguage"/> to Vocab 'PortalLanguage.cdm.json/PortalLanguage' with Property 'PortalLanguageId'
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
            ///Property <see cref="PreferredLanguage"/> to Vocab 'PortalLanguage.cdm.json/PortalLanguage' with Property 'PortalLanguageId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ContactId"/> from Vocab 'Account.cdm.json/Account' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Badge.cdm.json/Badge' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'BlogPost.cdm.json/BlogPost' with Property 'AuthorId'
            ///Property <see cref="ContactId"/> from Vocab 'Case.cdm.json/Case' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'Case.cdm.json/Case' with Property 'ResponsibleContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Case.cdm.json/Case' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Case.cdm.json/Case' with Property 'PartnerContact'
            ///Property <see cref="ContactId"/> from Vocab 'CaseDeflection.cdm.json/CaseDeflection' with Property 'Contact'
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
            ///Property <see cref="ContactId"/> from Vocab 'ExternalIdentity.cdm.json/ExternalIdentity' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Feedback.cdm.json/Feedback' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'Feedback.cdm.json/Feedback' with Property 'CreatedByContact'
            ///Property <see cref="ContactId"/> from Vocab 'Feedback.cdm.json/Feedback' with Property 'CreatedOnBehalfByContact'
            ///Property <see cref="ContactId"/> from Vocab 'ForumPost.cdm.json/ForumPost' with Property 'AuthorId'
            ///Property <see cref="ContactId"/> from Vocab 'Idea.cdm.json/Idea' with Property 'AuthorId'
            ///Property <see cref="ContactId"/> from Vocab 'Idea.cdm.json/Idea' with Property 'StatusAuthorId'
            ///Property <see cref="ContactId"/> from Vocab 'Invitation.cdm.json/Invitation' with Property 'InviteContact'
            ///Property <see cref="ContactId"/> from Vocab 'Invitation.cdm.json/Invitation' with Property 'InviterContact'
            ///Property <see cref="ContactId"/> from Vocab 'Invitation.cdm.json/Invitation' with Property 'RedeemedContact'
            ///Property <see cref="ContactId"/> from Vocab 'InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'Opportunity.cdm.json/Opportunity' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'Opportunity.cdm.json/Opportunity' with Property 'ParentContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Opportunity.cdm.json/Opportunity' with Property 'PartnerContact'
            ///Property <see cref="ContactId"/> from Vocab 'PollSubmission.cdm.json/PollSubmission' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'WebFileLog.cdm.json/WebFileLog' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'WebPage.cdm.json/WebPage' with Property 'AuthorId'
            ///Property <see cref="ContactId"/> from Vocab 'WebPageLog.cdm.json/WebPageLog' with Property 'ContactId'
            #endregion
        }

        public VocabularyKey AdxCreatedByIPAddress { get; private set; }
        public VocabularyKey AdxCreatedByUsername { get; private set; }
        public VocabularyKey AdxModifiedByIPAddress { get; private set; }
        public VocabularyKey AdxModifiedByUsername { get; private set; }
        public VocabularyKey AdxOrganizationName { get; private set; }
        public VocabularyKey AdxTimeZone { get; private set; }
        public VocabularyKey DisableWebTracking { get; private set; }
        public VocabularyKey IsMinor { get; private set; }
        public VocabularyKey IsMinorWithParentalConsent { get; private set; }
        public VocabularyKey PortalTermsAgreementDate { get; private set; }
        public VocabularyKey ProfileAlert { get; private set; }
        public VocabularyKey ProfileAlertDate { get; private set; }
        public VocabularyKey ProfileAlertInstructions { get; private set; }
        public VocabularyKey AdxProfileIsAnonymous { get; private set; }
        public VocabularyKey AdxProfileLastActivity { get; private set; }
        public VocabularyKey ProfileModifiedOn { get; private set; }
        public VocabularyKey PublicProfileCopy { get; private set; }
        public VocabularyKey AccessFailedCount { get; private set; }
        public VocabularyKey EmailConfirmed { get; private set; }
        public VocabularyKey LastSuccessfulLogin { get; private set; }
        public VocabularyKey LocalLoginDisabled { get; private set; }
        public VocabularyKey LockoutEnabled { get; private set; }
        public VocabularyKey LockoutEndDate { get; private set; }
        public VocabularyKey LoginEnabled { get; private set; }
        public VocabularyKey MobilePhoneConfirmed { get; private set; }
        public VocabularyKey PasswordHash { get; private set; }
        public VocabularyKey SecurityStamp { get; private set; }
        public VocabularyKey TwoFactorEnabled { get; private set; }
        public VocabularyKey UserName { get; private set; }
    }
}