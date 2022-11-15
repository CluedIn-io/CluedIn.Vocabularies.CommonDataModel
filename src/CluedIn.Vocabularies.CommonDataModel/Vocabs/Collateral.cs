using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CollateralVocabulary : SimpleVocabulary
    {
        public CollateralVocabulary()
        {
            VocabularyName = "Collateral";
            KeyPrefix = "commonDataModel.collateral";
            KeySeparator = ".";
            Grouping = "/Collateral";

            AddGroup("Collateral Details", group =>
            {
                CollateralId = group.Add(new VocabularyKey(nameof(CollateralId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine1 = group.Add(new VocabularyKey(nameof(AddressLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine3 = group.Add(new VocabularyKey(nameof(AddressLine3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Latitude = group.Add(new VocabularyKey(nameof(Latitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalDescription = group.Add(new VocabularyKey(nameof(LegalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Longitude = group.Add(new VocabularyKey(nameof(Longitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberofUnits = group.Add(new VocabularyKey(nameof(NumberofUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealEstateType = group.Add(new VocabularyKey(nameof(RealEstateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateProvince = group.Add(new VocabularyKey(nameof(StateProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearBuilt = group.Add(new VocabularyKey(nameof(YearBuilt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZIPPostalCode = group.Add(new VocabularyKey(nameof(ZIPPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CollateralId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressLine3 { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey LegalDescription { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey NumberofUnits { get; private set; }
        public VocabularyKey RealEstateType { get; private set; }
        public VocabularyKey StateProvince { get; private set; }
        public VocabularyKey YearBuilt { get; private set; }
        public VocabularyKey ZIPPostalCode { get; private set; }
    }
}