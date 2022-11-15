using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcurementProductCategoryItemSalesTaxGroupAssignmentEntityVocabulary : SimpleVocabulary
    {
        public ProcurementProductCategoryItemSalesTaxGroupAssignmentEntityVocabulary()
        {
            VocabularyName = "Procurement Product Category Item Sales Tax Group Assignment Entity";
            KeyPrefix = "commonDataModel.procurementproductcategoryitemsalestaxgroupassignmententity";
            KeySeparator = ".";
            Grouping = "/ProcurementProductCategoryItemSalesTaxGroupAssignmentEntity";

            AddGroup("ProcurementProductCategoryItemSalesTaxGroupAssignmentEntity Details", group =>
            {
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSalesTaxGroupLegalEntityId = group.Add(new VocabularyKey(nameof(ProductSalesTaxGroupLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSalesTaxGroupId = group.Add(new VocabularyKey(nameof(ProductSalesTaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchasingCalculatingWithholdingTax = group.Add(new VocabularyKey(nameof(IsPurchasingCalculatingWithholdingTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemWithholdingTaxPurchaseGroupCode = group.Add(new VocabularyKey(nameof(ItemWithholdingTaxPurchaseGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey ProductSalesTaxGroupLegalEntityId { get; private set; }
        public VocabularyKey ProductSalesTaxGroupId { get; private set; }
        public VocabularyKey IsPurchasingCalculatingWithholdingTax { get; private set; }
        public VocabularyKey ItemWithholdingTaxPurchaseGroupCode { get; private set; }
    }
}