using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcPurchaseRequisitionProcurementCatalogPolicyRuleEntityVocabulary : SimpleVocabulary
    {
        public ProcPurchaseRequisitionProcurementCatalogPolicyRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProcPurchaseRequisitionProcurementCatalogPolicyRuleEntity";
            KeyPrefix = "commonDataModel.procpurchaserequisitionprocurementcatalogpolicyruleentity";
            KeySeparator = ".";
            Grouping = "/ProcPurchaseRequisitionProcurementCatalogPolicyRuleEntity";

            AddGroup("Common Data Model ProcPurchaseRequisitionProcurementCatalogPolicyRuleEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Catalog = group.Add(new VocabularyKey(nameof(Catalog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementSiteCatalogName = group.Add(new VocabularyKey(nameof(ProcurementSiteCatalogName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleName = group.Add(new VocabularyKey(nameof(PolicyRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Catalog { get; private set; }
        public VocabularyKey ProcurementSiteCatalogName { get; private set; }
        public VocabularyKey Policy { get; private set; }
        public VocabularyKey PolicyRuleType { get; private set; }
        public VocabularyKey PolicyRuleName { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }


    }
}