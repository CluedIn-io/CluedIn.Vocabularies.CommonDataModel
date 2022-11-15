using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmDecisionMakingRoleEntityVocabulary : SimpleVocabulary
    {
        public SmmDecisionMakingRoleEntityVocabulary()
        {
            VocabularyName = "Smm Decision Making Role Entity";
            KeyPrefix = "commonDataModel.smmdecisionmakingroleentity";
            KeySeparator = ".";
            Grouping = "/SmmDecisionMakingRoleEntity";

            AddGroup("SmmDecisionMakingRoleEntity Details", group =>
            {
                RoleName = group.Add(new VocabularyKey(nameof(RoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoleDescription = group.Add(new VocabularyKey(nameof(RoleDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RoleName { get; private set; }
        public VocabularyKey RoleDescription { get; private set; }
    }
}