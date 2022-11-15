using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowElementNotificationMessageEntityVocabulary : SimpleVocabulary
    {
        public WorkflowElementNotificationMessageEntityVocabulary()
        {
            VocabularyName = "Workflow Element Notification Message Entity";
            KeyPrefix = "commonDataModel.workflowelementnotificationmessageentity";
            KeySeparator = ".";
            Grouping = "/WorkflowElementNotificationMessageEntity";

            AddGroup("WorkflowElementNotificationMessageEntity Details", group =>
            {
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElementId = group.Add(new VocabularyKey(nameof(ElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey ElementId { get; private set; }
    }
}