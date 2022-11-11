using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailAttributesGlobalLookupEntityVocabulary : SimpleVocabulary
    {
        public RetailAttributesGlobalLookupEntityVocabulary()
        {
            VocabularyName = "RetailAttributesGlobalLookupEntity";
            KeyPrefix = "commonDataModel.retailattributesgloballookupentity";
            KeySeparator = ".";
            Grouping = "/RetailAttributesGlobalLookupEntity";

            AddGroup("RetailAttributesGlobalLookupEntity Details", group =>
            {
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupProductDimension = group.Add(new VocabularyKey(nameof(GroupProductDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupStorageDimension = group.Add(new VocabularyKey(nameof(GroupStorageDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTrackingDimension = group.Add(new VocabularyKey(nameof(GroupTrackingDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariantColorGroup = group.Add(new VocabularyKey(nameof(VariantColorGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariantSizeGroup = group.Add(new VocabularyKey(nameof(VariantSizeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariantStyleGroup = group.Add(new VocabularyKey(nameof(VariantStyleGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey GroupProductDimension { get; private set; }
        public VocabularyKey GroupStorageDimension { get; private set; }
        public VocabularyKey GroupTrackingDimension { get; private set; }
        public VocabularyKey VariantColorGroup { get; private set; }
        public VocabularyKey VariantSizeGroup { get; private set; }
        public VocabularyKey VariantStyleGroup { get; private set; }


    }
}