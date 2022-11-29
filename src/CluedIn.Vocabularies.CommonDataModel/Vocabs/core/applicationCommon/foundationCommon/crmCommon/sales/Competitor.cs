using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Sales
{
    public class CompetitorVocabulary : SimpleVocabulary
    {
        public CompetitorVocabulary()
        {
            VocabularyName = "Competitor";
            KeyPrefix = "commonDataModel.competitor.sales";
            KeySeparator = ".";
            Grouping = "/Competitor";

            AddGroup("Competitor Details for Sales", group =>
            {
			    CompetitorId = group.Add(new VocabularyKey(nameof(CompetitorId), "Competitor ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1AddressId = group.Add(new VocabularyKey(nameof(Address1AddressId), "Address 1: ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1AddressTypeCode = group.Add(new VocabularyKey(nameof(Address1AddressTypeCode), "Address 1: Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1City = group.Add(new VocabularyKey(nameof(Address1City), "City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Country = group.Add(new VocabularyKey(nameof(Address1Country), "Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address1Composite = group.Add(new VocabularyKey(nameof(Address1Composite), "Address 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1County = group.Add(new VocabularyKey(nameof(Address1County), "Address 1: County", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address1Fax = group.Add(new VocabularyKey(nameof(Address1Fax), "Address 1: Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Latitude = group.Add(new VocabularyKey(nameof(Address1Latitude), "Address 1: Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Line1 = group.Add(new VocabularyKey(nameof(Address1Line1), "Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Line2 = group.Add(new VocabularyKey(nameof(Address1Line2), "Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Line3 = group.Add(new VocabularyKey(nameof(Address1Line3), "Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Longitude = group.Add(new VocabularyKey(nameof(Address1Longitude), "Address 1: Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Name = group.Add(new VocabularyKey(nameof(Address1Name), "Address 1: Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PostalCode = group.Add(new VocabularyKey(nameof(Address1PostalCode), "ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PostOfficeBox = group.Add(new VocabularyKey(nameof(Address1PostOfficeBox), "Address 1: Post Office Box", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1ShippingMethodCode = group.Add(new VocabularyKey(nameof(Address1ShippingMethodCode), "Address 1: Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1StateOrProvince = group.Add(new VocabularyKey(nameof(Address1StateOrProvince), "State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Telephone1 = group.Add(new VocabularyKey(nameof(Address1Telephone1), "Address 1: Telephone 1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address1Telephone2 = group.Add(new VocabularyKey(nameof(Address1Telephone2), "Address 1: Telephone 2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address1Telephone3 = group.Add(new VocabularyKey(nameof(Address1Telephone3), "Address 1: Telephone 3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address1UPSZone = group.Add(new VocabularyKey(nameof(Address1UPSZone), "Address 1: UPS Zone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1UTCOffset = group.Add(new VocabularyKey(nameof(Address1UTCOffset), "Address 1: UTC Offset", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    Address2AddressId = group.Add(new VocabularyKey(nameof(Address2AddressId), "Address 2: ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2AddressTypeCode = group.Add(new VocabularyKey(nameof(Address2AddressTypeCode), "Address 2: Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2City = group.Add(new VocabularyKey(nameof(Address2City), "Address 2: City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Composite = group.Add(new VocabularyKey(nameof(Address2Composite), "Address 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Country = group.Add(new VocabularyKey(nameof(Address2Country), "Address 2: Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address2County = group.Add(new VocabularyKey(nameof(Address2County), "Address 2: County", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address2Fax = group.Add(new VocabularyKey(nameof(Address2Fax), "Address 2: Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Latitude = group.Add(new VocabularyKey(nameof(Address2Latitude), "Address 2: Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Line1 = group.Add(new VocabularyKey(nameof(Address2Line1), "Address 2: Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Line2 = group.Add(new VocabularyKey(nameof(Address2Line2), "Address 2: Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Line3 = group.Add(new VocabularyKey(nameof(Address2Line3), "Address 2: Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Longitude = group.Add(new VocabularyKey(nameof(Address2Longitude), "Address 2: Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Name = group.Add(new VocabularyKey(nameof(Address2Name), "Address 2: Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PostalCode = group.Add(new VocabularyKey(nameof(Address2PostalCode), "Address 2: ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PostOfficeBox = group.Add(new VocabularyKey(nameof(Address2PostOfficeBox), "Address 2: Post Office Box", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2ShippingMethodCode = group.Add(new VocabularyKey(nameof(Address2ShippingMethodCode), "Address 2: Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2StateOrProvince = group.Add(new VocabularyKey(nameof(Address2StateOrProvince), "Address 2: State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Telephone1 = group.Add(new VocabularyKey(nameof(Address2Telephone1), "Address 2: Telephone 1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address2Telephone2 = group.Add(new VocabularyKey(nameof(Address2Telephone2), "Address 2: Telephone 2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address2Telephone3 = group.Add(new VocabularyKey(nameof(Address2Telephone3), "Address 2: Telephone 3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address2UPSZone = group.Add(new VocabularyKey(nameof(Address2UPSZone), "Address 2: UPS Zone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2UTCOffset = group.Add(new VocabularyKey(nameof(Address2UTCOffset), "Address 2: UTC Offset", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    KeyProduct = group.Add(new VocabularyKey(nameof(KeyProduct), "Key Product", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Opportunities = group.Add(new VocabularyKey(nameof(Opportunities), "Opportunity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Overview = group.Add(new VocabularyKey(nameof(Overview), "Overview", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferenceInfoUrl = group.Add(new VocabularyKey(nameof(ReferenceInfoUrl), "Reference Info URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    ReportedRevenue = group.Add(new VocabularyKey(nameof(ReportedRevenue), "Reported Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ReportedRevenueBase = group.Add(new VocabularyKey(nameof(ReportedRevenueBase), "Reported Revenue (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReportingQuarter = group.Add(new VocabularyKey(nameof(ReportingQuarter), "Reporting Quarter", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ReportingYear = group.Add(new VocabularyKey(nameof(ReportingYear), "Reporting Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StockExchange = group.Add(new VocabularyKey(nameof(StockExchange), "Stock Exchange", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Strengths = group.Add(new VocabularyKey(nameof(Strengths), "Strength", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Threats = group.Add(new VocabularyKey(nameof(Threats), "Threat", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TickerSymbol = group.Add(new VocabularyKey(nameof(TickerSymbol), "Ticker Symbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Weaknesses = group.Add(new VocabularyKey(nameof(Weaknesses), "Weakness", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebSiteUrl = group.Add(new VocabularyKey(nameof(WebSiteUrl), "Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    WinPercentage = group.Add(new VocabularyKey(nameof(WinPercentage), "Win Percentage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    YomiName = group.Add(new VocabularyKey(nameof(YomiName), "Yomi Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CompetitorId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey Address1AddressId { get; private set; }
        public VocabularyKey Address1AddressTypeCode { get; private set; }
        public VocabularyKey Address1City { get; private set; }
        public VocabularyKey Address1Country { get; private set; }
        public VocabularyKey Address1Composite { get; private set; }
        public VocabularyKey Address1County { get; private set; }
        public VocabularyKey Address1Fax { get; private set; }
        public VocabularyKey Address1Latitude { get; private set; }
        public VocabularyKey Address1Line1 { get; private set; }
        public VocabularyKey Address1Line2 { get; private set; }
        public VocabularyKey Address1Line3 { get; private set; }
        public VocabularyKey Address1Longitude { get; private set; }
        public VocabularyKey Address1Name { get; private set; }
        public VocabularyKey Address1PostalCode { get; private set; }
        public VocabularyKey Address1PostOfficeBox { get; private set; }
        public VocabularyKey Address1ShippingMethodCode { get; private set; }
        public VocabularyKey Address1StateOrProvince { get; private set; }
        public VocabularyKey Address1Telephone1 { get; private set; }
        public VocabularyKey Address1Telephone2 { get; private set; }
        public VocabularyKey Address1Telephone3 { get; private set; }
        public VocabularyKey Address1UPSZone { get; private set; }
        public VocabularyKey Address1UTCOffset { get; private set; }
        public VocabularyKey Address2AddressId { get; private set; }
        public VocabularyKey Address2AddressTypeCode { get; private set; }
        public VocabularyKey Address2City { get; private set; }
        public VocabularyKey Address2Composite { get; private set; }
        public VocabularyKey Address2Country { get; private set; }
        public VocabularyKey Address2County { get; private set; }
        public VocabularyKey Address2Fax { get; private set; }
        public VocabularyKey Address2Latitude { get; private set; }
        public VocabularyKey Address2Line1 { get; private set; }
        public VocabularyKey Address2Line2 { get; private set; }
        public VocabularyKey Address2Line3 { get; private set; }
        public VocabularyKey Address2Longitude { get; private set; }
        public VocabularyKey Address2Name { get; private set; }
        public VocabularyKey Address2PostalCode { get; private set; }
        public VocabularyKey Address2PostOfficeBox { get; private set; }
        public VocabularyKey Address2ShippingMethodCode { get; private set; }
        public VocabularyKey Address2StateOrProvince { get; private set; }
        public VocabularyKey Address2Telephone1 { get; private set; }
        public VocabularyKey Address2Telephone2 { get; private set; }
        public VocabularyKey Address2Telephone3 { get; private set; }
        public VocabularyKey Address2UPSZone { get; private set; }
        public VocabularyKey Address2UTCOffset { get; private set; }
        public VocabularyKey KeyProduct { get; private set; }
        public VocabularyKey Opportunities { get; private set; }
        public VocabularyKey Overview { get; private set; }
        public VocabularyKey ReferenceInfoUrl { get; private set; }
        public VocabularyKey ReportedRevenue { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ReportedRevenueBase { get; private set; }
        public VocabularyKey ReportingQuarter { get; private set; }
        public VocabularyKey ReportingYear { get; private set; }
        public VocabularyKey StockExchange { get; private set; }
        public VocabularyKey Strengths { get; private set; }
        public VocabularyKey Threats { get; private set; }
        public VocabularyKey TickerSymbol { get; private set; }
        public VocabularyKey Weaknesses { get; private set; }
        public VocabularyKey WebSiteUrl { get; private set; }
        public VocabularyKey WinPercentage { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey YomiName { get; private set; }
    }
}