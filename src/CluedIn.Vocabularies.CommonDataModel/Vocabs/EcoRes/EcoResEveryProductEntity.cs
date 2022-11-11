using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResEveryProductEntityVocabulary : SimpleVocabulary
    {
        public EcoResEveryProductEntityVocabulary()
        {
            VocabularyName = "EcoResEveryProductEntity";
            KeyPrefix = "commonDataModel.ecoreseveryproductentity";
            KeySeparator = ".";
            Grouping = "/EcoResEveryProductEntity";

            AddGroup("EcoResEveryProductEntity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSearchName = group.Add(new VocabularyKey(nameof(ProductSearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductSearchName { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }


    }
}