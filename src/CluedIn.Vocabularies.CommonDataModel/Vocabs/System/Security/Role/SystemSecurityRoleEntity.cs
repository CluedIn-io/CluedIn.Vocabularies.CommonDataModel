using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemSecurityRoleEntityVocabulary : SimpleVocabulary
    {
        public SystemSecurityRoleEntityVocabulary()
        {
            VocabularyName = "SystemSecurityRoleEntity";
            KeyPrefix = "commonDataModel.systemsecurityroleentity";
            KeySeparator = ".";
            Grouping = "/SystemSecurityRoleEntity";

            AddGroup("SystemSecurityRoleEntity Details", group =>
            {
                SecurityRoleIdentifier = group.Add(new VocabularyKey(nameof(SecurityRoleIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityRoleName = group.Add(new VocabularyKey(nameof(SecurityRoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccessToSensitiveData = group.Add(new VocabularyKey(nameof(AccessToSensitiveData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserLicenseType = group.Add(new VocabularyKey(nameof(UserLicenseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContextString = group.Add(new VocabularyKey(nameof(ContextString), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SecurityRoleIdentifier { get; private set; }
        public VocabularyKey SecurityRoleName { get; private set; }
        public VocabularyKey AccessToSensitiveData { get; private set; }
        public VocabularyKey UserLicenseType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ContextString { get; private set; }


    }
}