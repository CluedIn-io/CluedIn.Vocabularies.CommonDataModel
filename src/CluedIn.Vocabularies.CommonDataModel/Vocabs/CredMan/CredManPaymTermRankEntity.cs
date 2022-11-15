using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManPaymTermRankEntityVocabulary : SimpleVocabulary
    {
        public CredManPaymTermRankEntityVocabulary()
        {
            VocabularyName = "Cred Man Paym Term Rank Entity";
            KeyPrefix = "commonDataModel.credmanpaymtermrankentity";
            KeySeparator = ".";
            Grouping = "/CredManPaymTermRankEntity";

            AddGroup("CredManPaymTermRankEntity Details", group =>
            {
                PaymentTerms = group.Add(new VocabularyKey(nameof(PaymentTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsRanking = group.Add(new VocabularyKey(nameof(PaymentTermsRanking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PaymentTerms { get; private set; }
        public VocabularyKey PaymentTermsRanking { get; private set; }
    }
}