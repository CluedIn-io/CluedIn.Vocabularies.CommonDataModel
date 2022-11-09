using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DeviceVocabulary : SimpleVocabulary
    {
        public DeviceVocabulary()
        {
            VocabularyName = "Common Data Model Device";
            KeyPrefix = "commonDataModel.device";
            KeySeparator = ".";
            Grouping = "/Device";

            AddGroup("Common Data Model Device Details", group =>
            {
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)); 
createdBy = group.Add(new VocabularyKey(nameof(createdBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)); 
modifiedBy = group.Add(new VocabularyKey(nameof(modifiedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
ownerId = group.Add(new VocabularyKey(nameof(ownerId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
owningBusinessUnit = group.Add(new VocabularyKey(nameof(owningBusinessUnit), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
owningUser = group.Add(new VocabularyKey(nameof(owningUser), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
owningTeam = group.Add(new VocabularyKey(nameof(owningTeam), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
versionNumber = group.Add(new VocabularyKey(nameof(versionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
deviceId = group.Add(new VocabularyKey(nameof(deviceId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
stateCode_display = group.Add(new VocabularyKey(nameof(stateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
statusCode_display = group.Add(new VocabularyKey(nameof(statusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
carrierAIDC = group.Add(new VocabularyKey(nameof(carrierAIDC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
deviceNumber = group.Add(new VocabularyKey(nameof(deviceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
deviceStatus = group.Add(new VocabularyKey(nameof(deviceStatus), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
deviceStatus_display = group.Add(new VocabularyKey(nameof(deviceStatus_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
expirationDate = group.Add(new VocabularyKey(nameof(expirationDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)); 
location = group.Add(new VocabularyKey(nameof(location), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
lotNumber = group.Add(new VocabularyKey(nameof(lotNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
manufacturer = group.Add(new VocabularyKey(nameof(manufacturer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
manufacturerDate = group.Add(new VocabularyKey(nameof(manufacturerDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)); 
model = group.Add(new VocabularyKey(nameof(model), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
owner = group.Add(new VocabularyKey(nameof(owner), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
patient = group.Add(new VocabularyKey(nameof(patient), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
type = group.Add(new VocabularyKey(nameof(type), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
UDI = group.Add(new VocabularyKey(nameof(UDI), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UDICarrierHRF = group.Add(new VocabularyKey(nameof(UDICarrierHRF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UDIEntryType = group.Add(new VocabularyKey(nameof(UDIEntryType), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
UDIEntryType_display = group.Add(new VocabularyKey(nameof(UDIEntryType_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UDIIssuer = group.Add(new VocabularyKey(nameof(UDIIssuer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
udiJurisdiction = group.Add(new VocabularyKey(nameof(udiJurisdiction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
version = group.Add(new VocabularyKey(nameof(version), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey createdOn { get; private set; }
public VocabularyKey createdBy { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey modifiedBy { get; private set; }
public VocabularyKey createdOnBehalfBy { get; private set; }
public VocabularyKey modifiedOnBehalfBy { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey ownerId { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey owningBusinessUnit { get; private set; }
public VocabularyKey owningUser { get; private set; }
public VocabularyKey owningTeam { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
public VocabularyKey versionNumber { get; private set; }
public VocabularyKey deviceId { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey stateCode_display { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey statusCode_display { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey carrierAIDC { get; private set; }
public VocabularyKey deviceNumber { get; private set; }
public VocabularyKey deviceStatus { get; private set; }
public VocabularyKey deviceStatus_display { get; private set; }
public VocabularyKey expirationDate { get; private set; }
public VocabularyKey location { get; private set; }
public VocabularyKey lotNumber { get; private set; }
public VocabularyKey manufacturer { get; private set; }
public VocabularyKey manufacturerDate { get; private set; }
public VocabularyKey model { get; private set; }
public VocabularyKey owner { get; private set; }
public VocabularyKey patient { get; private set; }
public VocabularyKey type { get; private set; }
public VocabularyKey UDI { get; private set; }
public VocabularyKey UDICarrierHRF { get; private set; }
public VocabularyKey UDIEntryType { get; private set; }
public VocabularyKey UDIEntryType_display { get; private set; }
public VocabularyKey UDIIssuer { get; private set; }
public VocabularyKey udiJurisdiction { get; private set; }
public VocabularyKey URL { get; private set; }
public VocabularyKey version { get; private set; }


    }
}