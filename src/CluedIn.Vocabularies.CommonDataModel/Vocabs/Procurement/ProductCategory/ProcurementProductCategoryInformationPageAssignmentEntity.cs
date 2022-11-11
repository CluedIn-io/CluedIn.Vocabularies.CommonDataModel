using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcurementProductCategoryInformationPageAssignmentEntityVocabulary : SimpleVocabulary
    {
        public ProcurementProductCategoryInformationPageAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProcurementProductCategoryInformationPageAssignmentEntity";
            KeyPrefix = "commonDataModel.procurementproductcategoryinformationpageassignmententity";
            KeySeparator = ".";
            Grouping = "/ProcurementProductCategoryInformationPageAssignmentEntity";

            AddGroup("Common Data Model ProcurementProductCategoryInformationPageAssignmentEntity Details", group =>
            {
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryInformationPageLegalEntityId = group.Add(new VocabularyKey(nameof(ProductCategoryInformationPageLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryInformationPageName = group.Add(new VocabularyKey(nameof(ProductCategoryInformationPageName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey ProductCategoryInformationPageLegalEntityId { get; private set; }
        public VocabularyKey ProductCategoryInformationPageName { get; private set; }


    }
}