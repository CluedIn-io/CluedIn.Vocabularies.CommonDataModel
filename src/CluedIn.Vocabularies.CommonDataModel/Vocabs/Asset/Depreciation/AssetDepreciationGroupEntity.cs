using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetDepreciationGroupEntityVocabulary : SimpleVocabulary
    {
        public AssetDepreciationGroupEntityVocabulary()
        {
            VocabularyName = "AssetDepreciationGroupEntity";
            KeyPrefix = "commonDataModel.assetdepreciationgroupentity";
            KeySeparator = ".";
            Grouping = "/AssetDepreciationGroupEntity";

            AddGroup("AssetDepreciationGroupEntity Details", group =>
            {
                DepreciationGroup = group.Add(new VocabularyKey(nameof(DepreciationGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Factor = group.Add(new VocabularyKey(nameof(Factor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FactorAlt = group.Add(new VocabularyKey(nameof(FactorAlt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FactorExt = group.Add(new VocabularyKey(nameof(FactorExt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostLimit_PL = group.Add(new VocabularyKey(nameof(CostLimit_PL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DepreciationGroup { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Factor { get; private set; }
        public VocabularyKey FactorAlt { get; private set; }
        public VocabularyKey FactorExt { get; private set; }
        public VocabularyKey CostLimit_PL { get; private set; }


    }
}