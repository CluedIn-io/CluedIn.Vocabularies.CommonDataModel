using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanProjectLookupEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanProjectLookupEntityVocabulary()
        {
            VocabularyName = "Budget Plan Project Lookup Entity";
            KeyPrefix = "commonDataModel.budgetplanprojectlookupentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanProjectLookupEntity";

            AddGroup("BudgetPlanProjectLookupEntity Details", group =>
            {
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectStatusRule = group.Add(new VocabularyKey(nameof(ProjectStatusRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProjectStatusRule { get; private set; }
    }
}