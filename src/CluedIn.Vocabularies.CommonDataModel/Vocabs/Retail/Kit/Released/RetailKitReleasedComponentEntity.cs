using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailKitReleasedComponentEntityVocabulary : SimpleVocabulary
    {
        public RetailKitReleasedComponentEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailKitReleasedComponentEntity";
            KeyPrefix = "commonDataModel.retailkitreleasedcomponententity";
            KeySeparator = ".";
            Grouping = "/RetailKitReleasedComponentEntity";

            AddGroup("Common Data Model RetailKitReleasedComponentEntity Details", group =>
            {
                BasePrice = group.Add(new VocabularyKey(nameof(BasePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitPrice = group.Add(new VocabularyKey(nameof(KitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitProductNumber = group.Add(new VocabularyKey(nameof(KitProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitComponentLineNumber = group.Add(new VocabularyKey(nameof(KitComponentLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BasePrice { get; private set; }
        public VocabularyKey KitPrice { get; private set; }
        public VocabularyKey KitProductNumber { get; private set; }
        public VocabularyKey KitComponentLineNumber { get; private set; }


    }
}