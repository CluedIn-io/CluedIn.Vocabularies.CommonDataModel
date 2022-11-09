using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemSecurityUserRoleOrganizationEntityVocabulary : SimpleVocabulary
    {
        public SystemSecurityUserRoleOrganizationEntityVocabulary()
        {
            VocabularyName = "Common Data Model SystemSecurityUserRoleOrganizationEntity";
            KeyPrefix = "commonDataModel.systemsecurityuserroleorganizationentity";
            KeySeparator = ".";
            Grouping = "/SystemSecurityUserRoleOrganizationEntity";

            AddGroup("Common Data Model SystemSecurityUserRoleOrganizationEntity Details", group =>
            {
                UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SecurityRoleIdentifier = group.Add(new VocabularyKey(nameof(SecurityRoleIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationType = group.Add(new VocabularyKey(nameof(OrganizationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationId = group.Add(new VocabularyKey(nameof(OrganizationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitType = group.Add(new VocabularyKey(nameof(OperatingUnitType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HierarchyType = group.Add(new VocabularyKey(nameof(HierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HierarchyTypeReference = group.Add(new VocabularyKey(nameof(HierarchyTypeReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InternalOrganizationReference = group.Add(new VocabularyKey(nameof(InternalOrganizationReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SecurityRoleReference = group.Add(new VocabularyKey(nameof(SecurityRoleReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey UserId { get; private set; }
public VocabularyKey SecurityRoleIdentifier { get; private set; }
public VocabularyKey OrganizationType { get; private set; }
public VocabularyKey OrganizationId { get; private set; }
public VocabularyKey OperatingUnitType { get; private set; }
public VocabularyKey HierarchyType { get; private set; }
public VocabularyKey HierarchyTypeReference { get; private set; }
public VocabularyKey InternalOrganizationReference { get; private set; }
public VocabularyKey SecurityRoleReference { get; private set; }


    }
}