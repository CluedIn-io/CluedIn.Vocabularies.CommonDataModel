using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConsignmentLegalEntityInventoryOwnerEntityVocabulary : SimpleVocabulary
    {
        public ConsignmentLegalEntityInventoryOwnerEntityVocabulary()
        {
            VocabularyName = "Consignment Legal Entity Inventory Owner Entity";
            KeyPrefix = "commonDataModel.consignmentlegalentityinventoryownerentity";
            KeySeparator = ".";
            Grouping = "/ConsignmentLegalEntityInventoryOwnerEntity";

            AddGroup("ConsignmentLegalEntityInventoryOwnerEntity Details", group =>
            {
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
    }
}