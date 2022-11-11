using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSSalesOrderDocumentRoutingV2EntityVocabulary : SimpleVocabulary
    {
        public WHSSalesOrderDocumentRoutingV2EntityVocabulary()
        {
            VocabularyName = "WHSSalesOrderDocumentRoutingV2Entity";
            KeyPrefix = "commonDataModel.whssalesorderdocumentroutingv2entity";
            KeySeparator = ".";
            Grouping = "/WHSSalesOrderDocumentRoutingV2Entity";

            AddGroup("WHSSalesOrderDocumentRoutingV2Entity Details", group =>
            {
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRoutingName = group.Add(new VocabularyKey(nameof(DocumentRoutingName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRoutingQuery = group.Add(new VocabularyKey(nameof(DocumentRoutingQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDocumentRoutingQueryEnabled = group.Add(new VocabularyKey(nameof(IsDocumentRoutingQueryEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRoutingSequence = group.Add(new VocabularyKey(nameof(DocumentRoutingSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseMobileDeviceUserId = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkTemplateId = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromWarehouseZoneId = group.Add(new VocabularyKey(nameof(FromWarehouseZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToWarehouseZoneId = group.Add(new VocabularyKey(nameof(ToWarehouseZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkTemplateWorkOrderType = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey DocumentRoutingName { get; private set; }
        public VocabularyKey DocumentRoutingQuery { get; private set; }
        public VocabularyKey IsDocumentRoutingQueryEnabled { get; private set; }
        public VocabularyKey DocumentRoutingSequence { get; private set; }
        public VocabularyKey WarehouseMobileDeviceUserId { get; private set; }
        public VocabularyKey WarehouseWorkTemplateId { get; private set; }
        public VocabularyKey FromWarehouseZoneId { get; private set; }
        public VocabularyKey ToWarehouseZoneId { get; private set; }
        public VocabularyKey WarehouseWorkTemplateWorkOrderType { get; private set; }


    }
}