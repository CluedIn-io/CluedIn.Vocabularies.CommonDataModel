using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.EventManagement
{
    public class VenueVocabulary : SimpleVocabulary
    {
        public VenueVocabulary()
        {
            VocabularyName = "Venue";
            KeyPrefix = "commonDataModel.venue.eventmanagement";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Venue;

            AddGroup("Venue Details for EventManagement", group =>
            {
			    VenueId = group.Add(new VocabularyKey(nameof(VenueId), "Venue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccessibleToilets = group.Add(new VocabularyKey(nameof(AccessibleToilets), "Accessible Toilets", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdditionalFacilities = group.Add(new VocabularyKey(nameof(AdditionalFacilities), "Additional Facilities", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine1 = group.Add(new VocabularyKey(nameof(AddressLine1), "Address Line 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), "Address Line 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine3 = group.Add(new VocabularyKey(nameof(AddressLine3), "Address Line 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    City = group.Add(new VocabularyKey(nameof(City), "City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Cost = group.Add(new VocabularyKey(nameof(Cost), "Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CostBase = group.Add(new VocabularyKey(nameof(CostBase), "Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisabledAccess = group.Add(new VocabularyKey(nameof(DisabledAccess), "Disabled Access", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisabledParking = group.Add(new VocabularyKey(nameof(DisabledParking), "Disable parking", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Email = group.Add(new VocabularyKey(nameof(Email), "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    EstCapacity = group.Add(new VocabularyKey(nameof(EstCapacity), "Est. Capacity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), "Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PublicTelephoneAvailable = group.Add(new VocabularyKey(nameof(PublicTelephoneAvailable), "Public Telephone Available", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateProvince = group.Add(new VocabularyKey(nameof(StateProvince), "State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone1 = group.Add(new VocabularyKey(nameof(Telephone1), "Telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Telephone2 = group.Add(new VocabularyKey(nameof(Telephone2), "Telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Telephone3 = group.Add(new VocabularyKey(nameof(Telephone3), "Telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), "Currency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Website = group.Add(new VocabularyKey(nameof(Website), "Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    WifiAvailable = group.Add(new VocabularyKey(nameof(WifiAvailable), "Wifi Available", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WifiPassword = group.Add(new VocabularyKey(nameof(WifiPassword), "Wifi Password", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WifiSSID = group.Add(new VocabularyKey(nameof(WifiSSID), "Wifi SSID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressComposite = group.Add(new VocabularyKey(nameof(AddressComposite), "Address Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="BuildingId"/> to Vocab 'Building.cdm.json/Building' with Property 'BuildingId'
            ///Property <see cref="RoomId"/> to Vocab 'Room.cdm.json/Room' with Property 'RoomId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ParentVenueId"/> to Vocab 'Venue.cdm.json/Venue' with Property 'VenueId'
            ///Property <see cref="PrimaryContact"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'ContactId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="VenueId"/> from Vocab 'Event.cdm.json/Event' with Property 'PrimaryVenue'
            ///Property <see cref="VenueId"/> from Vocab 'Session.cdm.json/Session' with Property 'Venue'
            ///Property <see cref="VenueId"/> from Vocab 'Venue.cdm.json/Venue' with Property 'ParentVenueId'
            #endregion
        }

        public VocabularyKey VenueId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AccessibleToilets { get; private set; }
        public VocabularyKey AdditionalFacilities { get; private set; }
        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressLine3 { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey Cost { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CostBase { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisabledAccess { get; private set; }
        public VocabularyKey DisabledParking { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey EstCapacity { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey PublicTelephoneAvailable { get; private set; }
        public VocabularyKey StateProvince { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey Website { get; private set; }
        public VocabularyKey WifiAvailable { get; private set; }
        public VocabularyKey WifiPassword { get; private set; }
        public VocabularyKey WifiSSID { get; private set; }
        public VocabularyKey AddressComposite { get; private set; }
    }
}