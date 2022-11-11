using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirPartyLocationPostalAddressHistoricalEntityVocabulary : SimpleVocabulary
    {
        public DirPartyLocationPostalAddressHistoricalEntityVocabulary()
        {
            VocabularyName = "DirPartyLocationPostalAddressHistoricalEntity";
            KeyPrefix = "commonDataModel.dirpartylocationpostaladdresshistoricalentity";
            KeySeparator = ".";
            Grouping = "/DirPartyLocationPostalAddressHistoricalEntity";

            AddGroup("DirPartyLocationPostalAddressHistoricalEntity Details", group =>
            {
                AttentionToAddressLine = group.Add(new VocabularyKey(nameof(AttentionToAddressLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocationOwner = group.Add(new VocabularyKey(nameof(IsLocationOwner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPostalAddress = group.Add(new VocabularyKey(nameof(IsPostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryTaxRegistration = group.Add(new VocabularyKey(nameof(IsPrimaryTaxRegistration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrivate = group.Add(new VocabularyKey(nameof(IsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRoleBusiness = group.Add(new VocabularyKey(nameof(IsRoleBusiness), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRoleDelivery = group.Add(new VocabularyKey(nameof(IsRoleDelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRoleHome = group.Add(new VocabularyKey(nameof(IsRoleHome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRoleInvoice = group.Add(new VocabularyKey(nameof(IsRoleInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Address = group.Add(new VocabularyKey(nameof(Address), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Apartment_RU = group.Add(new VocabularyKey(nameof(Apartment_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Building_RU = group.Add(new VocabularyKey(nameof(Building_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuildingCompliment = group.Add(new VocabularyKey(nameof(BuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CityInKana = group.Add(new VocabularyKey(nameof(CityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionISOCode = group.Add(new VocabularyKey(nameof(CountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistrictName = group.Add(new VocabularyKey(nameof(DistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DunsNumber = group.Add(new VocabularyKey(nameof(DunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrivatePostalAddress = group.Add(new VocabularyKey(nameof(IsPrivatePostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Latitude = group.Add(new VocabularyKey(nameof(Latitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Longitude = group.Add(new VocabularyKey(nameof(Longitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostBox = group.Add(new VocabularyKey(nameof(PostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street = group.Add(new VocabularyKey(nameof(Street), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetInKana = group.Add(new VocabularyKey(nameof(StreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumber = group.Add(new VocabularyKey(nameof(StreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZone = group.Add(new VocabularyKey(nameof(TimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipCode = group.Add(new VocabularyKey(nameof(ZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Roles = group.Add(new VocabularyKey(nameof(Roles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AttentionToAddressLine { get; private set; }
        public VocabularyKey IsLocationOwner { get; private set; }
        public VocabularyKey IsPostalAddress { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
        public VocabularyKey IsPrimaryTaxRegistration { get; private set; }
        public VocabularyKey IsPrivate { get; private set; }
        public VocabularyKey IsRoleBusiness { get; private set; }
        public VocabularyKey IsRoleDelivery { get; private set; }
        public VocabularyKey IsRoleHome { get; private set; }
        public VocabularyKey IsRoleInvoice { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey Address { get; private set; }
        public VocabularyKey Apartment_RU { get; private set; }
        public VocabularyKey Building_RU { get; private set; }
        public VocabularyKey BuildingCompliment { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CityInKana { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey CountryRegionISOCode { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DistrictName { get; private set; }
        public VocabularyKey DunsNumber { get; private set; }
        public VocabularyKey IsPrivatePostalAddress { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey PostBox { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey Street { get; private set; }
        public VocabularyKey StreetInKana { get; private set; }
        public VocabularyKey StreetNumber { get; private set; }
        public VocabularyKey TimeZone { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey ZipCode { get; private set; }
        public VocabularyKey Roles { get; private set; }


    }
}