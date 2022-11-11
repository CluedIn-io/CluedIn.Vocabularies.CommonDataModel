using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSShipConsolidationTemplateV2EntityVocabulary : SimpleVocabulary
    {
        public WHSShipConsolidationTemplateV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSShipConsolidationTemplateV2Entity";
            KeyPrefix = "commonDataModel.whsshipconsolidationtemplatev2entity";
            KeySeparator = ".";
            Grouping = "/WHSShipConsolidationTemplateV2Entity";

            AddGroup("Common Data Model WHSShipConsolidationTemplateV2Entity Details", group =>
            {
                OrderingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(OrderingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateDescription = group.Add(new VocabularyKey(nameof(TemplateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationCountryRegionId = group.Add(new VocabularyKey(nameof(DestinationCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationFromZipCode = group.Add(new VocabularyKey(nameof(DestinationFromZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationToZipCode = group.Add(new VocabularyKey(nameof(DestinationToZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationWarehouseId = group.Add(new VocabularyKey(nameof(DestinationWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationOperationalSiteId = group.Add(new VocabularyKey(nameof(DestinationOperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstProductFilterCode = group.Add(new VocabularyKey(nameof(FirstProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondProductFilterCode = group.Add(new VocabularyKey(nameof(SecondProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdProductFilterCode = group.Add(new VocabularyKey(nameof(ThirdProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FourthProductFilterCode = group.Add(new VocabularyKey(nameof(FourthProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipConsolidationTemplateName = group.Add(new VocabularyKey(nameof(ShipConsolidationTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginCountryRegionId = group.Add(new VocabularyKey(nameof(OriginCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginFromZipCode = group.Add(new VocabularyKey(nameof(OriginFromZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginWarehouseId = group.Add(new VocabularyKey(nameof(OriginWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginOperationalSiteId = group.Add(new VocabularyKey(nameof(OriginOperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginToZipCode = group.Add(new VocabularyKey(nameof(OriginToZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FilterQuery = group.Add(new VocabularyKey(nameof(FilterQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipmentConsolidationPolicyType = group.Add(new VocabularyKey(nameof(ShipmentConsolidationPolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillConsolidationSplitShipmentByLoadCapacity = group.Add(new VocabularyKey(nameof(WillConsolidationSplitShipmentByLoadCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillConsolidationUpdateScheduledShipDateTime = group.Add(new VocabularyKey(nameof(WillConsolidationUpdateScheduledShipDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OrderingCustomerAccountNumber { get; private set; }
        public VocabularyKey TemplateDescription { get; private set; }
        public VocabularyKey DestinationCountryRegionId { get; private set; }
        public VocabularyKey DestinationFromZipCode { get; private set; }
        public VocabularyKey DestinationToZipCode { get; private set; }
        public VocabularyKey DestinationWarehouseId { get; private set; }
        public VocabularyKey DestinationOperationalSiteId { get; private set; }
        public VocabularyKey FirstProductFilterCode { get; private set; }
        public VocabularyKey SecondProductFilterCode { get; private set; }
        public VocabularyKey ThirdProductFilterCode { get; private set; }
        public VocabularyKey FourthProductFilterCode { get; private set; }
        public VocabularyKey ShipConsolidationTemplateName { get; private set; }
        public VocabularyKey OriginCountryRegionId { get; private set; }
        public VocabularyKey OriginFromZipCode { get; private set; }
        public VocabularyKey OriginWarehouseId { get; private set; }
        public VocabularyKey OriginOperationalSiteId { get; private set; }
        public VocabularyKey OriginToZipCode { get; private set; }
        public VocabularyKey FilterQuery { get; private set; }
        public VocabularyKey ShipmentConsolidationPolicyType { get; private set; }
        public VocabularyKey WillConsolidationSplitShipmentByLoadCapacity { get; private set; }
        public VocabularyKey WillConsolidationUpdateScheduledShipDateTime { get; private set; }


    }
}