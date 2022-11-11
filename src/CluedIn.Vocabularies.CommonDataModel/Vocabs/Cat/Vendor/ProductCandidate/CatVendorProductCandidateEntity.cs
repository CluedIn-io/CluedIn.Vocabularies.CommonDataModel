using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CatVendorProductCandidateEntityVocabulary : SimpleVocabulary
    {
        public CatVendorProductCandidateEntityVocabulary()
        {
            VocabularyName = "Common Data Model CatVendorProductCandidateEntity";
            KeyPrefix = "commonDataModel.catvendorproductcandidateentity";
            KeySeparator = ".";
            Grouping = "/CatVendorProductCandidateEntity";

            AddGroup("Common Data Model CatVendorProductCandidateEntity Details", group =>
            {
                VendorCatalogMaintenanceRequestUploadDateTime = group.Add(new VocabularyKey(nameof(VendorCatalogMaintenanceRequestUploadDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionType = group.Add(new VocabularyKey(nameof(ActionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSubtype = group.Add(new VocabularyKey(nameof(ProductSubtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SearchName = group.Add(new VocabularyKey(nameof(SearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Barcode = group.Add(new VocabularyKey(nameof(Barcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDimensionGroupName = group.Add(new VocabularyKey(nameof(ProductDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatalogMaintenanceRequestRecId = group.Add(new VocabularyKey(nameof(CatalogMaintenanceRequestRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyRecId = group.Add(new VocabularyKey(nameof(CategoryHierarchyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryRecId = group.Add(new VocabularyKey(nameof(CategoryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey VendorCatalogMaintenanceRequestUploadDateTime { get; private set; }
        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ActionType { get; private set; }
        public VocabularyKey ProductSubtype { get; private set; }
        public VocabularyKey SearchName { get; private set; }
        public VocabularyKey Barcode { get; private set; }
        public VocabularyKey ProductDimensionGroupName { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey CatalogMaintenanceRequestRecId { get; private set; }
        public VocabularyKey CategoryHierarchyRecId { get; private set; }
        public VocabularyKey CategoryRecId { get; private set; }
        public VocabularyKey Status { get; private set; }


    }
}