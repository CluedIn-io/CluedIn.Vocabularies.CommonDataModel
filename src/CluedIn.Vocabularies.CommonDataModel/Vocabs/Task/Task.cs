using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaskVocabulary : SimpleVocabulary
    {
        public TaskVocabulary()
        {
            VocabularyName = "Task";
            KeyPrefix = "commonDataModel.task";
            KeySeparator = ".";
            Grouping = "/Task";

            AddGroup("Task Details", group =>
            {

            });
        }



    }
}