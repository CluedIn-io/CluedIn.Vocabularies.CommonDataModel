using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class LeadAddressVocabulary : SimpleVocabulary
    {
        public LeadAddressVocabulary()
        {
            VocabularyName = "Lead Address";
            KeyPrefix = "commonDataModel.leadaddress";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.LeadAddress;

            AddGroup("LeadAddress Details for CrmCommon", group =>
            {
			    LeadAddressId = group.Add(new VocabularyKey(nameof(LeadAddressId), "Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Address Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressNumber = group.Add(new VocabularyKey(nameof(AddressNumber), "Address Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AddressTypeCode = group.Add(new VocabularyKey(nameof(AddressTypeCode), "Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    City = group.Add(new VocabularyKey(nameof(City), "City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Composite = group.Add(new VocabularyKey(nameof(Composite), "Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country/Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    County = group.Add(new VocabularyKey(nameof(County), "County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Fax = group.Add(new VocabularyKey(nameof(Fax), "Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Latitude = group.Add(new VocabularyKey(nameof(Latitude), "Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Line1 = group.Add(new VocabularyKey(nameof(Line1), "Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Line2 = group.Add(new VocabularyKey(nameof(Line2), "Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Line3 = group.Add(new VocabularyKey(nameof(Line3), "Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Longitude = group.Add(new VocabularyKey(nameof(Longitude), "Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), "ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostOfficeBox = group.Add(new VocabularyKey(nameof(PostOfficeBox), "Post Office Box", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShippingMethodCode = group.Add(new VocabularyKey(nameof(ShippingMethodCode), "Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateOrProvince = group.Add(new VocabularyKey(nameof(StateOrProvince), "State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone1 = group.Add(new VocabularyKey(nameof(Telephone1), "Main Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Telephone2 = group.Add(new VocabularyKey(nameof(Telephone2), "Phone 2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Telephone3 = group.Add(new VocabularyKey(nameof(Telephone3), "Telephone 3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    UPSZone = group.Add(new VocabularyKey(nameof(UPSZone), "UPS Zone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UTCOffset = group.Add(new VocabularyKey(nameof(UTCOffset), "UTC Offset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ParentId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="CreatedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey AddressNumber { get; private set; }
        public VocabularyKey AddressTypeCode { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey Composite { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey LeadAddressId { get; private set; }
        public VocabularyKey Line1 { get; private set; }
        public VocabularyKey Line2 { get; private set; }
        public VocabularyKey Line3 { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey PostOfficeBox { get; private set; }
        public VocabularyKey ShippingMethodCode { get; private set; }
        public VocabularyKey StateOrProvince { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UPSZone { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey UTCOffset { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}