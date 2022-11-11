using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HotelVocabulary : SimpleVocabulary
    {
        public HotelVocabulary()
        {
            VocabularyName = "Common Data Model Hotel";
            KeyPrefix = "commonDataModel.hotel";
            KeySeparator = ".";
            Grouping = "/Hotel";

            AddGroup("Common Data Model Hotel Details", group =>
            {
                addressLine1 = group.Add(new VocabularyKey(nameof(addressLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressLine2 = group.Add(new VocabularyKey(nameof(addressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressLine3 = group.Add(new VocabularyKey(nameof(addressLine3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                city = group.Add(new VocabularyKey(nameof(city), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                country = group.Add(new VocabularyKey(nameof(country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                facilities = group.Add(new VocabularyKey(nameof(facilities), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                hotelId = group.Add(new VocabularyKey(nameof(hotelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateProvince = group.Add(new VocabularyKey(nameof(stateProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                website = group.Add(new VocabularyKey(nameof(website), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZIPPostalCode = group.Add(new VocabularyKey(nameof(ZIPPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey addressLine1 { get; private set; }
        public VocabularyKey addressLine2 { get; private set; }
        public VocabularyKey addressLine3 { get; private set; }
        public VocabularyKey city { get; private set; }
        public VocabularyKey country { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey facilities { get; private set; }
        public VocabularyKey hotelId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateProvince { get; private set; }
        public VocabularyKey website { get; private set; }
        public VocabularyKey ZIPPostalCode { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}