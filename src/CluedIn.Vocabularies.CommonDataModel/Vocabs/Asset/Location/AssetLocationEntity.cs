using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetLocationEntityVocabulary : SimpleVocabulary
    {
        public AssetLocationEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetLocationEntity";
            KeyPrefix = "commonDataModel.assetlocationentity";
            KeySeparator = ".";
            Grouping = "/AssetLocationEntity";

            AddGroup("Common Data Model AssetLocationEntity Details", group =>
            {
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCityInKana = group.Add(new VocabularyKey(nameof(AddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreetInKana = group.Add(new VocabularyKey(nameof(AddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AddressCountryRegionId { get; private set; }
        public VocabularyKey AddressCountryRegionISOCode { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey AddressCounty { get; private set; }
        public VocabularyKey AddressCityInKana { get; private set; }
        public VocabularyKey AddressStreetInKana { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }


    }
}