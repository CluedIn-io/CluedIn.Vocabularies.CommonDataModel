using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class PriorityVocabulary : SimpleVocabulary
    {
        public PriorityVocabulary()
        {
            VocabularyName = "Priority";
            KeyPrefix = "commonDataModel.priority.scheduling";
            KeySeparator = ".";
            Grouping = "/Priority";

            AddGroup("Priority Details for Scheduling", group =>
            {
			    PriorityId = group.Add(new VocabularyKey(nameof(PriorityId), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LevelofImportance = group.Add(new VocabularyKey(nameof(LevelofImportance), "Level of Importance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PriorityColor = group.Add(new VocabularyKey(nameof(PriorityColor), "Priority Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PriorityId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey LevelofImportance { get; private set; }
        public VocabularyKey PriorityColor { get; private set; }
    }
}