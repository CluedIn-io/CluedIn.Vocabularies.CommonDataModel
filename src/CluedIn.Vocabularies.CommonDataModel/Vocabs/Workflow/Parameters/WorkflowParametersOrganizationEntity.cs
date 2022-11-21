using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowParametersOrganizationEntityVocabulary : SimpleVocabulary
    {
        public WorkflowParametersOrganizationEntityVocabulary()
        {
            VocabularyName = "Workflow Parameters Organization Entity";
            KeyPrefix = "commonDataModel.workflowparametersorganizationentity";
            KeySeparator = ".";
            Grouping = "/WorkflowParametersOrganizationEntity";

            AddGroup("WorkflowParametersOrganizationEntity Details", group =>
            {
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowNotifications = group.Add(new VocabularyKey(nameof(WorkflowNotifications), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey WorkflowNotifications { get; private set; }
    }
}