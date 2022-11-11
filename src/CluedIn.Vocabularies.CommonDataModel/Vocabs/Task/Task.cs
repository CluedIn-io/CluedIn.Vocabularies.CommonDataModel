using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaskVocabulary : SimpleVocabulary
    {
        public TaskVocabulary()
        {
            VocabularyName = "Common Data Model Task";
            KeyPrefix = "commonDataModel.task";
            KeySeparator = ".";
            Grouping = "/Task";

            AddGroup("Common Data Model Task Details", group =>
            {

            });
        }



    }
}