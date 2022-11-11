using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailSharedTwitterParameterEntityVocabulary : SimpleVocabulary
    {
        public RetailSharedTwitterParameterEntityVocabulary()
        {
            VocabularyName = "RetailSharedTwitterParameterEntity";
            KeyPrefix = "commonDataModel.retailsharedtwitterparameterentity";
            KeySeparator = ".";
            Grouping = "/RetailSharedTwitterParameterEntity";

            AddGroup("RetailSharedTwitterParameterEntity Details", group =>
            {
                ConsumerKey = group.Add(new VocabularyKey(nameof(ConsumerKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumerSecret = group.Add(new VocabularyKey(nameof(ConsumerSecret), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ConsumerKey { get; private set; }
        public VocabularyKey ConsumerSecret { get; private set; }
        public VocabularyKey Key { get; private set; }


    }
}