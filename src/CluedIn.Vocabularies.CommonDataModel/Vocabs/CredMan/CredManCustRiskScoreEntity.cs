using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManCustRiskScoreEntityVocabulary : SimpleVocabulary
    {
        public CredManCustRiskScoreEntityVocabulary()
        {
            VocabularyName = "Cred Man Cust Risk Score Entity";
            KeyPrefix = "commonDataModel.credmancustriskscoreentity";
            KeySeparator = ".";
            Grouping = "/CredManCustRiskScoreEntity";

            AddGroup("CredManCustRiskScoreEntity Details", group =>
            {
                CustAccount = group.Add(new VocabularyKey(nameof(CustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RiskScoreGroupId = group.Add(new VocabularyKey(nameof(RiskScoreGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustAccount { get; private set; }
        public VocabularyKey RiskScoreGroupId { get; private set; }
        public VocabularyKey Value { get; private set; }
    }
}