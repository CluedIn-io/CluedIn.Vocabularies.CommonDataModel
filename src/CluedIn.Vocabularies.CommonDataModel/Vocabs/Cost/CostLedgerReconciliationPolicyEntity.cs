using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CostLedgerReconciliationPolicyEntityVocabulary : SimpleVocabulary
    {
        public CostLedgerReconciliationPolicyEntityVocabulary()
        {
            VocabularyName = "Cost Ledger Reconciliation Policy Entity";
            KeyPrefix = "commonDataModel.costledgerreconciliationpolicyentity";
            KeySeparator = ".";
            Grouping = "/CostLedgerReconciliationPolicyEntity";

            AddGroup("CostLedgerReconciliationPolicyEntity Details", group =>
            {
                ReconciliationPrinciple = group.Add(new VocabularyKey(nameof(ReconciliationPrinciple), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(InventoryMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(WIPMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryMainAccountCategoryReferenceId = group.Add(new VocabularyKey(nameof(InventoryMainAccountCategoryReferenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPMainAccountCategoryReferenceId = group.Add(new VocabularyKey(nameof(WIPMainAccountCategoryReferenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ReconciliationPrinciple { get; private set; }
        public VocabularyKey InventoryMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey WIPMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey InventoryMainAccountCategoryReferenceId { get; private set; }
        public VocabularyKey WIPMainAccountCategoryReferenceId { get; private set; }
    }
}