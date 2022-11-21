using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSInventoryMovementTypeEntityVocabulary : SimpleVocabulary
    {
        public WHSInventoryMovementTypeEntityVocabulary()
        {
            VocabularyName = "WHS Inventory Movement Type Entity";
            KeyPrefix = "commonDataModel.whsinventorymovementtypeentity";
            KeySeparator = ".";
            Grouping = "/WHSInventoryMovementTypeEntity";

            AddGroup("WHSInventoryMovementTypeEntity Details", group =>
            {
                MovementTypeDescription = group.Add(new VocabularyKey(nameof(MovementTypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MovementTypeCode = group.Add(new VocabularyKey(nameof(MovementTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkClassId = group.Add(new VocabularyKey(nameof(WarehouseWorkClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MovementTypeDescription { get; private set; }
        public VocabularyKey MovementTypeCode { get; private set; }
        public VocabularyKey WarehouseWorkClassId { get; private set; }
    }
}