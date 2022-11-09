using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationVendorChargeManualOverrideRateEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationVendorChargeManualOverrideRateEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationVendorChargeManualOverrideRateEntity";
            KeyPrefix = "commonDataModel.tmstransportationvendorchargemanualoverriderateentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationVendorChargeManualOverrideRateEntity";

            AddGroup("Common Data Model TMSTransportationVendorChargeManualOverrideRateEntity Details", group =>
            {
                AccessorialChargeMasterCode = group.Add(new VocabularyKey(nameof(AccessorialChargeMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RateUnitPriceCurrencyCode = group.Add(new VocabularyKey(nameof(RateUnitPriceCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RateUnitPrice = group.Add(new VocabularyKey(nameof(RateUnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RateQuantity = group.Add(new VocabularyKey(nameof(RateQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationVendorChargeVendorAccountNumber = group.Add(new VocabularyKey(nameof(TransportationVendorChargeVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccessorialChargeMasterCode { get; private set; }
public VocabularyKey ShippingCarrierId { get; private set; }
public VocabularyKey ShippingCarrierServiceId { get; private set; }
public VocabularyKey RateUnitPriceCurrencyCode { get; private set; }
public VocabularyKey RateUnitPrice { get; private set; }
public VocabularyKey RateQuantity { get; private set; }
public VocabularyKey TransportationVendorChargeVendorAccountNumber { get; private set; }


    }
}