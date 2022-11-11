using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EntityCounterVocabulary : SimpleVocabulary
    {
        public EntityCounterVocabulary()
        {
            VocabularyName = "Common Data Model EntityCounter";
            KeyPrefix = "commonDataModel.entitycounter";
            KeySeparator = ".";
            Grouping = "/EntityCounter";

            AddGroup("Common Data Model EntityCounter Details", group =>
            {
                counterValue = group.Add(new VocabularyKey(nameof(counterValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                entityCounterId = group.Add(new VocabularyKey(nameof(entityCounterId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                entityName = group.Add(new VocabularyKey(nameof(entityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                @lock = group.Add(new VocabularyKey(nameof(@lock), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey counterValue { get; private set; }
        public VocabularyKey entityCounterId { get; private set; }
        public VocabularyKey entityName { get; private set; }
        public VocabularyKey @lock { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}