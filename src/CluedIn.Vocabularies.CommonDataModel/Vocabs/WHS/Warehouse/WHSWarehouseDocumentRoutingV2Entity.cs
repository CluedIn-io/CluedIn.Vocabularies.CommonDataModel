using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseDocumentRoutingV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseDocumentRoutingV2EntityVocabulary()
        {
            VocabularyName = "WHSWarehouseDocumentRoutingV2Entity";
            KeyPrefix = "commonDataModel.whswarehousedocumentroutingv2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseDocumentRoutingV2Entity";

            AddGroup("WHSWarehouseDocumentRoutingV2Entity Details", group =>
            {
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRoutingName = group.Add(new VocabularyKey(nameof(DocumentRoutingName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRoutingQuery = group.Add(new VocabularyKey(nameof(DocumentRoutingQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDocumentRoutingQueryEnabled = group.Add(new VocabularyKey(nameof(IsDocumentRoutingQueryEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRoutingSequence = group.Add(new VocabularyKey(nameof(DocumentRoutingSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseMobileDeviceUserId = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkTemplateId = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkOrderType = group.Add(new VocabularyKey(nameof(WorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromWarehouseZoneId = group.Add(new VocabularyKey(nameof(FromWarehouseZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToWarehouseZoneId = group.Add(new VocabularyKey(nameof(ToWarehouseZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey DocumentRoutingName { get; private set; }
        public VocabularyKey DocumentRoutingQuery { get; private set; }
        public VocabularyKey IsDocumentRoutingQueryEnabled { get; private set; }
        public VocabularyKey DocumentRoutingSequence { get; private set; }
        public VocabularyKey WarehouseMobileDeviceUserId { get; private set; }
        public VocabularyKey WarehouseWorkTemplateId { get; private set; }
        public VocabularyKey WorkOrderType { get; private set; }
        public VocabularyKey FromWarehouseZoneId { get; private set; }
        public VocabularyKey ToWarehouseZoneId { get; private set; }


    }
}