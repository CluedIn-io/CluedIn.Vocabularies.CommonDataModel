using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailStoreSafeEntityVocabulary : SimpleVocabulary
    {
        public RetailStoreSafeEntityVocabulary()
        {
            VocabularyName = "RetailStoreSafeEntity";
            KeyPrefix = "commonDataModel.retailstoresafeentity";
            KeySeparator = ".";
            Grouping = "/RetailStoreSafeEntity";

            AddGroup("RetailStoreSafeEntity Details", group =>
            {
                SafeNumber = group.Add(new VocabularyKey(nameof(SafeNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SafeNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StoreNumber { get; private set; }


    }
}