using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemSecurityUserRoleEntityVocabulary : SimpleVocabulary
    {
        public SystemSecurityUserRoleEntityVocabulary()
        {
            VocabularyName = "SystemSecurityUserRoleEntity";
            KeyPrefix = "commonDataModel.systemsecurityuserroleentity";
            KeySeparator = ".";
            Grouping = "/SystemSecurityUserRoleEntity";

            AddGroup("SystemSecurityUserRoleEntity Details", group =>
            {
                AssignmentMode = group.Add(new VocabularyKey(nameof(AssignmentMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssignmentStatus = group.Add(new VocabularyKey(nameof(AssignmentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityRole = group.Add(new VocabularyKey(nameof(SecurityRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityRoleIdentifier = group.Add(new VocabularyKey(nameof(SecurityRoleIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityRoleName = group.Add(new VocabularyKey(nameof(SecurityRoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserLicenseType = group.Add(new VocabularyKey(nameof(UserLicenseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AssignmentMode { get; private set; }
        public VocabularyKey AssignmentStatus { get; private set; }
        public VocabularyKey SecurityRole { get; private set; }
        public VocabularyKey UserId { get; private set; }
        public VocabularyKey SecurityRoleIdentifier { get; private set; }
        public VocabularyKey SecurityRoleName { get; private set; }
        public VocabularyKey UserLicenseType { get; private set; }


    }
}