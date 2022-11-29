using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class GoalCategoryVocabulary : SimpleVocabulary
    {
        public GoalCategoryVocabulary()
        {
            VocabularyName = "Goal Category";
            KeyPrefix = "commonDataModel.goalcategory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/GoalCategory";

            AddGroup("GoalCategory Details for ElectronicMedicalRecords", group =>
            {
			    GoalCategoryId = group.Add(new VocabularyKey(nameof(GoalCategoryId), "Goal Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey GoalCategoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}