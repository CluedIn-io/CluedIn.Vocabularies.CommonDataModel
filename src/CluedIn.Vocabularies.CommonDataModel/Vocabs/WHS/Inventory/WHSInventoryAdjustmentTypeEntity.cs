using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSInventoryAdjustmentTypeEntityVocabulary : SimpleVocabulary
    {
        public WHSInventoryAdjustmentTypeEntityVocabulary()
        {
            VocabularyName = "WHS Inventory Adjustment Type Entity";
            KeyPrefix = "commonDataModel.whsinventoryadjustmenttypeentity";
            KeySeparator = ".";
            Grouping = "/WHSInventoryAdjustmentTypeEntity";

            AddGroup("WHSInventoryAdjustmentTypeEntity Details", group =>
            {
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventCountingJournalNameId = group.Add(new VocabularyKey(nameof(InventCountingJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInventoryAdjustmentRemoveReservations = group.Add(new VocabularyKey(nameof(WillInventoryAdjustmentRemoveReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeId { get; private set; }
        public VocabularyKey TypeDescription { get; private set; }
        public VocabularyKey InventCountingJournalNameId { get; private set; }
        public VocabularyKey WillInventoryAdjustmentRemoveReservations { get; private set; }
    }
}