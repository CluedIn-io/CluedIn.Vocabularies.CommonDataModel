using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class FacilityEquipmentVocabulary : SimpleVocabulary
    {
        public FacilityEquipmentVocabulary()
        {
            VocabularyName = "Facility Equipment";
            KeyPrefix = "commonDataModel.facilityequipment";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.FacilityEquipment;

            AddGroup("FacilityEquipment Details for Service", group =>
            {
			    EquipmentId = group.Add(new VocabularyKey(nameof(EquipmentId), "Facility/Equipment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), "Calendar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayInServiceViews = group.Add(new VocabularyKey(nameof(DisplayInServiceViews), "Display in Service Views", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Primary Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    IsDisabled = group.Add(new VocabularyKey(nameof(IsDisabled), "Is Disabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Skills = group.Add(new VocabularyKey(nameof(Skills), "Skills", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneCode = group.Add(new VocabularyKey(nameof(TimeZoneCode), "Time Zone", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="BusinessUnitId"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="BusinessUnitId"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="SiteId"/> to Vocab 'Site.cdm.json/Site' with Property 'SiteId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="EquipmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'PreferredEquipmentId'
            ///Property <see cref="EquipmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'PreferredEquipmentId'
            ///Property <see cref="EquipmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'EmailSender'
            ///Property <see cref="EquipmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/financialServices/banking/Account.cdm.json/Account' with Property 'PreferredEquipmentId'
            ///Property <see cref="EquipmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/financialServices/banking/Contact.cdm.json/Contact' with Property 'PreferredEquipmentId'
            ///Property <see cref="EquipmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/Contact.cdm.json/Contact' with Property 'PreferredEquipmentId'
            ///Property <see cref="EquipmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Account.cdm.json/Account' with Property 'PreferredEquipmentId'
            ///Property <see cref="EquipmentId"/> from Vocab 'Resource.cdm.json/Resource' with Property 'ResourceId'
            ///Property <see cref="EquipmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'PreferredEquipmentId'
            ///Property <see cref="EquipmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/eventManagement/Account.cdm.json/Account' with Property 'PreferredEquipmentId'
            ///Property <see cref="EquipmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Account.cdm.json/Account' with Property 'PreferredEquipmentId'
            ///Property <see cref="EquipmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Contact.cdm.json/Contact' with Property 'PreferredEquipmentId'
            #endregion
        }

        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisplayInServiceViews { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey EquipmentId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey IsDisabled { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey Skills { get; private set; }
        public VocabularyKey TimeZoneCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}