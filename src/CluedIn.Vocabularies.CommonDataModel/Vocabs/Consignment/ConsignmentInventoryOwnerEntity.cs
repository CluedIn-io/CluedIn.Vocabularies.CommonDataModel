using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConsignmentInventoryOwnerEntityVocabulary : SimpleVocabulary
    {
        public ConsignmentInventoryOwnerEntityVocabulary()
        {
            VocabularyName = "ConsignmentInventoryOwnerEntity";
            KeyPrefix = "commonDataModel.consignmentinventoryownerentity";
            KeySeparator = ".";
            Grouping = "/ConsignmentInventoryOwnerEntity";

            AddGroup("ConsignmentInventoryOwnerEntity Details", group =>
            {
                Party = group.Add(new VocabularyKey(nameof(Party), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerName = group.Add(new VocabularyKey(nameof(InventoryOwnerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Party { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey InventoryOwnerName { get; private set; }


    }
}