using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemSecurityPrivilegeEntityVocabulary : SimpleVocabulary
    {
        public SystemSecurityPrivilegeEntityVocabulary()
        {
            VocabularyName = "Common Data Model SystemSecurityPrivilegeEntity";
            KeyPrefix = "commonDataModel.systemsecurityprivilegeentity";
            KeySeparator = ".";
            Grouping = "/SystemSecurityPrivilegeEntity";

            AddGroup("Common Data Model SystemSecurityPrivilegeEntity Details", group =>
            {
                SecurityRoleIdentifier = group.Add(new VocabularyKey(nameof(SecurityRoleIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityRoleName = group.Add(new VocabularyKey(nameof(SecurityRoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityPrivilegeIdentifier = group.Add(new VocabularyKey(nameof(SecurityPrivilegeIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityPrivilegeName = group.Add(new VocabularyKey(nameof(SecurityPrivilegeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SecurityRoleIdentifier { get; private set; }
        public VocabularyKey SecurityRoleName { get; private set; }
        public VocabularyKey SecurityPrivilegeIdentifier { get; private set; }
        public VocabularyKey SecurityPrivilegeName { get; private set; }


    }
}