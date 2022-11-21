using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OMOrganizationHierarchyTypeEntityVocabulary : SimpleVocabulary
    {
        public OMOrganizationHierarchyTypeEntityVocabulary()
        {
            VocabularyName = "OM Organization Hierarchy Type Entity";
            KeyPrefix = "commonDataModel.omorganizationhierarchytypeentity";
            KeySeparator = ".";
            Grouping = "/OMOrganizationHierarchyTypeEntity";

            AddGroup("OMOrganizationHierarchyTypeEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelationshipTypeID = group.Add(new VocabularyKey(nameof(RelationshipTypeID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RelationshipTypeID { get; private set; }
    }
}