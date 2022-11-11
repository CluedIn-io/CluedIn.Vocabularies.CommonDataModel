using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxAuthorityEntityVocabulary : SimpleVocabulary
    {
        public TaxAuthorityEntityVocabulary()
        {
            VocabularyName = "TaxAuthorityEntity";
            KeyPrefix = "commonDataModel.taxauthorityentity";
            KeySeparator = ".";
            Grouping = "/TaxAuthorityEntity";

            AddGroup("TaxAuthorityEntity Details", group =>
            {
                TaxAuthorityCode = group.Add(new VocabularyKey(nameof(TaxAuthorityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAuthorityIdentification = group.Add(new VocabularyKey(nameof(TaxAuthorityIdentification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportLayout = group.Add(new VocabularyKey(nameof(ReportLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNum = group.Add(new VocabularyKey(nameof(VendorAccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundOffType = group.Add(new VocabularyKey(nameof(RoundOffType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundOff = group.Add(new VocabularyKey(nameof(RoundOff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuildingCompliment = group.Add(new VocabularyKey(nameof(BuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CellularPhone = group.Add(new VocabularyKey(nameof(CellularPhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey(nameof(Country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryISOCode = group.Add(new VocabularyKey(nameof(CountryISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistrictName = group.Add(new VocabularyKey(nameof(DistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Latitude = group.Add(new VocabularyKey(nameof(Latitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Longitude = group.Add(new VocabularyKey(nameof(Longitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Pager = group.Add(new VocabularyKey(nameof(Pager), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey(nameof(Phone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneLocal = group.Add(new VocabularyKey(nameof(PhoneLocal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostBox = group.Add(new VocabularyKey(nameof(PostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SMS = group.Add(new VocabularyKey(nameof(SMS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street = group.Add(new VocabularyKey(nameof(Street), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumber = group.Add(new VocabularyKey(nameof(StreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeleFax = group.Add(new VocabularyKey(nameof(TeleFax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telex = group.Add(new VocabularyKey(nameof(Telex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZone = group.Add(new VocabularyKey(nameof(TimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipCode = group.Add(new VocabularyKey(nameof(ZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Agency = group.Add(new VocabularyKey(nameof(Agency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaxAuthorityCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TaxAuthorityIdentification { get; private set; }
        public VocabularyKey ReportLayout { get; private set; }
        public VocabularyKey VendorAccountNum { get; private set; }
        public VocabularyKey RoundOffType { get; private set; }
        public VocabularyKey RoundOff { get; private set; }
        public VocabularyKey BuildingCompliment { get; private set; }
        public VocabularyKey CellularPhone { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey CountryISOCode { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey DistrictName { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey Pager { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey PhoneLocal { get; private set; }
        public VocabularyKey PostBox { get; private set; }
        public VocabularyKey SMS { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey Street { get; private set; }
        public VocabularyKey StreetNumber { get; private set; }
        public VocabularyKey TeleFax { get; private set; }
        public VocabularyKey Telex { get; private set; }
        public VocabularyKey TimeZone { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey ZipCode { get; private set; }
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Agency { get; private set; }


    }
}