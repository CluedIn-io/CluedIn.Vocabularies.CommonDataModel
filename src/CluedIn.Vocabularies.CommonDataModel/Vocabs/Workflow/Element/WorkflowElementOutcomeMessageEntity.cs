using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowElementOutcomeMessageEntityVocabulary : SimpleVocabulary
    {
        public WorkflowElementOutcomeMessageEntityVocabulary()
        {
            VocabularyName = "WorkflowElementOutcomeMessageEntity";
            KeyPrefix = "commonDataModel.workflowelementoutcomemessageentity";
            KeySeparator = ".";
            Grouping = "/WorkflowElementOutcomeMessageEntity";

            AddGroup("WorkflowElementOutcomeMessageEntity Details", group =>
            {
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElementLinkSequence = group.Add(new VocabularyKey(nameof(ElementLinkSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElementLinkSourceElementId = group.Add(new VocabularyKey(nameof(ElementLinkSourceElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElementLinkTargetElementId = group.Add(new VocabularyKey(nameof(ElementLinkTargetElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElementOutcome = group.Add(new VocabularyKey(nameof(ElementOutcome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey ElementLinkSequence { get; private set; }
        public VocabularyKey ElementLinkSourceElementId { get; private set; }
        public VocabularyKey ElementLinkTargetElementId { get; private set; }
        public VocabularyKey ElementOutcome { get; private set; }


    }
}