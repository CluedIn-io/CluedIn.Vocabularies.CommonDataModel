using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowVersionNotesEntityVocabulary : SimpleVocabulary
    {
        public WorkflowVersionNotesEntityVocabulary()
        {
            VocabularyName = "Workflow Version Notes Entity";
            KeyPrefix = "commonDataModel.workflowversionnotesentity";
            KeySeparator = ".";
            Grouping = "/WorkflowVersionNotesEntity";

            AddGroup("WorkflowVersionNotesEntity Details", group =>
            {
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey WorkflowId { get; private set; }
    }
}