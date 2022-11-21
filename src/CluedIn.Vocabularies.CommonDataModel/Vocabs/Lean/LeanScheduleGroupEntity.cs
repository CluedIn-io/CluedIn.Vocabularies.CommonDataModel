using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeanScheduleGroupEntityVocabulary : SimpleVocabulary
    {
        public LeanScheduleGroupEntityVocabulary()
        {
            VocabularyName = "Lean Schedule Group Entity";
            KeyPrefix = "commonDataModel.leanschedulegroupentity";
            KeySeparator = ".";
            Grouping = "/LeanScheduleGroupEntity";

            AddGroup("LeanScheduleGroupEntity Details", group =>
            {
                ScheduleColor = group.Add(new VocabularyKey(nameof(ScheduleColor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduleIntegerRGBColor = group.Add(new VocabularyKey(nameof(ScheduleIntegerRGBColor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkCellOperationsResourceGroup = group.Add(new VocabularyKey(nameof(WorkCellOperationsResourceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NullableWorkCellOperationsResourceGroupId = group.Add(new VocabularyKey(nameof(NullableWorkCellOperationsResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkCellOperationsResourceGroupId = group.Add(new VocabularyKey(nameof(WorkCellOperationsResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ScheduleColor { get; private set; }
        public VocabularyKey ScheduleIntegerRGBColor { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey WorkCellOperationsResourceGroup { get; private set; }
        public VocabularyKey NullableWorkCellOperationsResourceGroupId { get; private set; }
        public VocabularyKey WorkCellOperationsResourceGroupId { get; private set; }
    }
}