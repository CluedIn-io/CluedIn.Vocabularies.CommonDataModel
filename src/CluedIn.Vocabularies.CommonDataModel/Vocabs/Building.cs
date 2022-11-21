using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BuildingVocabulary : SimpleVocabulary
    {
        public BuildingVocabulary()
        {
            VocabularyName = "Building";
            KeyPrefix = "commonDataModel.building";
            KeySeparator = ".";
            Grouping = "/Building";

            AddGroup("Building Details", group =>
            {
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccessibleToilets = group.Add(new VocabularyKey(nameof(AccessibleToilets), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdditionalFacilities = group.Add(new VocabularyKey(nameof(AdditionalFacilities), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressComposite = group.Add(new VocabularyKey(nameof(AddressComposite), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine1 = group.Add(new VocabularyKey(nameof(AddressLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine3 = group.Add(new VocabularyKey(nameof(AddressLine3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuildingId = group.Add(new VocabularyKey(nameof(BuildingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Cost = group.Add(new VocabularyKey(nameof(Cost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostBase = group.Add(new VocabularyKey(nameof(CostBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey(nameof(Country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisabledAccess = group.Add(new VocabularyKey(nameof(DisabledAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisabledParking = group.Add(new VocabularyKey(nameof(DisabledParking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedCapacity = group.Add(new VocabularyKey(nameof(EstimatedCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfRooms = group.Add(new VocabularyKey(nameof(NumberOfRooms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublicTelephoneAvailable = group.Add(new VocabularyKey(nameof(PublicTelephoneAvailable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateProvince = group.Add(new VocabularyKey(nameof(StateProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telephone1 = group.Add(new VocabularyKey(nameof(Telephone1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telephone2 = group.Add(new VocabularyKey(nameof(Telephone2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telephone3 = group.Add(new VocabularyKey(nameof(Telephone3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Website = group.Add(new VocabularyKey(nameof(Website), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WiFiAvailable = group.Add(new VocabularyKey(nameof(WiFiAvailable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WiFiPassword = group.Add(new VocabularyKey(nameof(WiFiPassword), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WiFiSSID = group.Add(new VocabularyKey(nameof(WiFiSSID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AccessibleToilets { get; private set; }
        public VocabularyKey AdditionalFacilities { get; private set; }
        public VocabularyKey AddressComposite { get; private set; }
        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressLine3 { get; private set; }
        public VocabularyKey BuildingId { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey Cost { get; private set; }
        public VocabularyKey CostBase { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisabledAccess { get; private set; }
        public VocabularyKey DisabledParking { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey EstimatedCapacity { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NumberOfRooms { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey PublicTelephoneAvailable { get; private set; }
        public VocabularyKey StateProvince { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey Website { get; private set; }
        public VocabularyKey WiFiAvailable { get; private set; }
        public VocabularyKey WiFiPassword { get; private set; }
        public VocabularyKey WiFiSSID { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}