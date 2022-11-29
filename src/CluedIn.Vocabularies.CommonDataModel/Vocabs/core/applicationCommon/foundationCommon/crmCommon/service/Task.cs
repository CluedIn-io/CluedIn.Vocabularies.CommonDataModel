using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class TaskVocabulary : SimpleVocabulary
    {
        public TaskVocabulary()
        {
            VocabularyName = "Task";
            KeyPrefix = "commonDataModel.task.service";
            KeySeparator = ".";
            Grouping = "/Task";

            AddGroup("Task Details for Service", group =>
            {
			                 
            });
        }

        
    }
}