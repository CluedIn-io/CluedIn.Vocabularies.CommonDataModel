using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPositionHierarchyEntityVocabulary : SimpleVocabulary
    {
        public HcmPositionHierarchyEntityVocabulary()
        {
            VocabularyName = "HcmPositionHierarchyEntity";
            KeyPrefix = "commonDataModel.hcmpositionhierarchyentity";
            KeySeparator = ".";
            Grouping = "/HcmPositionHierarchyEntity";

            AddGroup("HcmPositionHierarchyEntity Details", group =>
            {
                ParentPosition = group.Add(new VocabularyKey(nameof(ParentPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionHierarchyType = group.Add(new VocabularyKey(nameof(PositionHierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentPositionId = group.Add(new VocabularyKey(nameof(ParentPositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyType = group.Add(new VocabularyKey(nameof(HierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyTypeName = group.Add(new VocabularyKey(nameof(HierarchyTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ParentPosition { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey PositionHierarchyType { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey ParentPositionId { get; private set; }
        public VocabularyKey HierarchyType { get; private set; }
        public VocabularyKey HierarchyTypeName { get; private set; }


    }
}