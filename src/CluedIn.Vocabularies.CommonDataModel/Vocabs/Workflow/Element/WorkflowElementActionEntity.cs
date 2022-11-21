using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowElementActionEntityVocabulary : SimpleVocabulary
    {
        public WorkflowElementActionEntityVocabulary()
        {
            VocabularyName = "Workflow Element Action Entity";
            KeyPrefix = "commonDataModel.workflowelementactionentity";
            KeySeparator = ".";
            Grouping = "/WorkflowElementActionEntity";

            AddGroup("WorkflowElementActionEntity Details", group =>
            {
                Enabled = group.Add(new VocabularyKey(nameof(Enabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOutcome = group.Add(new VocabularyKey(nameof(IsOutcome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElementId = group.Add(new VocabularyKey(nameof(ElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Enabled { get; private set; }
        public VocabularyKey IsOutcome { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ElementId { get; private set; }
    }
}