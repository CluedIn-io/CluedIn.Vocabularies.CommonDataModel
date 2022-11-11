using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcurementProductCategoryVendorAssignmentEntityVocabulary : SimpleVocabulary
    {
        public ProcurementProductCategoryVendorAssignmentEntityVocabulary()
        {
            VocabularyName = "ProcurementProductCategoryVendorAssignmentEntity";
            KeyPrefix = "commonDataModel.procurementproductcategoryvendorassignmententity";
            KeySeparator = ".";
            Grouping = "/ProcurementProductCategoryVendorAssignmentEntity";

            AddGroup("ProcurementProductCategoryVendorAssignmentEntity Details", group =>
            {
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorLegalEntityId = group.Add(new VocabularyKey(nameof(VendorLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorStatus = group.Add(new VocabularyKey(nameof(VendorStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey VendorLegalEntityId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey VendorStatus { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }


    }
}