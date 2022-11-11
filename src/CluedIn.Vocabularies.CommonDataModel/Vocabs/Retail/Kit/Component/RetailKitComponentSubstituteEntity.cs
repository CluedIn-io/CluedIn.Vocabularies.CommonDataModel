using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailKitComponentSubstituteEntityVocabulary : SimpleVocabulary
    {
        public RetailKitComponentSubstituteEntityVocabulary()
        {
            VocabularyName = "RetailKitComponentSubstituteEntity";
            KeyPrefix = "commonDataModel.retailkitcomponentsubstituteentity";
            KeySeparator = ".";
            Grouping = "/RetailKitComponentSubstituteEntity";

            AddGroup("RetailKitComponentSubstituteEntity Details", group =>
            {
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasureSymbol = group.Add(new VocabularyKey(nameof(UnitOfMeasureSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubstituteProductNumber = group.Add(new VocabularyKey(nameof(SubstituteProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitProductNumber = group.Add(new VocabularyKey(nameof(KitProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitComponentLineNumber = group.Add(new VocabularyKey(nameof(KitComponentLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey UnitOfMeasureSymbol { get; private set; }
        public VocabularyKey SubstituteProductNumber { get; private set; }
        public VocabularyKey KitProductNumber { get; private set; }
        public VocabularyKey KitComponentLineNumber { get; private set; }


    }
}