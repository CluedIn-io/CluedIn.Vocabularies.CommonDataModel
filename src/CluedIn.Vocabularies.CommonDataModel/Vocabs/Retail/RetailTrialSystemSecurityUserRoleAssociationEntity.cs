using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTrialSystemSecurityUserRoleAssociationEntityVocabulary : SimpleVocabulary
    {
        public RetailTrialSystemSecurityUserRoleAssociationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTrialSystemSecurityUserRoleAssociationEntity";
            KeyPrefix = "commonDataModel.retailtrialsystemsecurityuserroleassociationentity";
            KeySeparator = ".";
            Grouping = "/RetailTrialSystemSecurityUserRoleAssociationEntity";

            AddGroup("Common Data Model RetailTrialSystemSecurityUserRoleAssociationEntity Details", group =>
            {
                UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityRoleIdentifier = group.Add(new VocabularyKey(nameof(SecurityRoleIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityRoleName = group.Add(new VocabularyKey(nameof(SecurityRoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartitionKey = group.Add(new VocabularyKey(nameof(PartitionKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey UserId { get; private set; }
        public VocabularyKey SecurityRoleIdentifier { get; private set; }
        public VocabularyKey SecurityRoleName { get; private set; }
        public VocabularyKey PartitionKey { get; private set; }


    }
}