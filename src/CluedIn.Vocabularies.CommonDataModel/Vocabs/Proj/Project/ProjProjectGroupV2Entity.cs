using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectGroupV2EntityVocabulary : SimpleVocabulary
    {
        public ProjProjectGroupV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjProjectGroupV2Entity";
            KeyPrefix = "commonDataModel.projprojectgroupv2entity";
            KeySeparator = ".";
            Grouping = "/ProjProjectGroupV2Entity";

            AddGroup("Common Data Model ProjProjectGroupV2Entity Details", group =>
            {
                WillCostBeVerifiedAgainstRemainingForecast = group.Add(new VocabularyKey(nameof(WillCostBeVerifiedAgainstRemainingForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinePropertySearchPriorityType = group.Add(new VocabularyKey(nameof(LinePropertySearchPriorityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerPostingSearchPriorityType = group.Add(new VocabularyKey(nameof(LedgerPostingSearchPriorityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLinePropertyId = group.Add(new VocabularyKey(nameof(ProjectLinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WillCostBeVerifiedAgainstRemainingForecast { get; private set; }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey LinePropertySearchPriorityType { get; private set; }
        public VocabularyKey LedgerPostingSearchPriorityType { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey ProjectLinePropertyId { get; private set; }


    }
}