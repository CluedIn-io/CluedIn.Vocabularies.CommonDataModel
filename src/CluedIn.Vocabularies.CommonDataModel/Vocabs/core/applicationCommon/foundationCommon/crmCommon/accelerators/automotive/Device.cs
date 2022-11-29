using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceVocabulary : SimpleVocabulary
    {
        public DeviceVocabulary()
        {
            VocabularyName = "Device";
            KeyPrefix = "commonDataModel.device.automotive";
            KeySeparator = ".";
            Grouping = "/Device";

            AddGroup("Device Details for Automotive", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ChassisNumber = group.Add(new VocabularyKey(nameof(ChassisNumber), "Chassis Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Condition = group.Add(new VocabularyKey(nameof(Condition), "Condition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceId = group.Add(new VocabularyKey(nameof(DeviceId), "Device", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceNumber = group.Add(new VocabularyKey(nameof(DeviceNumber), "Device Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ListPrice = group.Add(new VocabularyKey(nameof(ListPrice), "List Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ListPriceBase = group.Add(new VocabularyKey(nameof(ListPriceBase), "List Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ListPriceComments = group.Add(new VocabularyKey(nameof(ListPriceComments), "List Price Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RegistrationNumber = group.Add(new VocabularyKey(nameof(RegistrationNumber), "Registration Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    URL = group.Add(new VocabularyKey(nameof(URL), "URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    VendorsStockNumber = group.Add(new VocabularyKey(nameof(VendorsStockNumber), "Vendors Stock Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VIN = group.Add(new VocabularyKey(nameof(VIN), "VIN", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Year = group.Add(new VocabularyKey(nameof(Year), "Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ChassisNumber { get; private set; }
        public VocabularyKey Condition { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceId { get; private set; }
        public VocabularyKey DeviceNumber { get; private set; }
        public VocabularyKey ListPrice { get; private set; }
        public VocabularyKey ListPriceBase { get; private set; }
        public VocabularyKey ListPriceComments { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RegistrationNumber { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey VendorsStockNumber { get; private set; }
        public VocabularyKey VIN { get; private set; }
        public VocabularyKey Year { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}