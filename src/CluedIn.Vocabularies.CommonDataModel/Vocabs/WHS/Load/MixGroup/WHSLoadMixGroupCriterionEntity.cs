using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLoadMixGroupCriterionEntityVocabulary : SimpleVocabulary
    {
        public WHSLoadMixGroupCriterionEntityVocabulary()
        {
            VocabularyName = "WHSLoadMixGroupCriterionEntity";
            KeyPrefix = "commonDataModel.whsloadmixgroupcriterionentity";
            KeySeparator = ".";
            Grouping = "/WHSLoadMixGroupCriterionEntity";

            AddGroup("WHSLoadMixGroupCriterionEntity Details", group =>
            {
                LoadMixGroupId = group.Add(new VocabularyKey(nameof(LoadMixGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseFilterCode = group.Add(new VocabularyKey(nameof(WarehouseFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LoadMixGroupId { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey WarehouseFilterCode { get; private set; }


    }
}