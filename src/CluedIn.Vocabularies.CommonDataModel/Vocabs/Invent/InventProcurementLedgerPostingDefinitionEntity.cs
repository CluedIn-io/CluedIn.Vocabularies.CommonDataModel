using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventProcurementLedgerPostingDefinitionEntityVocabulary : SimpleVocabulary
    {
        public InventProcurementLedgerPostingDefinitionEntityVocabulary()
        {
            VocabularyName = "Invent Procurement Ledger Posting Definition Entity";
            KeyPrefix = "commonDataModel.inventprocurementledgerpostingdefinitionentity";
            KeySeparator = ".";
            Grouping = "/InventProcurementLedgerPostingDefinitionEntity";

            AddGroup("InventProcurementLedgerPostingDefinitionEntity Details", group =>
            {
                InventoryAccountType = group.Add(new VocabularyKey(nameof(InventoryAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorGroupId = group.Add(new VocabularyKey(nameof(VendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryRelation = group.Add(new VocabularyKey(nameof(CategoryRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustVendCode = group.Add(new VocabularyKey(nameof(CustVendCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustVendRelation = group.Add(new VocabularyKey(nameof(CustVendRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryProfileRelation = group.Add(new VocabularyKey(nameof(InventoryProfileRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KindOfActivity = group.Add(new VocabularyKey(nameof(KindOfActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryProfileId = group.Add(new VocabularyKey(nameof(InventoryProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteCode = group.Add(new VocabularyKey(nameof(SiteCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteRelation = group.Add(new VocabularyKey(nameof(SiteRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementSiteId = group.Add(new VocabularyKey(nameof(ProcurementSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryRecordId = group.Add(new VocabularyKey(nameof(CategoryRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey InventoryAccountType { get; private set; }
        public VocabularyKey MainAccountIdDisplayValue { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey VendorGroupId { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey CategoryRelation { get; private set; }
        public VocabularyKey CustVendCode { get; private set; }
        public VocabularyKey CustVendRelation { get; private set; }
        public VocabularyKey InventoryProfileRelation { get; private set; }
        public VocabularyKey KindOfActivity { get; private set; }
        public VocabularyKey InventoryProfileId { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey SiteCode { get; private set; }
        public VocabularyKey SiteRelation { get; private set; }
        public VocabularyKey ProcurementSiteId { get; private set; }
        public VocabularyKey CategoryRecordId { get; private set; }
    }
}