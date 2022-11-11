using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailSharedFacebookParameterEntityVocabulary : SimpleVocabulary
    {
        public RetailSharedFacebookParameterEntityVocabulary()
        {
            VocabularyName = "RetailSharedFacebookParameterEntity";
            KeyPrefix = "commonDataModel.retailsharedfacebookparameterentity";
            KeySeparator = ".";
            Grouping = "/RetailSharedFacebookParameterEntity";

            AddGroup("RetailSharedFacebookParameterEntity Details", group =>
            {
                ApplicationId = group.Add(new VocabularyKey(nameof(ApplicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplicationSecret = group.Add(new VocabularyKey(nameof(ApplicationSecret), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ApplicationId { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey ApplicationSecret { get; private set; }


    }
}