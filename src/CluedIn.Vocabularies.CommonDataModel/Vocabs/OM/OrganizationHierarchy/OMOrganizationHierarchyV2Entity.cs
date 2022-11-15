using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OMOrganizationHierarchyV2EntityVocabulary : SimpleVocabulary
    {
        public OMOrganizationHierarchyV2EntityVocabulary()
        {
            VocabularyName = "OM Organization Hierarchy V2 Entity";
            KeyPrefix = "commonDataModel.omorganizationhierarchyv2entity";
            KeySeparator = ".";
            Grouping = "/OMOrganizationHierarchyV2Entity";

            AddGroup("OMOrganizationHierarchyV2Entity Details", group =>
            {
                ChildOrganization = group.Add(new VocabularyKey(nameof(ChildOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Hierarchy = group.Add(new VocabularyKey(nameof(Hierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentOrganization = group.Add(new VocabularyKey(nameof(ParentOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyType = group.Add(new VocabularyKey(nameof(HierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChildOrganizationName = group.Add(new VocabularyKey(nameof(ChildOrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChildOrganizationPartyNumber = group.Add(new VocabularyKey(nameof(ChildOrganizationPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentOrganizationName = group.Add(new VocabularyKey(nameof(ParentOrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentOrganizationPartyNumber = group.Add(new VocabularyKey(nameof(ParentOrganizationPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelationshipType = group.Add(new VocabularyKey(nameof(RelationshipType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ChildOrganization { get; private set; }
        public VocabularyKey Hierarchy { get; private set; }
        public VocabularyKey ParentOrganization { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey HierarchyType { get; private set; }
        public VocabularyKey ChildOrganizationName { get; private set; }
        public VocabularyKey ChildOrganizationPartyNumber { get; private set; }
        public VocabularyKey ParentOrganizationName { get; private set; }
        public VocabularyKey ParentOrganizationPartyNumber { get; private set; }
        public VocabularyKey RelationshipType { get; private set; }
    }
}