using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AgingPeriodDefinitionEntityVocabulary : SimpleVocabulary
    {
        public AgingPeriodDefinitionEntityVocabulary()
        {
            VocabularyName = "Common Data Model AgingPeriodDefinitionEntity";
            KeyPrefix = "commonDataModel.agingperioddefinitionentity";
            KeySeparator = ".";
            Grouping = "/AgingPeriodDefinitionEntity";

            AddGroup("Common Data Model AgingPeriodDefinitionEntity Details", group =>
            {
                AgingPeriodDefinition = group.Add(new VocabularyKey(nameof(AgingPeriodDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintDirection = group.Add(new VocabularyKey(nameof(PrintDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Period = group.Add(new VocabularyKey(nameof(Period), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Unit = group.Add(new VocabularyKey(nameof(Unit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interval = group.Add(new VocabularyKey(nameof(Interval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingIndicator = group.Add(new VocabularyKey(nameof(AgingIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AgingPeriodDefinition { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PrintDirection { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey Period { get; private set; }
        public VocabularyKey Unit { get; private set; }
        public VocabularyKey Interval { get; private set; }
        public VocabularyKey AgingIndicator { get; private set; }


    }
}