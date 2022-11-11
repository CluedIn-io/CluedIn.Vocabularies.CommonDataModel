using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCatalogProductEntityVocabulary : SimpleVocabulary
    {
        public RetailCatalogProductEntityVocabulary()
        {
            VocabularyName = "RetailCatalogProductEntity";
            KeyPrefix = "commonDataModel.retailcatalogproductentity";
            KeySeparator = ".";
            Grouping = "/RetailCatalogProductEntity";

            AddGroup("RetailCatalogProductEntity Details", group =>
            {
                CatalogNumber = group.Add(new VocabularyKey(nameof(CatalogNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayProductNumber = group.Add(new VocabularyKey(nameof(DisplayProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseHierarchy = group.Add(new VocabularyKey(nameof(UseHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Product = group.Add(new VocabularyKey(nameof(Product), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CatalogNumber { get; private set; }
        public VocabularyKey DisplayProductNumber { get; private set; }
        public VocabularyKey UseHierarchy { get; private set; }
        public VocabularyKey Product { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }


    }
}