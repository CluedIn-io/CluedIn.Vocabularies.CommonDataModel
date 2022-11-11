using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConsignmentLegalEntityInventoryOwnerEntityVocabulary : SimpleVocabulary
    {
        public ConsignmentLegalEntityInventoryOwnerEntityVocabulary()
        {
            VocabularyName = "ConsignmentLegalEntityInventoryOwnerEntity";
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