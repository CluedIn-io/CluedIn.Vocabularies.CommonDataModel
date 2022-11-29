using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class HotelVocabulary : SimpleVocabulary
    {
        public HotelVocabulary()
        {
            VocabularyName = "Hotel";
            KeyPrefix = "commonDataModel.hotel.eventmanagement";
            KeySeparator = ".";
            Grouping = "/Hotel";

            AddGroup("Hotel Details for EventManagement", group =>
            {
			    HotelId = group.Add(new VocabularyKey(nameof(HotelId), "Hotel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine1 = group.Add(new VocabularyKey(nameof(AddressLine1), "Address Line 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), "Address Line 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine3 = group.Add(new VocabularyKey(nameof(AddressLine3), "Address Line 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    City = group.Add(new VocabularyKey(nameof(City), "City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Facilities = group.Add(new VocabularyKey(nameof(Facilities), "Facilities", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateProvince = group.Add(new VocabularyKey(nameof(StateProvince), "State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Website = group.Add(new VocabularyKey(nameof(Website), "Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    ZIPPostalCode = group.Add(new VocabularyKey(nameof(ZIPPostalCode), "ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey HotelId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressLine3 { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Facilities { get; private set; }
        public VocabularyKey StateProvince { get; private set; }
        public VocabularyKey Website { get; private set; }
        public VocabularyKey ZIPPostalCode { get; private set; }
    }
}