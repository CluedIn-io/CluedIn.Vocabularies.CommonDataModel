using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OMOrganizationHierarchyPublishedV2EntityVocabulary : SimpleVocabulary
    {
        public OMOrganizationHierarchyPublishedV2EntityVocabulary()
        {
            VocabularyName = "OMOrganizationHierarchyPublishedV2Entity";
            KeyPrefix = "commonDataModel.omorganizationhierarchypublishedv2entity";
            KeySeparator = ".";
            Grouping = "/OMOrganizationHierarchyPublishedV2Entity";

            AddGroup("OMOrganizationHierarchyPublishedV2Entity Details", group =>
            {
                ChildOrganization = group.Add(new VocabularyKey(nameof(ChildOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Hierarchy = group.Add(new VocabularyKey(nameof(Hierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentOrganization = group.Add(new VocabularyKey(nameof(ParentOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                validFrom = group.Add(new VocabularyKey(nameof(validFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                validTo = group.Add(new VocabularyKey(nameof(validTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
        public VocabularyKey validFrom { get; private set; }
        public VocabularyKey validTo { get; private set; }
        public VocabularyKey HierarchyType { get; private set; }
        public VocabularyKey ChildOrganizationName { get; private set; }
        public VocabularyKey ChildOrganizationPartyNumber { get; private set; }
        public VocabularyKey ParentOrganizationName { get; private set; }
        public VocabularyKey ParentOrganizationPartyNumber { get; private set; }
        public VocabularyKey RelationshipType { get; private set; }


    }
}