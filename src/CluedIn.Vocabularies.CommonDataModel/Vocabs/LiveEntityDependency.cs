using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LiveEntityDependencyVocabulary : SimpleVocabulary
    {
        public LiveEntityDependencyVocabulary()
        {
            VocabularyName = "Live Entity Dependency";
            KeyPrefix = "commonDataModel.liveentitydependency";
            KeySeparator = ".";
            Grouping = "/LiveEntityDependency";

            AddGroup("LiveEntityDependency Details", group =>
            {
                FromId = group.Add(new VocabularyKey(nameof(FromId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromType = group.Add(new VocabularyKey(nameof(FromType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Fromislive = group.Add(new VocabularyKey(nameof(Fromislive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LiveEntityDependencyId = group.Add(new VocabularyKey(nameof(LiveEntityDependencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToId = group.Add(new VocabularyKey(nameof(ToId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToType = group.Add(new VocabularyKey(nameof(ToType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FromId { get; private set; }
        public VocabularyKey FromType { get; private set; }
        public VocabularyKey Fromislive { get; private set; }
        public VocabularyKey LiveEntityDependencyId { get; private set; }
        public VocabularyKey ToId { get; private set; }
        public VocabularyKey ToType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}