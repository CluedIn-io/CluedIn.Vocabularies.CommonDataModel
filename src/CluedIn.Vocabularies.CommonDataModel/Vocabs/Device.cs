using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DeviceVocabulary : SimpleVocabulary
    {
        public DeviceVocabulary()
        {
            VocabularyName = "Device";
            KeyPrefix = "commonDataModel.device";
            KeySeparator = ".";
            Grouping = "/Device";

            AddGroup("Device Details", group =>
            {
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CreatedBy = group.Add(new VocabularyKey(nameof(CreatedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ModifiedBy = group.Add(new VocabularyKey(nameof(ModifiedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OwnerId = group.Add(new VocabularyKey(nameof(OwnerId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwningBusinessUnit = group.Add(new VocabularyKey(nameof(OwningBusinessUnit), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OwningTeam = group.Add(new VocabularyKey(nameof(OwningTeam), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DeviceId = group.Add(new VocabularyKey(nameof(DeviceId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StateCode_display = group.Add(new VocabularyKey(nameof(StateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StatusCode_display = group.Add(new VocabularyKey(nameof(StatusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarrierAIDC = group.Add(new VocabularyKey(nameof(CarrierAIDC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeviceNumber = group.Add(new VocabularyKey(nameof(DeviceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeviceStatus = group.Add(new VocabularyKey(nameof(DeviceStatus), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DeviceStatus_display = group.Add(new VocabularyKey(nameof(DeviceStatus_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                LotNumber = group.Add(new VocabularyKey(nameof(LotNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Manufacturer = group.Add(new VocabularyKey(nameof(Manufacturer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManufacturerDate = group.Add(new VocabularyKey(nameof(ManufacturerDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Model = group.Add(new VocabularyKey(nameof(Model), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Owner = group.Add(new VocabularyKey(nameof(Owner), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                Patient = group.Add(new VocabularyKey(nameof(Patient), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                UDI = group.Add(new VocabularyKey(nameof(UDI), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UDICarrierHRF = group.Add(new VocabularyKey(nameof(UDICarrierHRF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UDIEntryType = group.Add(new VocabularyKey(nameof(UDIEntryType), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UDIEntryType_display = group.Add(new VocabularyKey(nameof(UDIEntryType_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UDIIssuer = group.Add(new VocabularyKey(nameof(UDIIssuer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UdiJurisdiction = group.Add(new VocabularyKey(nameof(UdiJurisdiction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Version = group.Add(new VocabularyKey(nameof(Version), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedBy { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedBy { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OwnerId { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwningBusinessUnit { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey OwningTeam { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey DeviceId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StateCode_display { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StatusCode_display { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CarrierAIDC { get; private set; }
        public VocabularyKey DeviceNumber { get; private set; }
        public VocabularyKey DeviceStatus { get; private set; }
        public VocabularyKey DeviceStatus_display { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey LotNumber { get; private set; }
        public VocabularyKey Manufacturer { get; private set; }
        public VocabularyKey ManufacturerDate { get; private set; }
        public VocabularyKey Model { get; private set; }
        public VocabularyKey Owner { get; private set; }
        public VocabularyKey Patient { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey UDI { get; private set; }
        public VocabularyKey UDICarrierHRF { get; private set; }
        public VocabularyKey UDIEntryType { get; private set; }
        public VocabularyKey UDIEntryType_display { get; private set; }
        public VocabularyKey UDIIssuer { get; private set; }
        public VocabularyKey UdiJurisdiction { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey Version { get; private set; }
    }
}