using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSShippingCarrierEntityVocabulary : SimpleVocabulary
    {
        public TMSShippingCarrierEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSShippingCarrierEntity";
            KeyPrefix = "commonDataModel.tmsshippingcarrierentity";
            KeySeparator = ".";
            Grouping = "/TMSShippingCarrierEntity";

            AddGroup("Common Data Model TMSShippingCarrierEntity Details", group =>
            {
                IsBroker = group.Add(new VocabularyKey(nameof(IsBroker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShippingCarrierActive = group.Add(new VocabularyKey(nameof(IsShippingCarrierActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShippingCarrierRatingActive = group.Add(new VocabularyKey(nameof(IsShippingCarrierRatingActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProNumberSequenceId = group.Add(new VocabularyKey(nameof(ProNumberSequenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarrierId = group.Add(new VocabularyKey(nameof(CarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarrierName = group.Add(new VocabularyKey(nameof(CarrierName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StandardCarrierAlphaCode = group.Add(new VocabularyKey(nameof(StandardCarrierAlphaCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierTrackingURL = group.Add(new VocabularyKey(nameof(ShippingCarrierTrackingURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierWebsiteURL = group.Add(new VocabularyKey(nameof(ShippingCarrierWebsiteURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationModeId = group.Add(new VocabularyKey(nameof(TransportationModeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationTenderType = group.Add(new VocabularyKey(nameof(TransportationTenderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierVendorAccountNumber = group.Add(new VocabularyKey(nameof(ShippingCarrierVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AverageContainerWeight = group.Add(new VocabularyKey(nameof(AverageContainerWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsBroker { get; private set; }
        public VocabularyKey IsShippingCarrierActive { get; private set; }
        public VocabularyKey IsShippingCarrierRatingActive { get; private set; }
        public VocabularyKey ProNumberSequenceId { get; private set; }
        public VocabularyKey CarrierId { get; private set; }
        public VocabularyKey CarrierName { get; private set; }
        public VocabularyKey StandardCarrierAlphaCode { get; private set; }
        public VocabularyKey ShippingCarrierTrackingURL { get; private set; }
        public VocabularyKey ShippingCarrierWebsiteURL { get; private set; }
        public VocabularyKey TransportationModeId { get; private set; }
        public VocabularyKey TransportationTenderType { get; private set; }
        public VocabularyKey ShippingCarrierVendorAccountNumber { get; private set; }
        public VocabularyKey AverageContainerWeight { get; private set; }


    }
}