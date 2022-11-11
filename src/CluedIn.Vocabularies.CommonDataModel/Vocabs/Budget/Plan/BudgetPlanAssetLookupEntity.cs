using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanAssetLookupEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanAssetLookupEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetPlanAssetLookupEntity";
            KeyPrefix = "commonDataModel.budgetplanassetlookupentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanAssetLookupEntity";

            AddGroup("Common Data Model BudgetPlanAssetLookupEntity Details", group =>
            {
                AssetId = group.Add(new VocabularyKey(nameof(AssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AssetId { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}