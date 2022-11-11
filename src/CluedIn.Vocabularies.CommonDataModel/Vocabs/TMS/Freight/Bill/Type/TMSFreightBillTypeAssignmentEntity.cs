using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSFreightBillTypeAssignmentEntityVocabulary : SimpleVocabulary
    {
        public TMSFreightBillTypeAssignmentEntityVocabulary()
        {
            VocabularyName = "TMSFreightBillTypeAssignmentEntity";
            KeyPrefix = "commonDataModel.tmsfreightbilltypeassignmententity";
            KeySeparator = ".";
            Grouping = "/TMSFreightBillTypeAssignmentEntity";

            AddGroup("TMSFreightBillTypeAssignmentEntity Details", group =>
            {
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMovementDirectionRule = group.Add(new VocabularyKey(nameof(ProductMovementDirectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightBillTypeId = group.Add(new VocabularyKey(nameof(FreightBillTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationModeCode = group.Add(new VocabularyKey(nameof(TransportationModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ProductMovementDirectionRule { get; private set; }
        public VocabularyKey FreightBillTypeId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey TransportationModeCode { get; private set; }


    }
}