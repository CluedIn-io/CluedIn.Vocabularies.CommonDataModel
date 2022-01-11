using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSInboundLoadHeaderEntityVocabulary : SimpleVocabulary
    {
        public WHSInboundLoadHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSInboundLoadHeaderEntity";
            KeyPrefix = "commonDataModel.whsinboundloadheaderentity";
            KeySeparator = ".";
            Grouping = "/WHSInboundLoadHeaderEntity";

            AddGroup("Common Data Model WHSInboundLoadHeaderEntity Details", group =>
            {
                ShippingCarrierCode = group.Add(new VocabularyKey(nameof(ShippingCarrierCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActualGrossWeight = group.Add(new VocabularyKey(nameof(ActualGrossWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActualNetWeight = group.Add(new VocabularyKey(nameof(ActualNetWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActualTareWeight = group.Add(new VocabularyKey(nameof(ActualTareWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MasterBillOfLadingId = group.Add(new VocabularyKey(nameof(MasterBillOfLadingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationBookingNumber = group.Add(new VocabularyKey(nameof(TransportationBookingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerId = group.Add(new VocabularyKey(nameof(BrokerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CarNumber = group.Add(new VocabularyKey(nameof(CarNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierGroupId = group.Add(new VocabularyKey(nameof(ShippingCarrierGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedArrivalDateTime = group.Add(new VocabularyKey(nameof(EstimatedArrivalDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InspectionSealNumber = group.Add(new VocabularyKey(nameof(InspectionSealNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadDepth = group.Add(new VocabularyKey(nameof(LoadDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLoadFloorStacked = group.Add(new VocabularyKey(nameof(IsLoadFloorStacked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadHeight = group.Add(new VocabularyKey(nameof(LoadHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadExternalReferenceNumber = group.Add(new VocabularyKey(nameof(LoadExternalReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserDefinedField1 = group.Add(new VocabularyKey(nameof(UserDefinedField1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserDefinedField2 = group.Add(new VocabularyKey(nameof(UserDefinedField2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserDefinedField3 = group.Add(new VocabularyKey(nameof(UserDefinedField3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadWidth = group.Add(new VocabularyKey(nameof(LoadWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProNumber = group.Add(new VocabularyKey(nameof(ProNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SealNumber = group.Add(new VocabularyKey(nameof(SealNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TractorNumber = group.Add(new VocabularyKey(nameof(TractorNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TrailerNumber = group.Add(new VocabularyKey(nameof(TrailerNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VesselName = group.Add(new VocabularyKey(nameof(VesselName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VoyageNumber = group.Add(new VocabularyKey(nameof(VoyageNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CarRegistrationStateId = group.Add(new VocabularyKey(nameof(CarRegistrationStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadId = group.Add(new VocabularyKey(nameof(LoadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierVendorAccountNumber = group.Add(new VocabularyKey(nameof(ShippingCarrierVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLoadSplitShipConfirmAllowed = group.Add(new VocabularyKey(nameof(IsLoadSplitShipConfirmAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ShippingCarrierCode { get; private set; }
public VocabularyKey ActualGrossWeight { get; private set; }
public VocabularyKey ActualNetWeight { get; private set; }
public VocabularyKey ActualTareWeight { get; private set; }
public VocabularyKey MasterBillOfLadingId { get; private set; }
public VocabularyKey TransportationBookingNumber { get; private set; }
public VocabularyKey BrokerId { get; private set; }
public VocabularyKey CarNumber { get; private set; }
public VocabularyKey ShippingCarrierGroupId { get; private set; }
public VocabularyKey ShippingCarrierServiceId { get; private set; }
public VocabularyKey EstimatedArrivalDateTime { get; private set; }
public VocabularyKey InspectionSealNumber { get; private set; }
public VocabularyKey LoadDepth { get; private set; }
public VocabularyKey IsLoadFloorStacked { get; private set; }
public VocabularyKey LoadHeight { get; private set; }
public VocabularyKey LoadExternalReferenceNumber { get; private set; }
public VocabularyKey UserDefinedField1 { get; private set; }
public VocabularyKey UserDefinedField2 { get; private set; }
public VocabularyKey UserDefinedField3 { get; private set; }
public VocabularyKey LoadWidth { get; private set; }
public VocabularyKey ProNumber { get; private set; }
public VocabularyKey SealNumber { get; private set; }
public VocabularyKey TractorNumber { get; private set; }
public VocabularyKey TrailerNumber { get; private set; }
public VocabularyKey VesselName { get; private set; }
public VocabularyKey VoyageNumber { get; private set; }
public VocabularyKey CarRegistrationStateId { get; private set; }
public VocabularyKey LoadId { get; private set; }
public VocabularyKey ShippingCarrierVendorAccountNumber { get; private set; }
public VocabularyKey IsLoadSplitShipConfirmAllowed { get; private set; }


    }
}