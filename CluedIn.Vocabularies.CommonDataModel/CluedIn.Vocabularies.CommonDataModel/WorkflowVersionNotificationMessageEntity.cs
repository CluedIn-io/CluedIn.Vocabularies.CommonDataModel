using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowVersionNotificationMessageEntityVocabulary : SimpleVocabulary
    {
        public WorkflowVersionNotificationMessageEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkflowVersionNotificationMessageEntity";
            KeyPrefix = "commonDataModel.workflowversionnotificationmessageentity";
            KeySeparator = ".";
            Grouping = "/WorkflowVersionNotificationMessageEntity";

            AddGroup("Common Data Model WorkflowVersionNotificationMessageEntity Details", group =>
            {
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LanguageId { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Text { get; private set; }
public VocabularyKey WorkflowId { get; private set; }


    }
}