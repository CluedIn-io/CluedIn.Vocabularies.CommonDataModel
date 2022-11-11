using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationTenderHistoryEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationTenderHistoryEntityVocabulary()
        {
            VocabularyName = "TMSTransportationTenderHistoryEntity";
            KeyPrefix = "commonDataModel.tmstransportationtenderhistoryentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationTenderHistoryEntity";

            AddGroup("TMSTransportationTenderHistoryEntity Details", group =>
            {
                ConfirmedPickupDateTime = group.Add(new VocabularyKey(nameof(ConfirmedPickupDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedRate = group.Add(new VocabularyKey(nameof(ConfirmedRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationEquipmentCode = group.Add(new VocabularyKey(nameof(TransportationEquipmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationDistanceMiles = group.Add(new VocabularyKey(nameof(TransportationDistanceMiles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedPickupDateTime = group.Add(new VocabularyKey(nameof(RequestedPickupDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedRate = group.Add(new VocabularyKey(nameof(RequestedRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenderStatus = group.Add(new VocabularyKey(nameof(TenderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationTenderId = group.Add(new VocabularyKey(nameof(TransportationTenderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculatedGrossWeight = group.Add(new VocabularyKey(nameof(CalculatedGrossWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationTenderHistoryEntryNumber = group.Add(new VocabularyKey(nameof(TransportationTenderHistoryEntryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierVendorAccountNumber = group.Add(new VocabularyKey(nameof(ShippingCarrierVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ConfirmedPickupDateTime { get; private set; }
        public VocabularyKey ConfirmedRate { get; private set; }
        public VocabularyKey TransportationEquipmentCode { get; private set; }
        public VocabularyKey TransportationDistanceMiles { get; private set; }
        public VocabularyKey RequestedPickupDateTime { get; private set; }
        public VocabularyKey RequestedRate { get; private set; }
        public VocabularyKey TenderStatus { get; private set; }
        public VocabularyKey TransportationTenderId { get; private set; }
        public VocabularyKey CalculatedGrossWeight { get; private set; }
        public VocabularyKey TransportationTenderHistoryEntryNumber { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierVendorAccountNumber { get; private set; }


    }
}