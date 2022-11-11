using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowVersionNotificationEntityVocabulary : SimpleVocabulary
    {
        public WorkflowVersionNotificationEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkflowVersionNotificationEntity";
            KeyPrefix = "commonDataModel.workflowversionnotificationentity";
            KeySeparator = ".";
            Grouping = "/WorkflowVersionNotificationEntity";

            AddGroup("Common Data Model WorkflowVersionNotificationEntity Details", group =>
            {
                Action = group.Add(new VocabularyKey(nameof(Action), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Enabled = group.Add(new VocabularyKey(nameof(Enabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowUserValue = group.Add(new VocabularyKey(nameof(WorkflowUserValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssignmentRelationType = group.Add(new VocabularyKey(nameof(AssignmentRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssignmentType = group.Add(new VocabularyKey(nameof(AssignmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyFilterConditionId = group.Add(new VocabularyKey(nameof(HierarchyFilterConditionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyFilterType = group.Add(new VocabularyKey(nameof(HierarchyFilterType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyProviderName = group.Add(new VocabularyKey(nameof(HierarchyProviderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyStopConditionId = group.Add(new VocabularyKey(nameof(HierarchyStopConditionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyTokenName = group.Add(new VocabularyKey(nameof(HierarchyTokenName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParticipantProviderName = group.Add(new VocabularyKey(nameof(ParticipantProviderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParticipantTokenName = group.Add(new VocabularyKey(nameof(ParticipantTokenName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueueProviderName = group.Add(new VocabularyKey(nameof(QueueProviderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueueTokenName = group.Add(new VocabularyKey(nameof(QueueTokenName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserValue = group.Add(new VocabularyKey(nameof(UserValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Action { get; private set; }
        public VocabularyKey Enabled { get; private set; }
        public VocabularyKey WorkflowId { get; private set; }
        public VocabularyKey WorkflowUserValue { get; private set; }
        public VocabularyKey AssignmentRelationType { get; private set; }
        public VocabularyKey AssignmentType { get; private set; }
        public VocabularyKey HierarchyFilterConditionId { get; private set; }
        public VocabularyKey HierarchyFilterType { get; private set; }
        public VocabularyKey HierarchyProviderName { get; private set; }
        public VocabularyKey HierarchyStopConditionId { get; private set; }
        public VocabularyKey HierarchyTokenName { get; private set; }
        public VocabularyKey ParticipantProviderName { get; private set; }
        public VocabularyKey ParticipantTokenName { get; private set; }
        public VocabularyKey QueueProviderName { get; private set; }
        public VocabularyKey QueueTokenName { get; private set; }
        public VocabularyKey UserValue { get; private set; }


    }
}