using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManCreditLimitRuleEntityVocabulary : SimpleVocabulary
    {
        public CredManCreditLimitRuleEntityVocabulary()
        {
            VocabularyName = "CredManCreditLimitRuleEntity";
            KeyPrefix = "commonDataModel.credmancreditlimitruleentity";
            KeySeparator = ".";
            Grouping = "/CredManCreditLimitRuleEntity";

            AddGroup("CredManCreditLimitRuleEntity Details", group =>
            {
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RiskGroupId = group.Add(new VocabularyKey(nameof(RiskGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey RiskGroupId { get; private set; }


    }
}