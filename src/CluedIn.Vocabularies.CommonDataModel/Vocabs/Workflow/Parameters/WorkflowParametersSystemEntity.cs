using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowParametersSystemEntityVocabulary : SimpleVocabulary
    {
        public WorkflowParametersSystemEntityVocabulary()
        {
            VocabularyName = "WorkflowParametersSystemEntity";
            KeyPrefix = "commonDataModel.workflowparameterssystementity";
            KeySeparator = ".";
            Grouping = "/WorkflowParametersSystemEntity";

            AddGroup("WorkflowParametersSystemEntity Details", group =>
            {
                WorkflowExecutionUser = group.Add(new VocabularyKey(nameof(WorkflowExecutionUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowNotifications = group.Add(new VocabularyKey(nameof(WorkflowNotifications), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddAttachments = group.Add(new VocabularyKey(nameof(AddAttachments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfBatchTasks = group.Add(new VocabularyKey(nameof(NumberOfBatchTasks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisallowApprovalBySubmitter = group.Add(new VocabularyKey(nameof(DisallowApprovalBySubmitter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WorkflowExecutionUser { get; private set; }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey WorkflowNotifications { get; private set; }
        public VocabularyKey AddAttachments { get; private set; }
        public VocabularyKey NumberOfBatchTasks { get; private set; }
        public VocabularyKey DisallowApprovalBySubmitter { get; private set; }


    }
}