using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowLineItemEntityVocabulary : SimpleVocabulary
    {
        public WorkflowLineItemEntityVocabulary()
        {
            VocabularyName = "WorkflowLineItemEntity";
            KeyPrefix = "commonDataModel.workflowlineitementity";
            KeySeparator = ".";
            Grouping = "/WorkflowLineItemEntity";

            AddGroup("WorkflowLineItemEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Sequence = group.Add(new VocabularyKey(nameof(Sequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpressionId = group.Add(new VocabularyKey(nameof(ExpressionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElementId = group.Add(new VocabularyKey(nameof(ElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowNumber = group.Add(new VocabularyKey(nameof(WorkflowNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Sequence { get; private set; }
        public VocabularyKey ExpressionId { get; private set; }
        public VocabularyKey ElementId { get; private set; }
        public VocabularyKey WorkflowNumber { get; private set; }


    }
}