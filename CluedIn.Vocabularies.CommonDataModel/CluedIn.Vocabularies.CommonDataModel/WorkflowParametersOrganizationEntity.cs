using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowParametersOrganizationEntityVocabulary : SimpleVocabulary
    {
        public WorkflowParametersOrganizationEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkflowParametersOrganizationEntity";
            KeyPrefix = "commonDataModel.workflowparametersorganizationentity";
            KeySeparator = ".";
            Grouping = "/WorkflowParametersOrganizationEntity";

            AddGroup("Common Data Model WorkflowParametersOrganizationEntity Details", group =>
            {
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowNotifications = group.Add(new VocabularyKey(nameof(WorkflowNotifications), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ID { get; private set; }
public VocabularyKey WorkflowNotifications { get; private set; }


    }
}