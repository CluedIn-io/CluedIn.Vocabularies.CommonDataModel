using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DeviceVocabulary : SimpleVocabulary
    {
        public DeviceVocabulary()
        {
            VocabularyName = "Device";
            KeyPrefix = "commonDataModel.device.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Device";

            AddGroup("Device Details for ElectronicMedicalRecords", group =>
            {
			    CarrierAIDC = group.Add(new VocabularyKey(nameof(CarrierAIDC), "UDI Carrier AIDC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceId = group.Add(new VocabularyKey(nameof(DeviceId), "Device", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceNumber = group.Add(new VocabularyKey(nameof(DeviceNumber), "Device Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceStatus = group.Add(new VocabularyKey(nameof(DeviceStatus), "Device Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), "Expiration Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LotNumber = group.Add(new VocabularyKey(nameof(LotNumber), "Lot Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Manufacturer = group.Add(new VocabularyKey(nameof(Manufacturer), "Manufacturer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ManufacturerDate = group.Add(new VocabularyKey(nameof(ManufacturerDate), "Manufacturer Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Model = group.Add(new VocabularyKey(nameof(Model), "Model", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UDI = group.Add(new VocabularyKey(nameof(UDI), "UDI", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UDICarrierHRF = group.Add(new VocabularyKey(nameof(UDICarrierHRF), "UDI Carrier HRF", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UDIEntryType = group.Add(new VocabularyKey(nameof(UDIEntryType), "UDI Entry Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UDIIssuer = group.Add(new VocabularyKey(nameof(UDIIssuer), "UDI Issuer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UdiJurisdiction = group.Add(new VocabularyKey(nameof(UdiJurisdiction), "Jurisdiction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    URL = group.Add(new VocabularyKey(nameof(URL), "URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Version = group.Add(new VocabularyKey(nameof(Version), "Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarrierAIDC { get; private set; }
        public VocabularyKey DeviceId { get; private set; }
        public VocabularyKey DeviceNumber { get; private set; }
        public VocabularyKey DeviceStatus { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey LotNumber { get; private set; }
        public VocabularyKey Manufacturer { get; private set; }
        public VocabularyKey ManufacturerDate { get; private set; }
        public VocabularyKey Model { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey UDI { get; private set; }
        public VocabularyKey UDICarrierHRF { get; private set; }
        public VocabularyKey UDIEntryType { get; private set; }
        public VocabularyKey UDIIssuer { get; private set; }
        public VocabularyKey UdiJurisdiction { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey Version { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}