using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EntityCounterVocabulary : SimpleVocabulary
    {
        public EntityCounterVocabulary()
        {
            VocabularyName = "Entity Counter";
            KeyPrefix = "commonDataModel.entitycounter";
            KeySeparator = ".";
            Grouping = "/EntityCounter";

            AddGroup("EntityCounter Details", group =>
            {
                CounterValue = group.Add(new VocabularyKey(nameof(CounterValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityCounterId = group.Add(new VocabularyKey(nameof(EntityCounterId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityName = group.Add(new VocabularyKey(nameof(EntityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                @Lock = group.Add(new VocabularyKey(nameof(@Lock), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CounterValue { get; private set; }
        public VocabularyKey EntityCounterId { get; private set; }
        public VocabularyKey EntityName { get; private set; }
        public VocabularyKey @Lock { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}