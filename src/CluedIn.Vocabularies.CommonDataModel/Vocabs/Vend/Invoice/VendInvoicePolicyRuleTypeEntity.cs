using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendInvoicePolicyRuleTypeEntityVocabulary : SimpleVocabulary
    {
        public VendInvoicePolicyRuleTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendInvoicePolicyRuleTypeEntity";
            KeyPrefix = "commonDataModel.vendinvoicepolicyruletypeentity";
            KeySeparator = ".";
            Grouping = "/VendInvoicePolicyRuleTypeEntity";

            AddGroup("Common Data Model VendInvoicePolicyRuleTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleName = group.Add(new VocabularyKey(nameof(RuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueryName = group.Add(new VocabularyKey(nameof(QueryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrecedenceSupported = group.Add(new VocabularyKey(nameof(IsPrecedenceSupported), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludeParentRules = group.Add(new VocabularyKey(nameof(IncludeParentRules), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey RuleName { get; private set; }
        public VocabularyKey QueryName { get; private set; }
        public VocabularyKey PolicyType { get; private set; }
        public VocabularyKey IsPrecedenceSupported { get; private set; }
        public VocabularyKey IncludeParentRules { get; private set; }


    }
}