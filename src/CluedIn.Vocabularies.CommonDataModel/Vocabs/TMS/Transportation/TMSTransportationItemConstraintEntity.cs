using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationItemConstraintEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationItemConstraintEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Item Constraint Entity";
            KeyPrefix = "commonDataModel.tmstransportationitemconstraintentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationItemConstraintEntity";

            AddGroup("TMSTransportationItemConstraintEntity Details", group =>
            {
                ConstraintActionMode = group.Add(new VocabularyKey(nameof(ConstraintActionMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveStartDateTime = group.Add(new VocabularyKey(nameof(EffectiveStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveEndDateTime = group.Add(new VocabularyKey(nameof(EffectiveEndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstProductFilterCode = group.Add(new VocabularyKey(nameof(FirstProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondProductFilterCode = group.Add(new VocabularyKey(nameof(SecondProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdProductFilterCode = group.Add(new VocabularyKey(nameof(ThirdProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FourthProductFilterCode = group.Add(new VocabularyKey(nameof(FourthProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationHubId = group.Add(new VocabularyKey(nameof(TransportationHubId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstraintCode = group.Add(new VocabularyKey(nameof(ConstraintCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationMethodId = group.Add(new VocabularyKey(nameof(TransportationMethodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationModeCode = group.Add(new VocabularyKey(nameof(TransportationModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstraintName = group.Add(new VocabularyKey(nameof(ConstraintName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ConstraintActionMode { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey EffectiveStartDateTime { get; private set; }
        public VocabularyKey EffectiveEndDateTime { get; private set; }
        public VocabularyKey FirstProductFilterCode { get; private set; }
        public VocabularyKey SecondProductFilterCode { get; private set; }
        public VocabularyKey ThirdProductFilterCode { get; private set; }
        public VocabularyKey FourthProductFilterCode { get; private set; }
        public VocabularyKey TransportationHubId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey ConstraintCode { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey TransportationMethodId { get; private set; }
        public VocabularyKey TransportationModeCode { get; private set; }
        public VocabularyKey ConstraintName { get; private set; }
    }
}