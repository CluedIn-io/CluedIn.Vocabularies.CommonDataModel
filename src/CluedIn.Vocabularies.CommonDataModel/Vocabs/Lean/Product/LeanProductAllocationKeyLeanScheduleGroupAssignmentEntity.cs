using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeanProductAllocationKeyLeanScheduleGroupAssignmentEntityVocabulary : SimpleVocabulary
    {
        public LeanProductAllocationKeyLeanScheduleGroupAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model LeanProductAllocationKeyLeanScheduleGroupAssignmentEntity";
            KeyPrefix = "commonDataModel.leanproductallocationkeyleanschedulegroupassignmententity";
            KeySeparator = ".";
            Grouping = "/LeanProductAllocationKeyLeanScheduleGroupAssignmentEntity";

            AddGroup("Common Data Model LeanProductAllocationKeyLeanScheduleGroupAssignmentEntity Details", group =>
            {
                LeanScheduleGroup = group.Add(new VocabularyKey(nameof(LeanScheduleGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeanScheduleGroupId = group.Add(new VocabularyKey(nameof(LeanScheduleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkCellOperationsResourceGroup = group.Add(new VocabularyKey(nameof(WorkCellOperationsResourceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NullableWorkCellOperationsResourceGroupId = group.Add(new VocabularyKey(nameof(NullableWorkCellOperationsResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkCellOperationsResourceGroupId = group.Add(new VocabularyKey(nameof(WorkCellOperationsResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAllocationKeyId = group.Add(new VocabularyKey(nameof(ProductAllocationKeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThroughputRatio = group.Add(new VocabularyKey(nameof(ThroughputRatio), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LeanScheduleGroup { get; private set; }
        public VocabularyKey LeanScheduleGroupId { get; private set; }
        public VocabularyKey WorkCellOperationsResourceGroup { get; private set; }
        public VocabularyKey NullableWorkCellOperationsResourceGroupId { get; private set; }
        public VocabularyKey WorkCellOperationsResourceGroupId { get; private set; }
        public VocabularyKey ProductAllocationKeyId { get; private set; }
        public VocabularyKey ThroughputRatio { get; private set; }


    }
}