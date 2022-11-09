using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationCustomerChargeEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationCustomerChargeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationCustomerChargeEntity";
            KeyPrefix = "commonDataModel.tmstransportationcustomerchargeentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationCustomerChargeEntity";

            AddGroup("Common Data Model TMSTransportationCustomerChargeEntity Details", group =>
            {
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierServiceGroupId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationRoutePlanId = group.Add(new VocabularyKey(nameof(TransportationRoutePlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsChargeOverridden = group.Add(new VocabularyKey(nameof(IsChargeOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ShippingCarrierId { get; private set; }
public VocabularyKey ShippingCarrierServiceGroupId { get; private set; }
public VocabularyKey ShippingCarrierServiceId { get; private set; }
public VocabularyKey TransportationRoutePlanId { get; private set; }
public VocabularyKey IsChargeOverridden { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }


    }
}