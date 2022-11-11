using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BucketVocabulary : SimpleVocabulary
    {
        public BucketVocabulary()
        {
            VocabularyName = "Common Data Model Bucket";
            KeyPrefix = "commonDataModel.bucket";
            KeySeparator = ".";
            Grouping = "/Bucket";

            AddGroup("Common Data Model Bucket Details", group =>
            {
                bucketId = group.Add(new VocabularyKey(nameof(bucketId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                value = group.Add(new VocabularyKey(nameof(value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey bucketId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey value { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}