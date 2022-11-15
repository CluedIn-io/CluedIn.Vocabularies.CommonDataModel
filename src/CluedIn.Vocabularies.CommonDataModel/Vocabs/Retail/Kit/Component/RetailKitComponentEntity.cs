using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailKitComponentEntityVocabulary : SimpleVocabulary
    {
        public RetailKitComponentEntityVocabulary()
        {
            VocabularyName = "Retail Kit Component Entity";
            KeyPrefix = "commonDataModel.retailkitcomponententity";
            KeySeparator = ".";
            Grouping = "/RetailKitComponentEntity";

            AddGroup("RetailKitComponentEntity Details", group =>
            {
                DoNotShowAtRegister = group.Add(new VocabularyKey(nameof(DoNotShowAtRegister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasure = group.Add(new VocabularyKey(nameof(UnitOfMeasure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasureSymbol = group.Add(new VocabularyKey(nameof(UnitOfMeasureSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitProductNumber = group.Add(new VocabularyKey(nameof(KitProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComponentProductNumber = group.Add(new VocabularyKey(nameof(ComponentProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DoNotShowAtRegister { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey UnitOfMeasure { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey UnitOfMeasureSymbol { get; private set; }
        public VocabularyKey KitProductNumber { get; private set; }
        public VocabularyKey ComponentProductNumber { get; private set; }
    }
}