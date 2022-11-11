using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class KanbanCirculatingKanbanCardEntityVocabulary : SimpleVocabulary
    {
        public KanbanCirculatingKanbanCardEntityVocabulary()
        {
            VocabularyName = "Common Data Model KanbanCirculatingKanbanCardEntity";
            KeyPrefix = "commonDataModel.kanbancirculatingkanbancardentity";
            KeySeparator = ".";
            Grouping = "/KanbanCirculatingKanbanCardEntity";

            AddGroup("Common Data Model KanbanCirculatingKanbanCardEntity Details", group =>
            {
                CardNumber = group.Add(new VocabularyKey(nameof(CardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Kanban = group.Add(new VocabularyKey(nameof(Kanban), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KanbanRule = group.Add(new VocabularyKey(nameof(KanbanRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintStatus = group.Add(new VocabularyKey(nameof(PrintStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KanbanId = group.Add(new VocabularyKey(nameof(KanbanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KanbanRuleId = group.Add(new VocabularyKey(nameof(KanbanRuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CardNumber { get; private set; }
        public VocabularyKey Kanban { get; private set; }
        public VocabularyKey KanbanRule { get; private set; }
        public VocabularyKey PrintStatus { get; private set; }
        public VocabularyKey KanbanId { get; private set; }
        public VocabularyKey KanbanRuleId { get; private set; }


    }
}