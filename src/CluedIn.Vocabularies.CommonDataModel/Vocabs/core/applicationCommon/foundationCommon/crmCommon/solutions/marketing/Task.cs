using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class TaskVocabulary : SimpleVocabulary
    {
        public TaskVocabulary()
        {
            VocabularyName = "Task";
            KeyPrefix = "commonDataModel.task.marketing";
            KeySeparator = ".";
            Grouping = "/Task";

            AddGroup("Task Details for Marketing", group =>
            {
			    CustomerJourneyIteration = group.Add(new VocabularyKey(nameof(CustomerJourneyIteration), "Customer journey iteration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CustomerJourneyIteration { get; private set; }
    }
}