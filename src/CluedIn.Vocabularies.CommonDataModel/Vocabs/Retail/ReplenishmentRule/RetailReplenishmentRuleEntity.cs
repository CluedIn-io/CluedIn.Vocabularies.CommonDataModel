using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailReplenishmentRuleEntityVocabulary : SimpleVocabulary
    {
        public RetailReplenishmentRuleEntityVocabulary()
        {
            VocabularyName = "RetailReplenishmentRuleEntity";
            KeyPrefix = "commonDataModel.retailreplenishmentruleentity";
            KeySeparator = ".";
            Grouping = "/RetailReplenishmentRuleEntity";

            AddGroup("RetailReplenishmentRuleEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentRule = group.Add(new VocabularyKey(nameof(ReplenishmentRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey ReplenishmentRule { get; private set; }


    }
}