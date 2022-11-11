using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressPostalCodeV3EntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressPostalCodeV3EntityVocabulary()
        {
            VocabularyName = "Common Data Model LogisticsAddressPostalCodeV3Entity";
            KeyPrefix = "commonDataModel.logisticsaddresspostalcodev3entity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressPostalCodeV3Entity";

            AddGroup("Common Data Model LogisticsAddressPostalCodeV3Entity Details", group =>
            {
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CityId = group.Add(new VocabularyKey(nameof(CityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CityAlias = group.Add(new VocabularyKey(nameof(CityAlias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountyId = group.Add(new VocabularyKey(nameof(CountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                District = group.Add(new VocabularyKey(nameof(District), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistrictId = group.Add(new VocabularyKey(nameof(DistrictId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street = group.Add(new VocabularyKey(nameof(Street), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumberMinimum = group.Add(new VocabularyKey(nameof(StreetNumberMinimum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumberMaximum = group.Add(new VocabularyKey(nameof(StreetNumberMaximum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumberValidity = group.Add(new VocabularyKey(nameof(StreetNumberValidity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZone = group.Add(new VocabularyKey(nameof(TimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipCode = group.Add(new VocabularyKey(nameof(ZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey City { get; private set; }
        public VocabularyKey CityId { get; private set; }
        public VocabularyKey CityAlias { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey CountyId { get; private set; }
        public VocabularyKey District { get; private set; }
        public VocabularyKey DistrictId { get; private set; }
        public VocabularyKey StateId { get; private set; }
        public VocabularyKey Street { get; private set; }
        public VocabularyKey StreetNumberMinimum { get; private set; }
        public VocabularyKey StreetNumberMaximum { get; private set; }
        public VocabularyKey StreetNumberValidity { get; private set; }
        public VocabularyKey TimeZone { get; private set; }
        public VocabularyKey ZipCode { get; private set; }


    }
}