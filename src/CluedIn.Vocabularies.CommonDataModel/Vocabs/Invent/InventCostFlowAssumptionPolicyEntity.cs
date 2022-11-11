using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventCostFlowAssumptionPolicyEntityVocabulary : SimpleVocabulary
    {
        public InventCostFlowAssumptionPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventCostFlowAssumptionPolicyEntity";
            KeyPrefix = "commonDataModel.inventcostflowassumptionpolicyentity";
            KeySeparator = ".";
            Grouping = "/InventCostFlowAssumptionPolicyEntity";

            AddGroup("Common Data Model InventCostFlowAssumptionPolicyEntity Details", group =>
            {
                PolicyId = group.Add(new VocabularyKey(nameof(PolicyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStockedProduct = group.Add(new VocabularyKey(nameof(IsStockedProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryModel = group.Add(new VocabularyKey(nameof(InventoryModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsUnitCostIncludingPhysicallyUpdatedInventory = group.Add(new VocabularyKey(nameof(IsUnitCostIncludingPhysicallyUpdatedInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFixedReceiptPriceUsed = group.Add(new VocabularyKey(nameof(IsFixedReceiptPriceUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPhysicalInventoryPosted = group.Add(new VocabularyKey(nameof(IsPhysicalInventoryPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFinancialInventoryPosted = group.Add(new VocabularyKey(nameof(IsFinancialInventoryPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesDeliveryProcessPostDeferredRevenue = group.Add(new VocabularyKey(nameof(WillSalesDeliveryProcessPostDeferredRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductReceiptProcessingAccrueLiability = group.Add(new VocabularyKey(nameof(WillProductReceiptProcessingAccrueLiability), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PolicyId { get; private set; }
        public VocabularyKey PolicyName { get; private set; }
        public VocabularyKey IsStockedProduct { get; private set; }
        public VocabularyKey InventoryModel { get; private set; }
        public VocabularyKey IsUnitCostIncludingPhysicallyUpdatedInventory { get; private set; }
        public VocabularyKey IsFixedReceiptPriceUsed { get; private set; }
        public VocabularyKey IsPhysicalInventoryPosted { get; private set; }
        public VocabularyKey IsFinancialInventoryPosted { get; private set; }
        public VocabularyKey WillSalesDeliveryProcessPostDeferredRevenue { get; private set; }
        public VocabularyKey WillProductReceiptProcessingAccrueLiability { get; private set; }


    }
}