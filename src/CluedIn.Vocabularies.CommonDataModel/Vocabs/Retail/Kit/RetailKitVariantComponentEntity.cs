using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailKitVariantComponentEntityVocabulary : SimpleVocabulary
    {
        public RetailKitVariantComponentEntityVocabulary()
        {
            VocabularyName = "RetailKitVariantComponentEntity";
            KeyPrefix = "commonDataModel.retailkitvariantcomponententity";
            KeySeparator = ".";
            Grouping = "/RetailKitVariantComponentEntity";

            AddGroup("RetailKitVariantComponentEntity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVariantNumber = group.Add(new VocabularyKey(nameof(ProductVariantNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitProductNumber = group.Add(new VocabularyKey(nameof(KitProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitComponentLineNumber = group.Add(new VocabularyKey(nameof(KitComponentLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasureSymbol = group.Add(new VocabularyKey(nameof(UnitOfMeasureSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductVariantNumber { get; private set; }
        public VocabularyKey KitProductNumber { get; private set; }
        public VocabularyKey KitComponentLineNumber { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey UnitOfMeasureSymbol { get; private set; }


    }
}