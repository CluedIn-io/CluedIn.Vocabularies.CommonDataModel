using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemSecuritySubRoleEntityVocabulary : SimpleVocabulary
    {
        public SystemSecuritySubRoleEntityVocabulary()
        {
            VocabularyName = "SystemSecuritySubRoleEntity";
            KeyPrefix = "commonDataModel.systemsecuritysubroleentity";
            KeySeparator = ".";
            Grouping = "/SystemSecuritySubRoleEntity";

            AddGroup("SystemSecuritySubRoleEntity Details", group =>
            {
                SecurityRoleIdentifier = group.Add(new VocabularyKey(nameof(SecurityRoleIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityRoleName = group.Add(new VocabularyKey(nameof(SecurityRoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecuritySubRoleName = group.Add(new VocabularyKey(nameof(SecuritySubRoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecuritySubRoleIdentifier = group.Add(new VocabularyKey(nameof(SecuritySubRoleIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SecurityRoleIdentifier { get; private set; }
        public VocabularyKey SecurityRoleName { get; private set; }
        public VocabularyKey SecuritySubRoleName { get; private set; }
        public VocabularyKey SecuritySubRoleIdentifier { get; private set; }


    }
}