using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OMOrganizationHierarchyPublishedAndDraftV2EntityVocabulary : SimpleVocabulary
    {
        public OMOrganizationHierarchyPublishedAndDraftV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model OMOrganizationHierarchyPublishedAndDraftV2Entity";
            KeyPrefix = "commonDataModel.omorganizationhierarchypublishedanddraftv2entity";
            KeySeparator = ".";
            Grouping = "/OMOrganizationHierarchyPublishedAndDraftV2Entity";

            AddGroup("Common Data Model OMOrganizationHierarchyPublishedAndDraftV2Entity Details", group =>
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
IsDraft = group.Add(new VocabularyKey(nameof(IsDraft), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
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
public VocabularyKey IsDraft { get; private set; }


    }
}