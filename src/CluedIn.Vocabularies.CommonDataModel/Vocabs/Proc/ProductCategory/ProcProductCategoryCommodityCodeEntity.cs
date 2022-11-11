using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcProductCategoryCommodityCodeEntityVocabulary : SimpleVocabulary
    {
        public ProcProductCategoryCommodityCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProcProductCategoryCommodityCodeEntity";
            KeyPrefix = "commonDataModel.procproductcategorycommoditycodeentity";
            KeySeparator = ".";
            Grouping = "/ProcProductCategoryCommodityCodeEntity";

            AddGroup("Common Data Model ProcProductCategoryCommodityCodeEntity Details", group =>
            {
                CommodityRecId = group.Add(new VocabularyKey(nameof(CommodityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommodityHierarchyRecId = group.Add(new VocabularyKey(nameof(CommodityHierarchyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryRecId = group.Add(new VocabularyKey(nameof(ProductCategoryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryHierarchyRecId = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommodityHierarchyName = group.Add(new VocabularyKey(nameof(CommodityHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommodityName = group.Add(new VocabularyKey(nameof(CommodityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommodityCode = group.Add(new VocabularyKey(nameof(CommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CommodityRecId { get; private set; }
        public VocabularyKey CommodityHierarchyRecId { get; private set; }
        public VocabularyKey ProductCategoryRecId { get; private set; }
        public VocabularyKey ProductCategoryHierarchyRecId { get; private set; }
        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey CommodityHierarchyName { get; private set; }
        public VocabularyKey CommodityName { get; private set; }
        public VocabularyKey CommodityCode { get; private set; }


    }
}