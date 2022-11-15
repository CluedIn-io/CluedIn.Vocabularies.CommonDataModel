using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailKitReleasedSubstituteEntityVocabulary : SimpleVocabulary
    {
        public RetailKitReleasedSubstituteEntityVocabulary()
        {
            VocabularyName = "Retail Kit Released Substitute Entity";
            KeyPrefix = "commonDataModel.retailkitreleasedsubstituteentity";
            KeySeparator = ".";
            Grouping = "/RetailKitReleasedSubstituteEntity";

            AddGroup("RetailKitReleasedSubstituteEntity Details", group =>
            {
                SubstituteCharge = group.Add(new VocabularyKey(nameof(SubstituteCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitProductNumber = group.Add(new VocabularyKey(nameof(KitProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitComponentLineNumber = group.Add(new VocabularyKey(nameof(KitComponentLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubstituteProductNumber = group.Add(new VocabularyKey(nameof(SubstituteProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SubstituteCharge { get; private set; }
        public VocabularyKey KitProductNumber { get; private set; }
        public VocabularyKey KitComponentLineNumber { get; private set; }
        public VocabularyKey SubstituteProductNumber { get; private set; }
    }
}