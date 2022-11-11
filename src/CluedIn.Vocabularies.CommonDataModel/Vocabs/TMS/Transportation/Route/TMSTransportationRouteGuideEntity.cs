using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRouteGuideEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRouteGuideEntityVocabulary()
        {
            VocabularyName = "TMSTransportationRouteGuideEntity";
            KeyPrefix = "commonDataModel.tmstransportationrouteguideentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRouteGuideEntity";

            AddGroup("TMSTransportationRouteGuideEntity Details", group =>
            {
                OriginAddressCountryRegionIdCriterion = group.Add(new VocabularyKey(nameof(OriginAddressCountryRegionIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginTransportationHubIdCriterion = group.Add(new VocabularyKey(nameof(OriginTransportationHubIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginTransportationZoneMasterCodeCriterion = group.Add(new VocabularyKey(nameof(OriginTransportationZoneMasterCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRouteGuideActive = group.Add(new VocabularyKey(nameof(IsRouteGuideActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceGroupId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumContainerAmountCriterion = group.Add(new VocabularyKey(nameof(MaximumContainerAmountCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumContainerAmountCriterion = group.Add(new VocabularyKey(nameof(MinimumContainerAmountCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderCustomerAccountNumberCriterion = group.Add(new VocabularyKey(nameof(OrderCustomerAccountNumberCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumberCriterion = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumberCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationAddressCountryRegionIdCriterion = group.Add(new VocabularyKey(nameof(DestinationAddressCountryRegionIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationTransportationHubIdCriterion = group.Add(new VocabularyKey(nameof(DestinationTransportationHubIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationToAddressZipCodeCriterion = group.Add(new VocabularyKey(nameof(DestinationToAddressZipCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationFromAddressZipCodeCriterion = group.Add(new VocabularyKey(nameof(DestinationFromAddressZipCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationTransportationZoneIdCriterion = group.Add(new VocabularyKey(nameof(DestinationTransportationZoneIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationTransportationZoneMasterCodeCriterion = group.Add(new VocabularyKey(nameof(DestinationTransportationZoneMasterCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMovementDirectionRule = group.Add(new VocabularyKey(nameof(ProductMovementDirectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveStartDateTimeCriterion = group.Add(new VocabularyKey(nameof(EffectiveStartDateTimeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveEndDateTimeCriterion = group.Add(new VocabularyKey(nameof(EffectiveEndDateTimeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationEquipmentCodeCriterion = group.Add(new VocabularyKey(nameof(TransportationEquipmentCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResultTransportationEquipmentCode = group.Add(new VocabularyKey(nameof(ResultTransportationEquipmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingWarehouseIdCriterion = group.Add(new VocabularyKey(nameof(ShippingWarehouseIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingSiteIdCriterion = group.Add(new VocabularyKey(nameof(ShippingSiteIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationModeCode = group.Add(new VocabularyKey(nameof(TransportationModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GuideName = group.Add(new VocabularyKey(nameof(GuideName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginAddressZipCodeCriterion = group.Add(new VocabularyKey(nameof(OriginAddressZipCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginTransportationZoneIdCriterion = group.Add(new VocabularyKey(nameof(OriginTransportationZoneIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsResidentialAddressCriterion = group.Add(new VocabularyKey(nameof(IsResidentialAddressCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRoutePlanId = group.Add(new VocabularyKey(nameof(TransportationRoutePlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GuideId = group.Add(new VocabularyKey(nameof(GuideId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderVendorAccountNumberCriterion = group.Add(new VocabularyKey(nameof(OrderVendorAccountNumberCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceVendorAccountNumberCriterion = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumberCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumLoadVolumeCriterion = group.Add(new VocabularyKey(nameof(MaximumLoadVolumeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumLoadVolumeCriterion = group.Add(new VocabularyKey(nameof(MinimumLoadVolumeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWeightCriterion = group.Add(new VocabularyKey(nameof(MaximumWeightCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumWeightCriterion = group.Add(new VocabularyKey(nameof(MinimumWeightCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OriginAddressCountryRegionIdCriterion { get; private set; }
        public VocabularyKey OriginTransportationHubIdCriterion { get; private set; }
        public VocabularyKey OriginTransportationZoneMasterCodeCriterion { get; private set; }
        public VocabularyKey IsRouteGuideActive { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceGroupId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey MaximumContainerAmountCriterion { get; private set; }
        public VocabularyKey MinimumContainerAmountCriterion { get; private set; }
        public VocabularyKey OrderCustomerAccountNumberCriterion { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumberCriterion { get; private set; }
        public VocabularyKey DestinationAddressCountryRegionIdCriterion { get; private set; }
        public VocabularyKey DestinationTransportationHubIdCriterion { get; private set; }
        public VocabularyKey DestinationToAddressZipCodeCriterion { get; private set; }
        public VocabularyKey DestinationFromAddressZipCodeCriterion { get; private set; }
        public VocabularyKey DestinationTransportationZoneIdCriterion { get; private set; }
        public VocabularyKey DestinationTransportationZoneMasterCodeCriterion { get; private set; }
        public VocabularyKey ProductMovementDirectionRule { get; private set; }
        public VocabularyKey EffectiveStartDateTimeCriterion { get; private set; }
        public VocabularyKey EffectiveEndDateTimeCriterion { get; private set; }
        public VocabularyKey TransportationEquipmentCodeCriterion { get; private set; }
        public VocabularyKey ResultTransportationEquipmentCode { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey ShippingWarehouseIdCriterion { get; private set; }
        public VocabularyKey ShippingSiteIdCriterion { get; private set; }
        public VocabularyKey TransportationModeCode { get; private set; }
        public VocabularyKey GuideName { get; private set; }
        public VocabularyKey OriginAddressZipCodeCriterion { get; private set; }
        public VocabularyKey OriginTransportationZoneIdCriterion { get; private set; }
        public VocabularyKey IsResidentialAddressCriterion { get; private set; }
        public VocabularyKey TransportationRoutePlanId { get; private set; }
        public VocabularyKey GuideId { get; private set; }
        public VocabularyKey OrderVendorAccountNumberCriterion { get; private set; }
        public VocabularyKey InvoiceVendorAccountNumberCriterion { get; private set; }
        public VocabularyKey MaximumLoadVolumeCriterion { get; private set; }
        public VocabularyKey MinimumLoadVolumeCriterion { get; private set; }
        public VocabularyKey MaximumWeightCriterion { get; private set; }
        public VocabularyKey MinimumWeightCriterion { get; private set; }


    }
}