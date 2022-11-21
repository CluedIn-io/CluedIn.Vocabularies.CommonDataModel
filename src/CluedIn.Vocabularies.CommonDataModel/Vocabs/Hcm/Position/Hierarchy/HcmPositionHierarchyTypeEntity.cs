using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPositionHierarchyTypeEntityVocabulary : SimpleVocabulary
    {
        public HcmPositionHierarchyTypeEntityVocabulary()
        {
            VocabularyName = "Hcm Position Hierarchy Type Entity";
            KeyPrefix = "commonDataModel.hcmpositionhierarchytypeentity";
            KeySeparator = ".";
            Grouping = "/HcmPositionHierarchyTypeEntity";

            AddGroup("HcmPositionHierarchyTypeEntity Details", group =>
            {
                HierarchyType = group.Add(new VocabularyKey(nameof(HierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsImmutable = group.Add(new VocabularyKey(nameof(IsImmutable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey HierarchyType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey IsImmutable { get; private set; }
    }
}