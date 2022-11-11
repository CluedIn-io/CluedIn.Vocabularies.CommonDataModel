using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationDiscountEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationDiscountEntityVocabulary()
        {
            VocabularyName = "TMSTransportationDiscountEntity";
            KeyPrefix = "commonDataModel.tmstransportationdiscountentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationDiscountEntity";

            AddGroup("TMSTransportationDiscountEntity Details", group =>
            {
                ShippingCarrierIdCriterion = group.Add(new VocabularyKey(nameof(ShippingCarrierIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceIdCriterion = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountCurrencyCode = group.Add(new VocabularyKey(nameof(DiscountCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderCustomerAccountNumberCriterion = group.Add(new VocabularyKey(nameof(OrderCustomerAccountNumberCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumberCriterion = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumberCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DestinationAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationToAddressZipCodeCriterion = group.Add(new VocabularyKey(nameof(DestinationToAddressZipCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationFromAddressZipCodeCriterion = group.Add(new VocabularyKey(nameof(DestinationFromAddressZipCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationStateIdCriterion = group.Add(new VocabularyKey(nameof(DestinationStateIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMovementDirectionRule = group.Add(new VocabularyKey(nameof(ProductMovementDirectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountCalculationType = group.Add(new VocabularyKey(nameof(DiscountCalculationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountType = group.Add(new VocabularyKey(nameof(DiscountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveStartDateTimeCriterion = group.Add(new VocabularyKey(nameof(EffectiveStartDateTimeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveEndDateTimeCriterion = group.Add(new VocabularyKey(nameof(EffectiveEndDateTimeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCodeCriterion = group.Add(new VocabularyKey(nameof(DeliveryTermsCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingWarehouseIdCriterion = group.Add(new VocabularyKey(nameof(ShippingWarehouseIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingSiteIdCriterion = group.Add(new VocabularyKey(nameof(ShippingSiteIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage = group.Add(new VocabularyKey(nameof(DiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderVendorAccountNumberCriterion = group.Add(new VocabularyKey(nameof(OrderVendorAccountNumberCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceVendorAccountNumberCriterion = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumberCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumFreightWeightCriterion = group.Add(new VocabularyKey(nameof(MaximumFreightWeightCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumFreightWeightCriterion = group.Add(new VocabularyKey(nameof(MinimumFreightWeightCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationZoneIdCriterion = group.Add(new VocabularyKey(nameof(TransportationZoneIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationZoneMasterCodeCriterion = group.Add(new VocabularyKey(nameof(TransportationZoneMasterCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ShippingCarrierIdCriterion { get; private set; }
        public VocabularyKey ShippingCarrierServiceIdCriterion { get; private set; }
        public VocabularyKey DiscountCurrencyCode { get; private set; }
        public VocabularyKey OrderCustomerAccountNumberCriterion { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumberCriterion { get; private set; }
        public VocabularyKey DestinationAddressCountryRegionId { get; private set; }
        public VocabularyKey DestinationToAddressZipCodeCriterion { get; private set; }
        public VocabularyKey DestinationFromAddressZipCodeCriterion { get; private set; }
        public VocabularyKey DestinationStateIdCriterion { get; private set; }
        public VocabularyKey ProductMovementDirectionRule { get; private set; }
        public VocabularyKey DiscountCalculationType { get; private set; }
        public VocabularyKey DiscountType { get; private set; }
        public VocabularyKey EffectiveStartDateTimeCriterion { get; private set; }
        public VocabularyKey EffectiveEndDateTimeCriterion { get; private set; }
        public VocabularyKey DiscountAmount { get; private set; }
        public VocabularyKey DeliveryTermsCodeCriterion { get; private set; }
        public VocabularyKey ShippingWarehouseIdCriterion { get; private set; }
        public VocabularyKey ShippingSiteIdCriterion { get; private set; }
        public VocabularyKey DiscountPercentage { get; private set; }
        public VocabularyKey OrderVendorAccountNumberCriterion { get; private set; }
        public VocabularyKey InvoiceVendorAccountNumberCriterion { get; private set; }
        public VocabularyKey MaximumFreightWeightCriterion { get; private set; }
        public VocabularyKey MinimumFreightWeightCriterion { get; private set; }
        public VocabularyKey TransportationZoneIdCriterion { get; private set; }
        public VocabularyKey TransportationZoneMasterCodeCriterion { get; private set; }


    }
}