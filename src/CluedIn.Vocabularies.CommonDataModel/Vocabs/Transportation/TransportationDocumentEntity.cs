using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TransportationDocumentEntityVocabulary : SimpleVocabulary
    {
        public TransportationDocumentEntityVocabulary()
        {
            VocabularyName = "TransportationDocumentEntity";
            KeyPrefix = "commonDataModel.transportationdocumententity";
            KeySeparator = ".";
            Grouping = "/TransportationDocumentEntity";

            AddGroup("TransportationDocumentEntity Details", group =>
            {
                Carrier = group.Add(new VocabularyKey(nameof(Carrier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarrierType = group.Add(new VocabularyKey(nameof(CarrierType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDateTime = group.Add(new VocabularyKey(nameof(DocumentDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintTransportationDetails = group.Add(new VocabularyKey(nameof(PrintTransportationDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EconomicActivity = group.Add(new VocabularyKey(nameof(EconomicActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingDateAndTime = group.Add(new VocabularyKey(nameof(LoadingDateAndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RiskLevelOfTheLoad = group.Add(new VocabularyKey(nameof(RiskLevelOfTheLoad), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Package = group.Add(new VocabularyKey(nameof(Package), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingDateAndTime = group.Add(new VocabularyKey(nameof(UnloadingDateAndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IssuedByPersonnelNumber = group.Add(new VocabularyKey(nameof(IssuedByPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingBuildingCompliment = group.Add(new VocabularyKey(nameof(LoadingBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingCity = group.Add(new VocabularyKey(nameof(LoadingCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingCountryRegionId = group.Add(new VocabularyKey(nameof(LoadingCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingCountryRegionISOCode = group.Add(new VocabularyKey(nameof(LoadingCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingCounty = group.Add(new VocabularyKey(nameof(LoadingCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingDistrictName = group.Add(new VocabularyKey(nameof(LoadingDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingDunsNumber = group.Add(new VocabularyKey(nameof(LoadingDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingIsPrivate = group.Add(new VocabularyKey(nameof(LoadingIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingLatitude = group.Add(new VocabularyKey(nameof(LoadingLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingLocationId = group.Add(new VocabularyKey(nameof(LoadingLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingLongitude = group.Add(new VocabularyKey(nameof(LoadingLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingPostBox = group.Add(new VocabularyKey(nameof(LoadingPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingState = group.Add(new VocabularyKey(nameof(LoadingState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingStreet = group.Add(new VocabularyKey(nameof(LoadingStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingStreetNumber = group.Add(new VocabularyKey(nameof(LoadingStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingTimeZone = group.Add(new VocabularyKey(nameof(LoadingTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingValidFrom = group.Add(new VocabularyKey(nameof(LoadingValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingValidTo = group.Add(new VocabularyKey(nameof(LoadingValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingAddress = group.Add(new VocabularyKey(nameof(LoadingAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingZipCode = group.Add(new VocabularyKey(nameof(LoadingZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadingDescription = group.Add(new VocabularyKey(nameof(LoadingDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingBuildingCompliment = group.Add(new VocabularyKey(nameof(UnloadingBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingCity = group.Add(new VocabularyKey(nameof(UnloadingCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingCountryRegionId = group.Add(new VocabularyKey(nameof(UnloadingCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingCountryRegionISOCode = group.Add(new VocabularyKey(nameof(UnloadingCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingCounty = group.Add(new VocabularyKey(nameof(UnloadingCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingDistrictName = group.Add(new VocabularyKey(nameof(UnloadingDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingDunsNumber = group.Add(new VocabularyKey(nameof(UnloadingDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingIsPrivate = group.Add(new VocabularyKey(nameof(UnloadingIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingLatitude = group.Add(new VocabularyKey(nameof(UnloadingLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingLocationId = group.Add(new VocabularyKey(nameof(UnloadingLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingLongitude = group.Add(new VocabularyKey(nameof(UnloadingLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingPostBox = group.Add(new VocabularyKey(nameof(UnloadingPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingState = group.Add(new VocabularyKey(nameof(UnloadingState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingStreet = group.Add(new VocabularyKey(nameof(UnloadingStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingStreetNumber = group.Add(new VocabularyKey(nameof(UnloadingStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingTimeZone = group.Add(new VocabularyKey(nameof(UnloadingTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingValidFrom = group.Add(new VocabularyKey(nameof(UnloadingValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingValidTo = group.Add(new VocabularyKey(nameof(UnloadingValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingAddress = group.Add(new VocabularyKey(nameof(UnloadingAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingZipCode = group.Add(new VocabularyKey(nameof(UnloadingZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnloadingDescription = group.Add(new VocabularyKey(nameof(UnloadingDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumber = group.Add(new VocabularyKey(nameof(RegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrailerRegistrationNumber = group.Add(new VocabularyKey(nameof(TrailerRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DriverName = group.Add(new VocabularyKey(nameof(DriverName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DriverPersonnelNumber = group.Add(new VocabularyKey(nameof(DriverPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VehicleModel = group.Add(new VocabularyKey(nameof(VehicleModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Carrier { get; private set; }
        public VocabularyKey CarrierType { get; private set; }
        public VocabularyKey DocumentDateTime { get; private set; }
        public VocabularyKey PrintTransportationDetails { get; private set; }
        public VocabularyKey EconomicActivity { get; private set; }
        public VocabularyKey LoadingDateAndTime { get; private set; }
        public VocabularyKey RiskLevelOfTheLoad { get; private set; }
        public VocabularyKey Package { get; private set; }
        public VocabularyKey UnloadingDateAndTime { get; private set; }
        public VocabularyKey LineId { get; private set; }
        public VocabularyKey IssuedByPersonnelNumber { get; private set; }
        public VocabularyKey LoadingBuildingCompliment { get; private set; }
        public VocabularyKey LoadingCity { get; private set; }
        public VocabularyKey LoadingCountryRegionId { get; private set; }
        public VocabularyKey LoadingCountryRegionISOCode { get; private set; }
        public VocabularyKey LoadingCounty { get; private set; }
        public VocabularyKey LoadingDistrictName { get; private set; }
        public VocabularyKey LoadingDunsNumber { get; private set; }
        public VocabularyKey LoadingIsPrivate { get; private set; }
        public VocabularyKey LoadingLatitude { get; private set; }
        public VocabularyKey LoadingLocationId { get; private set; }
        public VocabularyKey LoadingLongitude { get; private set; }
        public VocabularyKey LoadingPostBox { get; private set; }
        public VocabularyKey LoadingState { get; private set; }
        public VocabularyKey LoadingStreet { get; private set; }
        public VocabularyKey LoadingStreetNumber { get; private set; }
        public VocabularyKey LoadingTimeZone { get; private set; }
        public VocabularyKey LoadingValidFrom { get; private set; }
        public VocabularyKey LoadingValidTo { get; private set; }
        public VocabularyKey LoadingAddress { get; private set; }
        public VocabularyKey LoadingZipCode { get; private set; }
        public VocabularyKey LoadingDescription { get; private set; }
        public VocabularyKey UnloadingBuildingCompliment { get; private set; }
        public VocabularyKey UnloadingCity { get; private set; }
        public VocabularyKey UnloadingCountryRegionId { get; private set; }
        public VocabularyKey UnloadingCountryRegionISOCode { get; private set; }
        public VocabularyKey UnloadingCounty { get; private set; }
        public VocabularyKey UnloadingDistrictName { get; private set; }
        public VocabularyKey UnloadingDunsNumber { get; private set; }
        public VocabularyKey UnloadingIsPrivate { get; private set; }
        public VocabularyKey UnloadingLatitude { get; private set; }
        public VocabularyKey UnloadingLocationId { get; private set; }
        public VocabularyKey UnloadingLongitude { get; private set; }
        public VocabularyKey UnloadingPostBox { get; private set; }
        public VocabularyKey UnloadingState { get; private set; }
        public VocabularyKey UnloadingStreet { get; private set; }
        public VocabularyKey UnloadingStreetNumber { get; private set; }
        public VocabularyKey UnloadingTimeZone { get; private set; }
        public VocabularyKey UnloadingValidFrom { get; private set; }
        public VocabularyKey UnloadingValidTo { get; private set; }
        public VocabularyKey UnloadingAddress { get; private set; }
        public VocabularyKey UnloadingZipCode { get; private set; }
        public VocabularyKey UnloadingDescription { get; private set; }
        public VocabularyKey RegistrationNumber { get; private set; }
        public VocabularyKey TrailerRegistrationNumber { get; private set; }
        public VocabularyKey DriverName { get; private set; }
        public VocabularyKey DriverPersonnelNumber { get; private set; }
        public VocabularyKey VehicleModel { get; private set; }


    }
}