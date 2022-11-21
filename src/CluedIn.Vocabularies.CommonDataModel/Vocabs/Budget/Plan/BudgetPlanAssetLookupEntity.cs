using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanAssetLookupEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanAssetLookupEntityVocabulary()
        {
            VocabularyName = "Budget Plan Asset Lookup Entity";
            KeyPrefix = "commonDataModel.budgetplanassetlookupentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanAssetLookupEntity";

            AddGroup("BudgetPlanAssetLookupEntity Details", group =>
            {
                AssetId = group.Add(new VocabularyKey(nameof(AssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AssetId { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}