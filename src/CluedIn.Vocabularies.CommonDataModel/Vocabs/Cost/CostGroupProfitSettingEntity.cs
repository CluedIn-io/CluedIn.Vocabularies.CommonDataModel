using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CostGroupProfitSettingEntityVocabulary : SimpleVocabulary
    {
        public CostGroupProfitSettingEntityVocabulary()
        {
            VocabularyName = "CostGroupProfitSettingEntity";
            KeyPrefix = "commonDataModel.costgroupprofitsettingentity";
            KeySeparator = ".";
            Grouping = "/CostGroupProfitSettingEntity";

            AddGroup("CostGroupProfitSettingEntity Details", group =>
            {
                CostGroupId = group.Add(new VocabularyKey(nameof(CostGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitPercentage = group.Add(new VocabularyKey(nameof(ProfitPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitSetting = group.Add(new VocabularyKey(nameof(ProfitSetting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CostGroupId { get; private set; }
        public VocabularyKey ProfitPercentage { get; private set; }
        public VocabularyKey ProfitSetting { get; private set; }


    }
}