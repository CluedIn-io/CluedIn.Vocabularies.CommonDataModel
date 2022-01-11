using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSShippingCarrierRatingProfileEntityVocabulary : SimpleVocabulary
    {
        public TMSShippingCarrierRatingProfileEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSShippingCarrierRatingProfileEntity";
            KeyPrefix = "commonDataModel.tmsshippingcarrierratingprofileentity";
            KeySeparator = ".";
            Grouping = "/TMSShippingCarrierRatingProfileEntity";

            AddGroup("Common Data Model TMSShippingCarrierRatingProfileEntity Details", group =>
            {
                EffectiveEndDateTime = group.Add(new VocabularyKey(nameof(EffectiveEndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EffectiveStartDateTime = group.Add(new VocabularyKey(nameof(EffectiveStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FreightRateEngineId = group.Add(new VocabularyKey(nameof(FreightRateEngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FreightRateMasterId = group.Add(new VocabularyKey(nameof(FreightRateMasterId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginDestinationSiteId = group.Add(new VocabularyKey(nameof(OriginDestinationSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginDestinationWarehouseId = group.Add(new VocabularyKey(nameof(OriginDestinationWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CarrierFuelIndexCode = group.Add(new VocabularyKey(nameof(CarrierFuelIndexCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfileId = group.Add(new VocabularyKey(nameof(ProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfileName = group.Add(new VocabularyKey(nameof(ProfileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationTransitTimeEngineId = group.Add(new VocabularyKey(nameof(TransportationTransitTimeEngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey EffectiveEndDateTime { get; private set; }
public VocabularyKey EffectiveStartDateTime { get; private set; }
public VocabularyKey FreightRateEngineId { get; private set; }
public VocabularyKey FreightRateMasterId { get; private set; }
public VocabularyKey OriginDestinationSiteId { get; private set; }
public VocabularyKey OriginDestinationWarehouseId { get; private set; }
public VocabularyKey CarrierFuelIndexCode { get; private set; }
public VocabularyKey ShippingCarrierId { get; private set; }
public VocabularyKey ProfileId { get; private set; }
public VocabularyKey ProfileName { get; private set; }
public VocabularyKey TransportationTransitTimeEngineId { get; private set; }


    }
}