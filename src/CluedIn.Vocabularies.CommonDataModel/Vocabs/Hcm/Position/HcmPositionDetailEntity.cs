using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPositionDetailEntityVocabulary : SimpleVocabulary
    {
        public HcmPositionDetailEntityVocabulary()
        {
            VocabularyName = "Hcm Position Detail Entity";
            KeyPrefix = "commonDataModel.hcmpositiondetailentity";
            KeySeparator = ".";
            Grouping = "/HcmPositionDetailEntity";

            AddGroup("HcmPositionDetailEntity Details", group =>
            {
                AvailableForAssignment = group.Add(new VocabularyKey(nameof(AvailableForAssignment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompensationRegion = group.Add(new VocabularyKey(nameof(CompensationRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompensationRegionId = group.Add(new VocabularyKey(nameof(CompensationRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Department = group.Add(new VocabularyKey(nameof(Department), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepartmentNumber = group.Add(new VocabularyKey(nameof(DepartmentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullTimeEquivalent = group.Add(new VocabularyKey(nameof(FullTimeEquivalent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionType = group.Add(new VocabularyKey(nameof(PositionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionTypeId = group.Add(new VocabularyKey(nameof(PositionTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TitleId = group.Add(new VocabularyKey(nameof(TitleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AvailableForAssignment { get; private set; }
        public VocabularyKey CompensationRegion { get; private set; }
        public VocabularyKey CompensationRegionId { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey DepartmentNumber { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FullTimeEquivalent { get; private set; }
        public VocabularyKey Job { get; private set; }
        public VocabularyKey JobId { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey PositionType { get; private set; }
        public VocabularyKey PositionTypeId { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey TitleId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
    }
}