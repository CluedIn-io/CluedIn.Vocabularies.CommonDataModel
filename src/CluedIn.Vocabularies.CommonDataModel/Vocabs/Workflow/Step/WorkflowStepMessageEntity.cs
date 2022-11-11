using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowStepMessageEntityVocabulary : SimpleVocabulary
    {
        public WorkflowStepMessageEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkflowStepMessageEntity";
            KeyPrefix = "commonDataModel.workflowstepmessageentity";
            KeySeparator = ".";
            Grouping = "/WorkflowStepMessageEntity";

            AddGroup("Common Data Model WorkflowStepMessageEntity Details", group =>
            {
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StepId = group.Add(new VocabularyKey(nameof(StepId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey StepId { get; private set; }


    }
}