using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemSecurityRoleDutyEntityVocabulary : SimpleVocabulary
    {
        public SystemSecurityRoleDutyEntityVocabulary()
        {
            VocabularyName = "System Security Role Duty Entity";
            KeyPrefix = "commonDataModel.systemsecurityroledutyentity";
            KeySeparator = ".";
            Grouping = "/SystemSecurityRoleDutyEntity";

            AddGroup("SystemSecurityRoleDutyEntity Details", group =>
            {
                SecurityRoleIdentifier = group.Add(new VocabularyKey(nameof(SecurityRoleIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityRoleName = group.Add(new VocabularyKey(nameof(SecurityRoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityDutyIdentifier = group.Add(new VocabularyKey(nameof(SecurityDutyIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityDutyName = group.Add(new VocabularyKey(nameof(SecurityDutyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SecurityRoleIdentifier { get; private set; }
        public VocabularyKey SecurityRoleName { get; private set; }
        public VocabularyKey SecurityDutyIdentifier { get; private set; }
        public VocabularyKey SecurityDutyName { get; private set; }
    }
}