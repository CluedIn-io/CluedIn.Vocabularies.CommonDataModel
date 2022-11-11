using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OMOrganizationHierarchyPurposeEntityVocabulary : SimpleVocabulary
    {
        public OMOrganizationHierarchyPurposeEntityVocabulary()
        {
            VocabularyName = "OMOrganizationHierarchyPurposeEntity";
            KeyPrefix = "commonDataModel.omorganizationhierarchypurposeentity";
            KeySeparator = ".";
            Grouping = "/OMOrganizationHierarchyPurposeEntity";

            AddGroup("OMOrganizationHierarchyPurposeEntity Details", group =>
            {
                HierarchyPurpose = group.Add(new VocabularyKey(nameof(HierarchyPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyTypeRecId = group.Add(new VocabularyKey(nameof(HierarchyTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetAsDefault = group.Add(new VocabularyKey(nameof(SetAsDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Immutable = group.Add(new VocabularyKey(nameof(Immutable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyType = group.Add(new VocabularyKey(nameof(HierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey HierarchyPurpose { get; private set; }
        public VocabularyKey HierarchyTypeRecId { get; private set; }
        public VocabularyKey SetAsDefault { get; private set; }
        public VocabularyKey Immutable { get; private set; }
        public VocabularyKey HierarchyType { get; private set; }


    }
}