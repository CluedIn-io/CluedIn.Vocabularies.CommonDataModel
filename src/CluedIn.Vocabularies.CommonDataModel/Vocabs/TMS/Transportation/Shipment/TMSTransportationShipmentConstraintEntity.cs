using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationShipmentConstraintEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationShipmentConstraintEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Shipment Constraint Entity";
            KeyPrefix = "commonDataModel.tmstransportationshipmentconstraintentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationShipmentConstraintEntity";

            AddGroup("TMSTransportationShipmentConstraintEntity Details", group =>
            {
                ConstraintActionMode = group.Add(new VocabularyKey(nameof(ConstraintActionMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(OrderingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDateTime = group.Add(new VocabularyKey(nameof(EffectiveDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpiringDateTime = group.Add(new VocabularyKey(nameof(ExpiringDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationHubId = group.Add(new VocabularyKey(nameof(TransportationHubId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationMethodId = group.Add(new VocabularyKey(nameof(TransportationMethodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationModeCode = group.Add(new VocabularyKey(nameof(TransportationModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstraintName = group.Add(new VocabularyKey(nameof(ConstraintName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstraintCode = group.Add(new VocabularyKey(nameof(ConstraintCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderingVendorAccountNumber = group.Add(new VocabularyKey(nameof(OrderingVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWeightKilograms = group.Add(new VocabularyKey(nameof(MaximumWeightKilograms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumWeightKilograms = group.Add(new VocabularyKey(nameof(MinimumWeightKilograms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ConstraintActionMode { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey OrderingCustomerAccountNumber { get; private set; }
        public VocabularyKey EffectiveDateTime { get; private set; }
        public VocabularyKey ExpiringDateTime { get; private set; }
        public VocabularyKey TransportationHubId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey TransportationMethodId { get; private set; }
        public VocabularyKey TransportationModeCode { get; private set; }
        public VocabularyKey ConstraintName { get; private set; }
        public VocabularyKey ConstraintCode { get; private set; }
        public VocabularyKey OrderingVendorAccountNumber { get; private set; }
        public VocabularyKey MaximumWeightKilograms { get; private set; }
        public VocabularyKey MinimumWeightKilograms { get; private set; }
    }
}