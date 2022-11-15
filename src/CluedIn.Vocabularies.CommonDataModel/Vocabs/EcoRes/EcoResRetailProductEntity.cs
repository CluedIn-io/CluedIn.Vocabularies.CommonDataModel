using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResRetailProductEntityVocabulary : SimpleVocabulary
    {
        public EcoResRetailProductEntityVocabulary()
        {
            VocabularyName = "Eco Res Retail Product Entity";
            KeyPrefix = "commonDataModel.ecoresretailproductentity";
            KeySeparator = ".";
            Grouping = "/EcoResRetailProductEntity";

            AddGroup("EcoResRetailProductEntity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSearchName = group.Add(new VocabularyKey(nameof(ProductSearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductType = group.Add(new VocabularyKey(nameof(ProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCategoryName = group.Add(new VocabularyKey(nameof(RetailCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductSearchName { get; private set; }
        public VocabularyKey ProductType { get; private set; }
        public VocabularyKey RetailCategoryName { get; private set; }
    }
}