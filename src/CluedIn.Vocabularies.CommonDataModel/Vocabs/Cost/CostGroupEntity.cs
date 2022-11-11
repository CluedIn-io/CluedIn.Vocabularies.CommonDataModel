using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CostGroupEntityVocabulary : SimpleVocabulary
    {
        public CostGroupEntityVocabulary()
        {
            VocabularyName = "CostGroupEntity";
            KeyPrefix = "commonDataModel.costgroupentity";
            KeySeparator = ".";
            Grouping = "/CostGroupEntity";

            AddGroup("CostGroupEntity Details", group =>
            {
                CostBehaviour = group.Add(new VocabularyKey(nameof(CostBehaviour), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostGroupType = group.Add(new VocabularyKey(nameof(CostGroupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultCostGroup = group.Add(new VocabularyKey(nameof(IsDefaultCostGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CostBehaviour { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey CostGroupType { get; private set; }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey IsDefaultCostGroup { get; private set; }


    }
}