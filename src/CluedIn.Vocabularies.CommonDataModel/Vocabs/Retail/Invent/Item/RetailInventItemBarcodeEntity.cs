using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInventItemBarcodeEntityVocabulary : SimpleVocabulary
    {
        public RetailInventItemBarcodeEntityVocabulary()
        {
            VocabularyName = "Retail Invent Item Barcode Entity";
            KeyPrefix = "commonDataModel.retailinventitembarcodeentity";
            KeySeparator = ".";
            Grouping = "/RetailInventItemBarcodeEntity";

            AddGroup("RetailInventItemBarcodeEntity Details", group =>
            {
                BarcodeSetupId = group.Add(new VocabularyKey(nameof(BarcodeSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Blocked = group.Add(new VocabularyKey(nameof(Blocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBarCode = group.Add(new VocabularyKey(nameof(ItemBarCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Qty = group.Add(new VocabularyKey(nameof(Qty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailShowForItem = group.Add(new VocabularyKey(nameof(RetailShowForItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailVariantId = group.Add(new VocabularyKey(nameof(RetailVariantId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitID = group.Add(new VocabularyKey(nameof(UnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseForInput = group.Add(new VocabularyKey(nameof(UseForInput), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseForPrinting = group.Add(new VocabularyKey(nameof(UseForPrinting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BarcodeSetupId { get; private set; }
        public VocabularyKey Blocked { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InventDimId { get; private set; }
        public VocabularyKey ItemBarCode { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey Qty { get; private set; }
        public VocabularyKey RetailShowForItem { get; private set; }
        public VocabularyKey RetailVariantId { get; private set; }
        public VocabularyKey UnitID { get; private set; }
        public VocabularyKey UseForInput { get; private set; }
        public VocabularyKey UseForPrinting { get; private set; }
    }
}