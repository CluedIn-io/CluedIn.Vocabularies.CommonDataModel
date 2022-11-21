using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationAccessorialChargeAssignmentEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationAccessorialChargeAssignmentEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Accessorial Charge Assignment Entity";
            KeyPrefix = "commonDataModel.tmstransportationaccessorialchargeassignmententity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationAccessorialChargeAssignmentEntity";

            AddGroup("TMSTransportationAccessorialChargeAssignmentEntity Details", group =>
            {
                ChargeAssignmentLevel = group.Add(new VocabularyKey(nameof(ChargeAssignmentLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillChargeCalculationIncludeTransportationDiscounts = group.Add(new VocabularyKey(nameof(WillChargeCalculationIncludeTransportationDiscounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreChargeAssignmentCriteriaIgnored = group.Add(new VocabularyKey(nameof(AreChargeAssignmentCriteriaIgnored), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationBillingGroupId = group.Add(new VocabularyKey(nameof(TransportationBillingGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierAccessorialChargeId = group.Add(new VocabularyKey(nameof(ShippingCarrierAccessorialChargeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionIdCriterion = group.Add(new VocabularyKey(nameof(AddressCountryRegionIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeCurrencyCode = group.Add(new VocabularyKey(nameof(ChargeCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderingCustomerAccountNumberCriterion = group.Add(new VocabularyKey(nameof(OrderingCustomerAccountNumberCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumberCriterion = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumberCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveStartDateTimeCriterion = group.Add(new VocabularyKey(nameof(EffectiveStartDateTimeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveEndDateTimeCriterion = group.Add(new VocabularyKey(nameof(EffectiveEndDateTimeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationEquipmentCodeCriterion = group.Add(new VocabularyKey(nameof(TransportationEquipmentCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FlatChargeAmount = group.Add(new VocabularyKey(nameof(FlatChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeType = group.Add(new VocabularyKey(nameof(ChargeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCodeCriterion = group.Add(new VocabularyKey(nameof(DeliveryTermsCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FuelSurchargeFuelIndexRegionId = group.Add(new VocabularyKey(nameof(FuelSurchargeFuelIndexRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationHubAccessorialChargeId = group.Add(new VocabularyKey(nameof(TransportationHubAccessorialChargeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationHubId = group.Add(new VocabularyKey(nameof(TransportationHubId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingWarehouseIdCriterion = group.Add(new VocabularyKey(nameof(ShippingWarehouseIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingSiteIdCriterion = group.Add(new VocabularyKey(nameof(ShippingSiteIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumChargeAmount = group.Add(new VocabularyKey(nameof(MaximumChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeTransportationMileageEngineId = group.Add(new VocabularyKey(nameof(ChargeTransportationMileageEngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumChargeAmount = group.Add(new VocabularyKey(nameof(MinimumChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeAssignmentName = group.Add(new VocabularyKey(nameof(ChargeAssignmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FuelSurchargeOffsetDays = group.Add(new VocabularyKey(nameof(FuelSurchargeOffsetDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargePercentage = group.Add(new VocabularyKey(nameof(ChargePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToAddressZipCodeCriterion = group.Add(new VocabularyKey(nameof(ToAddressZipCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromAddressZipCodeCriterion = group.Add(new VocabularyKey(nameof(FromAddressZipCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsResidentialShipCriterion = group.Add(new VocabularyKey(nameof(IsResidentialShipCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressStateIdCriterion = group.Add(new VocabularyKey(nameof(DropOffAddressStateIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeAccessorialUnit = group.Add(new VocabularyKey(nameof(ChargeAccessorialUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeAccessorialUnitDivisor = group.Add(new VocabularyKey(nameof(ChargeAccessorialUnitDivisor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumFreightValueCriterion = group.Add(new VocabularyKey(nameof(MaximumFreightValueCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumFreightValueCriterion = group.Add(new VocabularyKey(nameof(MinimumFreightValueCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumFreightWeightCriterion = group.Add(new VocabularyKey(nameof(MaximumFreightWeightCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumFreightWeightCriterion = group.Add(new VocabularyKey(nameof(MinimumFreightWeightCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationZoneIdCriterion = group.Add(new VocabularyKey(nameof(TransportationZoneIdCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationZoneMasterCodeCriterion = group.Add(new VocabularyKey(nameof(TransportationZoneMasterCodeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ChargeAssignmentLevel { get; private set; }
        public VocabularyKey WillChargeCalculationIncludeTransportationDiscounts { get; private set; }
        public VocabularyKey AreChargeAssignmentCriteriaIgnored { get; private set; }
        public VocabularyKey TransportationBillingGroupId { get; private set; }
        public VocabularyKey ShippingCarrierAccessorialChargeId { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey AddressCountryRegionIdCriterion { get; private set; }
        public VocabularyKey ChargeCurrencyCode { get; private set; }
        public VocabularyKey OrderingCustomerAccountNumberCriterion { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumberCriterion { get; private set; }
        public VocabularyKey EffectiveStartDateTimeCriterion { get; private set; }
        public VocabularyKey EffectiveEndDateTimeCriterion { get; private set; }
        public VocabularyKey TransportationEquipmentCodeCriterion { get; private set; }
        public VocabularyKey FlatChargeAmount { get; private set; }
        public VocabularyKey ChargeType { get; private set; }
        public VocabularyKey DeliveryTermsCodeCriterion { get; private set; }
        public VocabularyKey FuelSurchargeFuelIndexRegionId { get; private set; }
        public VocabularyKey TransportationHubAccessorialChargeId { get; private set; }
        public VocabularyKey TransportationHubId { get; private set; }
        public VocabularyKey ShippingWarehouseIdCriterion { get; private set; }
        public VocabularyKey ShippingSiteIdCriterion { get; private set; }
        public VocabularyKey MaximumChargeAmount { get; private set; }
        public VocabularyKey ChargeTransportationMileageEngineId { get; private set; }
        public VocabularyKey MinimumChargeAmount { get; private set; }
        public VocabularyKey ChargeAssignmentName { get; private set; }
        public VocabularyKey FuelSurchargeOffsetDays { get; private set; }
        public VocabularyKey ChargePercentage { get; private set; }
        public VocabularyKey ToAddressZipCodeCriterion { get; private set; }
        public VocabularyKey FromAddressZipCodeCriterion { get; private set; }
        public VocabularyKey IsResidentialShipCriterion { get; private set; }
        public VocabularyKey DropOffAddressStateIdCriterion { get; private set; }
        public VocabularyKey ChargeAccessorialUnit { get; private set; }
        public VocabularyKey ChargeAccessorialUnitDivisor { get; private set; }
        public VocabularyKey MaximumFreightValueCriterion { get; private set; }
        public VocabularyKey MinimumFreightValueCriterion { get; private set; }
        public VocabularyKey MaximumFreightWeightCriterion { get; private set; }
        public VocabularyKey MinimumFreightWeightCriterion { get; private set; }
        public VocabularyKey TransportationZoneIdCriterion { get; private set; }
        public VocabularyKey TransportationZoneMasterCodeCriterion { get; private set; }
    }
}