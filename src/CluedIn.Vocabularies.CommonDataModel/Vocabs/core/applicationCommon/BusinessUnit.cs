using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class BusinessUnitVocabulary : SimpleVocabulary
    {
        public BusinessUnitVocabulary()
        {
            VocabularyName = "Business Unit";
            KeyPrefix = "commonDataModel.businessunit.applicationcommon";
            KeySeparator = ".";
            Grouping = "/BusinessUnit";

            AddGroup("BusinessUnit Details for ApplicationCommon", group =>
            {
			    BusinessUnitId = group.Add(new VocabularyKey(nameof(BusinessUnitId), "Business Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DivisionName = group.Add(new VocabularyKey(nameof(DivisionName), "Division", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FileAsName = group.Add(new VocabularyKey(nameof(FileAsName), "File as Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TickerSymbol = group.Add(new VocabularyKey(nameof(TickerSymbol), "Ticker Symbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StockExchange = group.Add(new VocabularyKey(nameof(StockExchange), "Stock Exchange", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UTCOffset = group.Add(new VocabularyKey(nameof(UTCOffset), "UTC Offset", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreditLimit = group.Add(new VocabularyKey(nameof(CreditLimit), "Credit Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CostCenter = group.Add(new VocabularyKey(nameof(CostCenter), "Cost Center", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebSiteUrl = group.Add(new VocabularyKey(nameof(WebSiteUrl), "Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    FtpSiteUrl = group.Add(new VocabularyKey(nameof(FtpSiteUrl), "FTP Site", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    InheritanceMask = group.Add(new VocabularyKey(nameof(InheritanceMask), "Inheritance Mask", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    WorkflowSuspended = group.Add(new VocabularyKey(nameof(WorkflowSuspended), "Workflow Suspended", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsDisabled = group.Add(new VocabularyKey(nameof(IsDisabled), "Is Disabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DisabledReason = group.Add(new VocabularyKey(nameof(DisabledReason), "Disable Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1AddressId = group.Add(new VocabularyKey(nameof(Address1AddressId), "Address 1: ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1AddressTypeCode = group.Add(new VocabularyKey(nameof(Address1AddressTypeCode), "Address 1: Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Name = group.Add(new VocabularyKey(nameof(Address1Name), "Address 1: Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Line1 = group.Add(new VocabularyKey(nameof(Address1Line1), "Bill To Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Line2 = group.Add(new VocabularyKey(nameof(Address1Line2), "Bill To Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Line3 = group.Add(new VocabularyKey(nameof(Address1Line3), "Bill To Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1City = group.Add(new VocabularyKey(nameof(Address1City), "Bill To City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1StateOrProvince = group.Add(new VocabularyKey(nameof(Address1StateOrProvince), "Bill To State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1County = group.Add(new VocabularyKey(nameof(Address1County), "Address 1: County", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address1Country = group.Add(new VocabularyKey(nameof(Address1Country), "Bill To Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address1PostOfficeBox = group.Add(new VocabularyKey(nameof(Address1PostOfficeBox), "Address 1: Post Office Box", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PostalCode = group.Add(new VocabularyKey(nameof(Address1PostalCode), "Bill To ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1UTCOffset = group.Add(new VocabularyKey(nameof(Address1UTCOffset), "Address 1: UTC Offset", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    Address1UPSZone = group.Add(new VocabularyKey(nameof(Address1UPSZone), "Address 1: UPS Zone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Latitude = group.Add(new VocabularyKey(nameof(Address1Latitude), "Address 1: Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Telephone1 = group.Add(new VocabularyKey(nameof(Address1Telephone1), "Main Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address1Longitude = group.Add(new VocabularyKey(nameof(Address1Longitude), "Address 1: Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1ShippingMethodCode = group.Add(new VocabularyKey(nameof(Address1ShippingMethodCode), "Address 1: Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Telephone2 = group.Add(new VocabularyKey(nameof(Address1Telephone2), "Other Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address1Telephone3 = group.Add(new VocabularyKey(nameof(Address1Telephone3), "Address 1: Telephone 3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address1Fax = group.Add(new VocabularyKey(nameof(Address1Fax), "Address 1: Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2AddressId = group.Add(new VocabularyKey(nameof(Address2AddressId), "Address 2: ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2AddressTypeCode = group.Add(new VocabularyKey(nameof(Address2AddressTypeCode), "Address 2: Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Name = group.Add(new VocabularyKey(nameof(Address2Name), "Address 2: Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Line1 = group.Add(new VocabularyKey(nameof(Address2Line1), "Ship To Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Line2 = group.Add(new VocabularyKey(nameof(Address2Line2), "Ship To Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Line3 = group.Add(new VocabularyKey(nameof(Address2Line3), "Ship To Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2City = group.Add(new VocabularyKey(nameof(Address2City), "Ship To City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2StateOrProvince = group.Add(new VocabularyKey(nameof(Address2StateOrProvince), "Ship To State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2County = group.Add(new VocabularyKey(nameof(Address2County), "Address 2: County", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address2Country = group.Add(new VocabularyKey(nameof(Address2Country), "Ship To Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address2PostOfficeBox = group.Add(new VocabularyKey(nameof(Address2PostOfficeBox), "Address 2: Post Office Box", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PostalCode = group.Add(new VocabularyKey(nameof(Address2PostalCode), "Ship To ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2UTCOffset = group.Add(new VocabularyKey(nameof(Address2UTCOffset), "Address 2: UTC Offset", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    Address2UPSZone = group.Add(new VocabularyKey(nameof(Address2UPSZone), "Address 2: UPS Zone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Latitude = group.Add(new VocabularyKey(nameof(Address2Latitude), "Address 2: Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Telephone1 = group.Add(new VocabularyKey(nameof(Address2Telephone1), "Address 2: Telephone 1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address2Longitude = group.Add(new VocabularyKey(nameof(Address2Longitude), "Address 2: Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2ShippingMethodCode = group.Add(new VocabularyKey(nameof(Address2ShippingMethodCode), "Address 2: Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Telephone2 = group.Add(new VocabularyKey(nameof(Address2Telephone2), "Address 2: Telephone 2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address2Telephone3 = group.Add(new VocabularyKey(nameof(Address2Telephone3), "Address 2: Telephone 3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address2Fax = group.Add(new VocabularyKey(nameof(Address2Fax), "Address 2: Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Picture = group.Add(new VocabularyKey(nameof(Picture), "Picture", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), "Calendar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BusinessUnitId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DivisionName { get; private set; }
        public VocabularyKey FileAsName { get; private set; }
        public VocabularyKey TickerSymbol { get; private set; }
        public VocabularyKey StockExchange { get; private set; }
        public VocabularyKey UTCOffset { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey CreditLimit { get; private set; }
        public VocabularyKey CostCenter { get; private set; }
        public VocabularyKey WebSiteUrl { get; private set; }
        public VocabularyKey FtpSiteUrl { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey InheritanceMask { get; private set; }
        public VocabularyKey WorkflowSuspended { get; private set; }
        public VocabularyKey IsDisabled { get; private set; }
        public VocabularyKey DisabledReason { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey Address1AddressId { get; private set; }
        public VocabularyKey Address1AddressTypeCode { get; private set; }
        public VocabularyKey Address1Name { get; private set; }
        public VocabularyKey Address1Line1 { get; private set; }
        public VocabularyKey Address1Line2 { get; private set; }
        public VocabularyKey Address1Line3 { get; private set; }
        public VocabularyKey Address1City { get; private set; }
        public VocabularyKey Address1StateOrProvince { get; private set; }
        public VocabularyKey Address1County { get; private set; }
        public VocabularyKey Address1Country { get; private set; }
        public VocabularyKey Address1PostOfficeBox { get; private set; }
        public VocabularyKey Address1PostalCode { get; private set; }
        public VocabularyKey Address1UTCOffset { get; private set; }
        public VocabularyKey Address1UPSZone { get; private set; }
        public VocabularyKey Address1Latitude { get; private set; }
        public VocabularyKey Address1Telephone1 { get; private set; }
        public VocabularyKey Address1Longitude { get; private set; }
        public VocabularyKey Address1ShippingMethodCode { get; private set; }
        public VocabularyKey Address1Telephone2 { get; private set; }
        public VocabularyKey Address1Telephone3 { get; private set; }
        public VocabularyKey Address1Fax { get; private set; }
        public VocabularyKey Address2AddressId { get; private set; }
        public VocabularyKey Address2AddressTypeCode { get; private set; }
        public VocabularyKey Address2Name { get; private set; }
        public VocabularyKey Address2Line1 { get; private set; }
        public VocabularyKey Address2Line2 { get; private set; }
        public VocabularyKey Address2Line3 { get; private set; }
        public VocabularyKey Address2City { get; private set; }
        public VocabularyKey Address2StateOrProvince { get; private set; }
        public VocabularyKey Address2County { get; private set; }
        public VocabularyKey Address2Country { get; private set; }
        public VocabularyKey Address2PostOfficeBox { get; private set; }
        public VocabularyKey Address2PostalCode { get; private set; }
        public VocabularyKey Address2UTCOffset { get; private set; }
        public VocabularyKey Address2UPSZone { get; private set; }
        public VocabularyKey Address2Latitude { get; private set; }
        public VocabularyKey Address2Telephone1 { get; private set; }
        public VocabularyKey Address2Longitude { get; private set; }
        public VocabularyKey Address2ShippingMethodCode { get; private set; }
        public VocabularyKey Address2Telephone2 { get; private set; }
        public VocabularyKey Address2Telephone3 { get; private set; }
        public VocabularyKey Address2Fax { get; private set; }
        public VocabularyKey Picture { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}