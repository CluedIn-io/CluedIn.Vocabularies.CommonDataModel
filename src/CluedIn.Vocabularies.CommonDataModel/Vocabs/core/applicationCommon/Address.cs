using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class AddressVocabulary : SimpleVocabulary
    {
        public AddressVocabulary()
        {
            VocabularyName = "Address";
            KeyPrefix = "commonDataModel.address";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Address;

            AddGroup("Address Details for ApplicationCommon", group =>
            {
			    CustomerAddressId = group.Add(new VocabularyKey(nameof(CustomerAddressId), "Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressNumber = group.Add(new VocabularyKey(nameof(AddressNumber), "Address Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ObjectTypeCode = group.Add(new VocabularyKey(nameof(ObjectTypeCode), "Object Type ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressTypeCode = group.Add(new VocabularyKey(nameof(AddressTypeCode), "Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Address Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryContactName = group.Add(new VocabularyKey(nameof(PrimaryContactName), "Address Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Line1 = group.Add(new VocabularyKey(nameof(Line1), "Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Line2 = group.Add(new VocabularyKey(nameof(Line2), "Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Line3 = group.Add(new VocabularyKey(nameof(Line3), "Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    City = group.Add(new VocabularyKey(nameof(City), "City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateOrProvince = group.Add(new VocabularyKey(nameof(StateOrProvince), "State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    County = group.Add(new VocabularyKey(nameof(County), "County", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    PostOfficeBox = group.Add(new VocabularyKey(nameof(PostOfficeBox), "Post Office Box", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), "ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UTCOffset = group.Add(new VocabularyKey(nameof(UTCOffset), "UTC Offset", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    FreightTermsCode = group.Add(new VocabularyKey(nameof(FreightTermsCode), "Freight Terms", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UPSZone = group.Add(new VocabularyKey(nameof(UPSZone), "UPS Zone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Latitude = group.Add(new VocabularyKey(nameof(Latitude), "Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone1 = group.Add(new VocabularyKey(nameof(Telephone1), "Main Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Longitude = group.Add(new VocabularyKey(nameof(Longitude), "Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShippingMethodCode = group.Add(new VocabularyKey(nameof(ShippingMethodCode), "Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone2 = group.Add(new VocabularyKey(nameof(Telephone2), "Phone 2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Telephone3 = group.Add(new VocabularyKey(nameof(Telephone3), "Telephone 3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Fax = group.Add(new VocabularyKey(nameof(Fax), "Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningBusinessUnit = group.Add(new VocabularyKey(nameof(OwningBusinessUnit), "Owning Business Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), "Owner", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Composite = group.Add(new VocabularyKey(nameof(Composite), "Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Address Details for HigherEducation", group =>
            {
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MailType = group.Add(new VocabularyKey(nameof(MailType), "Mail Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Address Details for ElectronicMedicalRecords", group =>
            {

            });
            AddGroup("Address Details for NonProfitCore", group =>
            {
			    IsUspsValidated = group.Add(new VocabularyKey(nameof(IsUspsValidated), "USPS Validated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsValidated = group.Add(new VocabularyKey(nameof(IsValidated), "Validated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Region = group.Add(new VocabularyKey(nameof(Region), "Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeasonalEndDay = group.Add(new VocabularyKey(nameof(SeasonalEndDay), "Seasonal End Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeasonalEndMonth = group.Add(new VocabularyKey(nameof(SeasonalEndMonth), "Seasonal End Month", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeasonalStartDay = group.Add(new VocabularyKey(nameof(SeasonalStartDay), "Seasonal Start Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeasonalStartMonth = group.Add(new VocabularyKey(nameof(SeasonalStartMonth), "Seasonal Start Month", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone1TypeCode = group.Add(new VocabularyKey(nameof(Telephone1TypeCode), "Telephone 1 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone2TypeCode = group.Add(new VocabularyKey(nameof(Telephone2TypeCode), "Telephone 2 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone3TypeCode = group.Add(new VocabularyKey(nameof(Telephone3TypeCode), "Telephone 3 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ParentId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="CustomerAddressId"/> from Vocab 'foundationCommon/crmCommon/service/Contract.cdm.json/Contract' with Property 'BillToAddress'
            ///Property <see cref="CustomerAddressId"/> from Vocab 'foundationCommon/crmCommon/service/Contract.cdm.json/Contract' with Property 'ServiceAddress'
            ///Property <see cref="CustomerAddressId"/> from Vocab 'foundationCommon/crmCommon/service/ContractLine.cdm.json/ContractLine' with Property 'ServiceAddress'
            #endregion
        }

        public VocabularyKey AddressNumber { get; private set; }
        public VocabularyKey AddressTypeCode { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey Composite { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CustomerAddressId { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey FreightTermsCode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey IsUspsValidated { get; private set; }
        public VocabularyKey IsValidated { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey Line1 { get; private set; }
        public VocabularyKey Line2 { get; private set; }
        public VocabularyKey Line3 { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey MailType { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObjectTypeCode { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey OwningBusinessUnit { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey PostOfficeBox { get; private set; }
        public VocabularyKey PrimaryContactName { get; private set; }
        public VocabularyKey Region { get; private set; }
        public VocabularyKey SeasonalEndDay { get; private set; }
        public VocabularyKey SeasonalEndMonth { get; private set; }
        public VocabularyKey SeasonalStartDay { get; private set; }
        public VocabularyKey SeasonalStartMonth { get; private set; }
        public VocabularyKey ShippingMethodCode { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StateOrProvince { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey Telephone1TypeCode { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Telephone2TypeCode { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey Telephone3TypeCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UPSZone { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey UTCOffset { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}