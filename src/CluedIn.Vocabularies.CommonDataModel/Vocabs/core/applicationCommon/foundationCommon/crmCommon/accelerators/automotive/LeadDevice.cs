using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class LeadDeviceVocabulary : SimpleVocabulary
    {
        public LeadDeviceVocabulary()
        {
            VocabularyName = "Lead Device";
            KeyPrefix = "commonDataModel.leaddevice.automotive";
            KeySeparator = ".";
            Grouping = "/LeadDevice";

            AddGroup("LeadDevice Details for Automotive", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Comments = group.Add(new VocabularyKey(nameof(Comments), "Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceYear = group.Add(new VocabularyKey(nameof(DeviceYear), "Device Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LeadDeviceId = group.Add(new VocabularyKey(nameof(LeadDeviceId), "Lead Device", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Price = group.Add(new VocabularyKey(nameof(Price), "Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceBase = group.Add(new VocabularyKey(nameof(PriceBase), "Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceComments = group.Add(new VocabularyKey(nameof(PriceComments), "Price Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    State = group.Add(new VocabularyKey(nameof(State), "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    URL = group.Add(new VocabularyKey(nameof(URL), "URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Comments { get; private set; }
        public VocabularyKey DeviceYear { get; private set; }
        public VocabularyKey LeadDeviceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey PriceBase { get; private set; }
        public VocabularyKey PriceComments { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}