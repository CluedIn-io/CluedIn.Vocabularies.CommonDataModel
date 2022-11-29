using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class BusinessFacilityVocabulary : SimpleVocabulary
    {
        public BusinessFacilityVocabulary()
        {
            VocabularyName = "Business Facility";
            KeyPrefix = "commonDataModel.businessfacility.automotive";
            KeySeparator = ".";
            Grouping = "/BusinessFacility";

            AddGroup("BusinessFacility Details for Automotive", group =>
            {
			    AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), "Address: City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressCountry = group.Add(new VocabularyKey(nameof(AddressCountry), "Address: Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), "Address: County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), "Address: Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), "Address: Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressName = group.Add(new VocabularyKey(nameof(AddressName), "Address: Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressPostalCode = group.Add(new VocabularyKey(nameof(AddressPostalCode), "Address: ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressStateProvince = group.Add(new VocabularyKey(nameof(AddressStateProvince), "Address: State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressStreet1 = group.Add(new VocabularyKey(nameof(AddressStreet1), "Address: Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressStreet2 = group.Add(new VocabularyKey(nameof(AddressStreet2), "Address: Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressStreet3 = group.Add(new VocabularyKey(nameof(AddressStreet3), "Address: Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BusinessFacilityId = group.Add(new VocabularyKey(nameof(BusinessFacilityId), "Business Facility", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCountry { get; private set; }
        public VocabularyKey AddressCounty { get; private set; }
        public VocabularyKey AddressLatitude { get; private set; }
        public VocabularyKey AddressLongitude { get; private set; }
        public VocabularyKey AddressName { get; private set; }
        public VocabularyKey AddressPostalCode { get; private set; }
        public VocabularyKey AddressStateProvince { get; private set; }
        public VocabularyKey AddressStreet1 { get; private set; }
        public VocabularyKey AddressStreet2 { get; private set; }
        public VocabularyKey AddressStreet3 { get; private set; }
        public VocabularyKey BusinessFacilityId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}