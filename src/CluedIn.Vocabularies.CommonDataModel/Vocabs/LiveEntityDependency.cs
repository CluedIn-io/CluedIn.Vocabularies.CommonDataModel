using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LiveEntityDependencyVocabulary : SimpleVocabulary
    {
        public LiveEntityDependencyVocabulary()
        {
            VocabularyName = "LiveEntityDependency";
            KeyPrefix = "commonDataModel.liveentitydependency";
            KeySeparator = ".";
            Grouping = "/LiveEntityDependency";

            AddGroup("LiveEntityDependency Details", group =>
            {
                fromId = group.Add(new VocabularyKey(nameof(fromId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                fromType = group.Add(new VocabularyKey(nameof(fromType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                fromislive = group.Add(new VocabularyKey(nameof(fromislive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                liveEntityDependencyId = group.Add(new VocabularyKey(nameof(liveEntityDependencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                toId = group.Add(new VocabularyKey(nameof(toId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                toType = group.Add(new VocabularyKey(nameof(toType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey fromId { get; private set; }
        public VocabularyKey fromType { get; private set; }
        public VocabularyKey fromislive { get; private set; }
        public VocabularyKey liveEntityDependencyId { get; private set; }
        public VocabularyKey toId { get; private set; }
        public VocabularyKey toType { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}