using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSProcurementFreightChargeEntityVocabulary : SimpleVocabulary
    {
        public TMSProcurementFreightChargeEntityVocabulary()
        {
            VocabularyName = "TMSProcurementFreightChargeEntity";
            KeyPrefix = "commonDataModel.tmsprocurementfreightchargeentity";
            KeySeparator = ".";
            Grouping = "/TMSProcurementFreightChargeEntity";

            AddGroup("TMSProcurementFreightChargeEntity Details", group =>
            {
                AccessorialChargeMasterCode = group.Add(new VocabularyKey(nameof(AccessorialChargeMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(OrderingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveStartDate = group.Add(new VocabularyKey(nameof(EffectiveStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveEndDate = group.Add(new VocabularyKey(nameof(EffectiveEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFreightChargeIgnored = group.Add(new VocabularyKey(nameof(IsFreightChargeIgnored), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationMethodId = group.Add(new VocabularyKey(nameof(TransportationMethodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightChargeType = group.Add(new VocabularyKey(nameof(FreightChargeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementChargeCode = group.Add(new VocabularyKey(nameof(ProcurementChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationModeCode = group.Add(new VocabularyKey(nameof(TransportationModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccessorialChargeMasterCode { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey OrderingCustomerAccountNumber { get; private set; }
        public VocabularyKey EffectiveStartDate { get; private set; }
        public VocabularyKey EffectiveEndDate { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey IsFreightChargeIgnored { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey TransportationMethodId { get; private set; }
        public VocabularyKey FreightChargeType { get; private set; }
        public VocabularyKey ProcurementChargeCode { get; private set; }
        public VocabularyKey TransportationModeCode { get; private set; }


    }
}