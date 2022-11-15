using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesProductCategoryEntityVocabulary : SimpleVocabulary
    {
        public SalesProductCategoryEntityVocabulary()
        {
            VocabularyName = "Sales Product Category Entity";
            KeyPrefix = "commonDataModel.salesproductcategoryentity";
            KeySeparator = ".";
            Grouping = "/SalesProductCategoryEntity";

            AddGroup("SalesProductCategoryEntity Details", group =>
            {
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryRecordId = group.Add(new VocabularyKey(nameof(CategoryRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryRecordId { get; private set; }
    }
}