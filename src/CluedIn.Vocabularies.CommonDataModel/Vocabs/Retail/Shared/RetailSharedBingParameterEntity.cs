using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailSharedBingParameterEntityVocabulary : SimpleVocabulary
    {
        public RetailSharedBingParameterEntityVocabulary()
        {
            VocabularyName = "RetailSharedBingParameterEntity";
            KeyPrefix = "commonDataModel.retailsharedbingparameterentity";
            KeySeparator = ".";
            Grouping = "/RetailSharedBingParameterEntity";

            AddGroup("RetailSharedBingParameterEntity Details", group =>
            {
                ApiKey = group.Add(new VocabularyKey(nameof(ApiKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Enabled = group.Add(new VocabularyKey(nameof(Enabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ApiKey { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey Enabled { get; private set; }


    }
}