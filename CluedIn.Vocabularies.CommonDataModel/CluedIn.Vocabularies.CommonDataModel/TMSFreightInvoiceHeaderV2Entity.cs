using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSFreightInvoiceHeaderV2EntityVocabulary : SimpleVocabulary
    {
        public TMSFreightInvoiceHeaderV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSFreightInvoiceHeaderV2Entity";
            KeyPrefix = "commonDataModel.tmsfreightinvoiceheaderv2entity";
            KeySeparator = ".";
            Grouping = "/TMSFreightInvoiceHeaderV2Entity";

            AddGroup("Common Data Model TMSFreightInvoiceHeaderV2Entity Details", group =>
            {
                ShippingCarrierVendorAccountNumber = group.Add(new VocabularyKey(nameof(ShippingCarrierVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DestinationCountryRegionId = group.Add(new VocabularyKey(nameof(DestinationCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInvoiceAutomaticallyMatched = group.Add(new VocabularyKey(nameof(IsInvoiceAutomaticallyMatched), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultBillOfLadingId = group.Add(new VocabularyKey(nameof(DefaultBillOfLadingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultBookingNumber = group.Add(new VocabularyKey(nameof(DefaultBookingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultShippingCarrierId = group.Add(new VocabularyKey(nameof(DefaultShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(DefaultShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCosigneeName = group.Add(new VocabularyKey(nameof(DefaultCosigneeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DestinationCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DestinationCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultLastCycleCountingDateTime = group.Add(new VocabularyKey(nameof(DefaultLastCycleCountingDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountAmount = group.Add(new VocabularyKey(nameof(CashDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationDistance = group.Add(new VocabularyKey(nameof(TransportationDistance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationDistanceUnitId = group.Add(new VocabularyKey(nameof(TransportationDistanceUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DueDateTime = group.Add(new VocabularyKey(nameof(DueDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InternalInvoiceNumber = group.Add(new VocabularyKey(nameof(InternalInvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceAmount = group.Add(new VocabularyKey(nameof(InvoiceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReferenceNumber = group.Add(new VocabularyKey(nameof(ReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceStatus = group.Add(new VocabularyKey(nameof(InvoiceStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadId = group.Add(new VocabularyKey(nameof(LoadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalQuoteId = group.Add(new VocabularyKey(nameof(OriginalQuoteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayeeVendorAccountNumber = group.Add(new VocabularyKey(nameof(PayeeVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentId = group.Add(new VocabularyKey(nameof(PaymentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProNumberCode = group.Add(new VocabularyKey(nameof(ProNumberCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalFreightQuantity = group.Add(new VocabularyKey(nameof(TotalFreightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultRelatedAccountNumber = group.Add(new VocabularyKey(nameof(DefaultRelatedAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultRelatedOrderNumber = group.Add(new VocabularyKey(nameof(DefaultRelatedOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationRouteCode = group.Add(new VocabularyKey(nameof(TransportationRouteCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SCACCode = group.Add(new VocabularyKey(nameof(SCACCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultShipmentId = group.Add(new VocabularyKey(nameof(DefaultShipmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultFreightHeldUntilDateTime = group.Add(new VocabularyKey(nameof(DefaultFreightHeldUntilDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTrailerNumber = group.Add(new VocabularyKey(nameof(DefaultTrailerNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceVendorAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceNumber = group.Add(new VocabularyKey(nameof(InvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorReference = group.Add(new VocabularyKey(nameof(VendorReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultVesselName = group.Add(new VocabularyKey(nameof(DefaultVesselName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultVoyageNumber = group.Add(new VocabularyKey(nameof(DefaultVoyageNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalFreightWeight = group.Add(new VocabularyKey(nameof(TotalFreightWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FreightWeightUnitId = group.Add(new VocabularyKey(nameof(FreightWeightUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ShippingCarrierVendorAccountNumber { get; private set; }
public VocabularyKey DestinationCountryRegionId { get; private set; }
public VocabularyKey IsInvoiceAutomaticallyMatched { get; private set; }
public VocabularyKey DefaultBillOfLadingId { get; private set; }
public VocabularyKey DefaultBookingNumber { get; private set; }
public VocabularyKey DefaultShippingCarrierId { get; private set; }
public VocabularyKey DefaultShippingCarrierServiceId { get; private set; }
public VocabularyKey CashDiscountCode { get; private set; }
public VocabularyKey DefaultCosigneeName { get; private set; }
public VocabularyKey DestinationCountryRegionISOCode { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey DefaultLastCycleCountingDateTime { get; private set; }
public VocabularyKey CashDiscountAmount { get; private set; }
public VocabularyKey TransportationDistance { get; private set; }
public VocabularyKey TransportationDistanceUnitId { get; private set; }
public VocabularyKey DocumentDate { get; private set; }
public VocabularyKey DocumentNumber { get; private set; }
public VocabularyKey DueDateTime { get; private set; }
public VocabularyKey ExchangeRate { get; private set; }
public VocabularyKey InternalInvoiceNumber { get; private set; }
public VocabularyKey InvoiceAmount { get; private set; }
public VocabularyKey InvoiceDate { get; private set; }
public VocabularyKey ReferenceNumber { get; private set; }
public VocabularyKey InvoiceStatus { get; private set; }
public VocabularyKey LoadId { get; private set; }
public VocabularyKey OriginalQuoteId { get; private set; }
public VocabularyKey PayeeVendorAccountNumber { get; private set; }
public VocabularyKey PaymentId { get; private set; }
public VocabularyKey ProNumberCode { get; private set; }
public VocabularyKey TotalFreightQuantity { get; private set; }
public VocabularyKey DefaultRelatedAccountNumber { get; private set; }
public VocabularyKey DefaultRelatedOrderNumber { get; private set; }
public VocabularyKey TransportationRouteCode { get; private set; }
public VocabularyKey SCACCode { get; private set; }
public VocabularyKey DefaultShipmentId { get; private set; }
public VocabularyKey DefaultFreightHeldUntilDateTime { get; private set; }
public VocabularyKey DefaultTrailerNumber { get; private set; }
public VocabularyKey InvoiceVendorAccountNumber { get; private set; }
public VocabularyKey InvoiceNumber { get; private set; }
public VocabularyKey PaymentTermsName { get; private set; }
public VocabularyKey VendorReference { get; private set; }
public VocabularyKey DefaultVesselName { get; private set; }
public VocabularyKey DefaultVoyageNumber { get; private set; }
public VocabularyKey TotalFreightWeight { get; private set; }
public VocabularyKey FreightWeightUnitId { get; private set; }


    }
}