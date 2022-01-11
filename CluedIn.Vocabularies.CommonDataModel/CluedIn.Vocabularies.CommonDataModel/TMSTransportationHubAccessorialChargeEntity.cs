using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationHubAccessorialChargeEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationHubAccessorialChargeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationHubAccessorialChargeEntity";
            KeyPrefix = "commonDataModel.tmstransportationhubaccessorialchargeentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationHubAccessorialChargeEntity";

            AddGroup("Common Data Model TMSTransportationHubAccessorialChargeEntity Details", group =>
            {
                AccessorialChargeMasterCode = group.Add(new VocabularyKey(nameof(AccessorialChargeMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationBillingGroupId = group.Add(new VocabularyKey(nameof(TransportationBillingGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalChargeCode = group.Add(new VocabularyKey(nameof(ExternalChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeId = group.Add(new VocabularyKey(nameof(ChargeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationHubId = group.Add(new VocabularyKey(nameof(TransportationHubId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HubPosition = group.Add(new VocabularyKey(nameof(HubPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccessorialChargeMasterCode { get; private set; }
public VocabularyKey TransportationBillingGroupId { get; private set; }
public VocabularyKey ExternalChargeCode { get; private set; }
public VocabularyKey ChargeId { get; private set; }
public VocabularyKey TransportationHubId { get; private set; }
public VocabularyKey HubPosition { get; private set; }


    }
}