using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmDecisionMakingRoleEntityVocabulary : SimpleVocabulary
    {
        public smmDecisionMakingRoleEntityVocabulary()
        {
            VocabularyName = "smmDecisionMakingRoleEntity";
            KeyPrefix = "commonDataModel.smmdecisionmakingroleentity";
            KeySeparator = ".";
            Grouping = "/smmDecisionMakingRoleEntity";

            AddGroup("smmDecisionMakingRoleEntity Details", group =>
            {
                RoleName = group.Add(new VocabularyKey(nameof(RoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoleDescription = group.Add(new VocabularyKey(nameof(RoleDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RoleName { get; private set; }
        public VocabularyKey RoleDescription { get; private set; }


    }
}