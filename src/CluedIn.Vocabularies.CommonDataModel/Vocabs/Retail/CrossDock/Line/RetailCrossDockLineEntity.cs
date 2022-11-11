using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCrossDockLineEntityVocabulary : SimpleVocabulary
    {
        public RetailCrossDockLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailCrossDockLineEntity";
            KeyPrefix = "commonDataModel.retailcrossdocklineentity";
            KeySeparator = ".";
            Grouping = "/RetailCrossDockLineEntity";

            AddGroup("Common Data Model RetailCrossDockLineEntity Details", group =>
            {
                CrossDockId = group.Add(new VocabularyKey(nameof(CrossDockId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryDimensionId = group.Add(new VocabularyKey(nameof(InventoryDimensionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseLineRecId = group.Add(new VocabularyKey(nameof(PurchaseLineRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasureSymbol = group.Add(new VocabularyKey(nameof(UnitOfMeasureSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserSpecified = group.Add(new VocabularyKey(nameof(UserSpecified), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserSpecifiedQuantity = group.Add(new VocabularyKey(nameof(UserSpecifiedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseLineInventoryTransferId = group.Add(new VocabularyKey(nameof(PurchaseLineInventoryTransferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CrossDockId { get; private set; }
        public VocabularyKey InventoryDimensionId { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey PurchaseLineRecId { get; private set; }
        public VocabularyKey UnitOfMeasureSymbol { get; private set; }
        public VocabularyKey UserSpecified { get; private set; }
        public VocabularyKey UserSpecifiedQuantity { get; private set; }
        public VocabularyKey PurchaseLineInventoryTransferId { get; private set; }


    }
}