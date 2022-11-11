using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemSecurityPermissionEntityVocabulary : SimpleVocabulary
    {
        public SystemSecurityPermissionEntityVocabulary()
        {
            VocabularyName = "Common Data Model SystemSecurityPermissionEntity";
            KeyPrefix = "commonDataModel.systemsecuritypermissionentity";
            KeySeparator = ".";
            Grouping = "/SystemSecurityPermissionEntity";

            AddGroup("Common Data Model SystemSecurityPermissionEntity Details", group =>
            {
                SecurityRoleIdentifier = group.Add(new VocabularyKey(nameof(SecurityRoleIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityRoleName = group.Add(new VocabularyKey(nameof(SecurityRoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserLicenseType = group.Add(new VocabularyKey(nameof(UserLicenseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceName = group.Add(new VocabularyKey(nameof(ResourceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceType = group.Add(new VocabularyKey(nameof(ResourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateAccess = group.Add(new VocabularyKey(nameof(CreateAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReadAccess = group.Add(new VocabularyKey(nameof(ReadAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpdateAccess = group.Add(new VocabularyKey(nameof(UpdateAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeleteAccess = group.Add(new VocabularyKey(nameof(DeleteAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvokeAccess = group.Add(new VocabularyKey(nameof(InvokeAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectAccess = group.Add(new VocabularyKey(nameof(CorrectAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SecurityRoleIdentifier { get; private set; }
        public VocabularyKey SecurityRoleName { get; private set; }
        public VocabularyKey UserLicenseType { get; private set; }
        public VocabularyKey ResourceName { get; private set; }
        public VocabularyKey ResourceType { get; private set; }
        public VocabularyKey CreateAccess { get; private set; }
        public VocabularyKey ReadAccess { get; private set; }
        public VocabularyKey UpdateAccess { get; private set; }
        public VocabularyKey DeleteAccess { get; private set; }
        public VocabularyKey InvokeAccess { get; private set; }
        public VocabularyKey CorrectAccess { get; private set; }


    }
}