using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HotelVocabulary : SimpleVocabulary
    {
        public HotelVocabulary()
        {
            VocabularyName = "Hotel";
            KeyPrefix = "commonDataModel.hotel";
            KeySeparator = ".";
            Grouping = "/Hotel";

            AddGroup("Hotel Details", group =>
            {
                AddressLine1 = group.Add(new VocabularyKey(nameof(AddressLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine3 = group.Add(new VocabularyKey(nameof(AddressLine3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey(nameof(Country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Facilities = group.Add(new VocabularyKey(nameof(Facilities), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HotelId = group.Add(new VocabularyKey(nameof(HotelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateProvince = group.Add(new VocabularyKey(nameof(StateProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Website = group.Add(new VocabularyKey(nameof(Website), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZIPPostalCode = group.Add(new VocabularyKey(nameof(ZIPPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressLine3 { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Facilities { get; private set; }
        public VocabularyKey HotelId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateProvince { get; private set; }
        public VocabularyKey Website { get; private set; }
        public VocabularyKey ZIPPostalCode { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}