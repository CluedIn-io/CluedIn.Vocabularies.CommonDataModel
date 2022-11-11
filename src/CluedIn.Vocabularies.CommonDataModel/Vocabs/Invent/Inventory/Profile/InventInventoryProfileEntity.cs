using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryProfileEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryProfileEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventInventoryProfileEntity";
            KeyPrefix = "commonDataModel.inventinventoryprofileentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryProfileEntity";

            AddGroup("Common Data Model InventInventoryProfileEntity Details", group =>
            {
                InventoryProfileId = group.Add(new VocabularyKey(nameof(InventoryProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlcoholActivityType = group.Add(new VocabularyKey(nameof(AlcoholActivityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ControlDimensionInPurchaseOrder = group.Add(new VocabularyKey(nameof(ControlDimensionInPurchaseOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ControlDimensionInSalesOrder = group.Add(new VocabularyKey(nameof(ControlDimensionInSalesOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InitializeDimension = group.Add(new VocabularyKey(nameof(InitializeDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SplitCustomerInvoice = group.Add(new VocabularyKey(nameof(SplitCustomerInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KindOfActivity = group.Add(new VocabularyKey(nameof(KindOfActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProhibitCostAdjustment = group.Add(new VocabularyKey(nameof(ProhibitCostAdjustment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProhibitMiscCharges = group.Add(new VocabularyKey(nameof(ProhibitMiscCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchingPriority = group.Add(new VocabularyKey(nameof(MatchingPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SelectionSkip = group.Add(new VocabularyKey(nameof(SelectionSkip), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KindOfInventory = group.Add(new VocabularyKey(nameof(KindOfInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InventoryProfileId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AlcoholActivityType { get; private set; }
        public VocabularyKey ControlDimensionInPurchaseOrder { get; private set; }
        public VocabularyKey ControlDimensionInSalesOrder { get; private set; }
        public VocabularyKey InitializeDimension { get; private set; }
        public VocabularyKey SplitCustomerInvoice { get; private set; }
        public VocabularyKey KindOfActivity { get; private set; }
        public VocabularyKey ProhibitCostAdjustment { get; private set; }
        public VocabularyKey ProhibitMiscCharges { get; private set; }
        public VocabularyKey MatchingPriority { get; private set; }
        public VocabularyKey SelectionSkip { get; private set; }
        public VocabularyKey KindOfInventory { get; private set; }


    }
}