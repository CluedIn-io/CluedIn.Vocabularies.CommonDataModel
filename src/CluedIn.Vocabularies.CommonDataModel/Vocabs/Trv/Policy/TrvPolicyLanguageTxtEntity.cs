using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvPolicyLanguageTxtEntityVocabulary : SimpleVocabulary
    {
        public TrvPolicyLanguageTxtEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvPolicyLanguageTxtEntity";
            KeyPrefix = "commonDataModel.trvpolicylanguagetxtentity";
            KeySeparator = ".";
            Grouping = "/TrvPolicyLanguageTxtEntity";

            AddGroup("Common Data Model TrvPolicyLanguageTxtEntity Details", group =>
            {
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRule_Policy = group.Add(new VocabularyKey(nameof(PolicyRule_Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRule_PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRule_PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRule_ValidFrom = group.Add(new VocabularyKey(nameof(PolicyRule_ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Policy_Name = group.Add(new VocabularyKey(nameof(Policy_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Policy_PolicyType = group.Add(new VocabularyKey(nameof(Policy_PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyTypeRel_PolicyType = group.Add(new VocabularyKey(nameof(PolicyTypeRel_PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType_Name = group.Add(new VocabularyKey(nameof(PolicyRuleType_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType_PolicyType = group.Add(new VocabularyKey(nameof(PolicyRuleType_PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyType_PolicyType = group.Add(new VocabularyKey(nameof(PolicyType_PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Language { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey PolicyRule_Policy { get; private set; }
        public VocabularyKey PolicyRule_PolicyRuleType { get; private set; }
        public VocabularyKey PolicyRule_ValidFrom { get; private set; }
        public VocabularyKey Policy_Name { get; private set; }
        public VocabularyKey Policy_PolicyType { get; private set; }
        public VocabularyKey PolicyTypeRel_PolicyType { get; private set; }
        public VocabularyKey PolicyRuleType_Name { get; private set; }
        public VocabularyKey PolicyRuleType_PolicyType { get; private set; }
        public VocabularyKey PolicyType_PolicyType { get; private set; }


    }
}