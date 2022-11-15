using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemSecurityDutyEntityVocabulary : SimpleVocabulary
    {
        public SystemSecurityDutyEntityVocabulary()
        {
            VocabularyName = "System Security Duty Entity";
            KeyPrefix = "commonDataModel.systemsecuritydutyentity";
            KeySeparator = ".";
            Grouping = "/SystemSecurityDutyEntity";

            AddGroup("SystemSecurityDutyEntity Details", group =>
            {
                SecurityRoleIdentifier = group.Add(new VocabularyKey(nameof(SecurityRoleIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityRoleName = group.Add(new VocabularyKey(nameof(SecurityRoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityDutyIdentifier = group.Add(new VocabularyKey(nameof(SecurityDutyIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityDutyName = group.Add(new VocabularyKey(nameof(SecurityDutyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityPrivilegeName = group.Add(new VocabularyKey(nameof(SecurityPrivilegeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityPrivilege = group.Add(new VocabularyKey(nameof(SecurityPrivilege), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityPrivilegeIdentifier = group.Add(new VocabularyKey(nameof(SecurityPrivilegeIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SecurityRoleIdentifier { get; private set; }
        public VocabularyKey SecurityRoleName { get; private set; }
        public VocabularyKey SecurityDutyIdentifier { get; private set; }
        public VocabularyKey SecurityDutyName { get; private set; }
        public VocabularyKey SecurityPrivilegeName { get; private set; }
        public VocabularyKey SecurityPrivilege { get; private set; }
        public VocabularyKey SecurityPrivilegeIdentifier { get; private set; }
    }
}