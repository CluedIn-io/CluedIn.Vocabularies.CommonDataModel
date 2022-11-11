using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManPaymTermRankEntityVocabulary : SimpleVocabulary
    {
        public CredManPaymTermRankEntityVocabulary()
        {
            VocabularyName = "Common Data Model CredManPaymTermRankEntity";
            KeyPrefix = "commonDataModel.credmanpaymtermrankentity";
            KeySeparator = ".";
            Grouping = "/CredManPaymTermRankEntity";

            AddGroup("Common Data Model CredManPaymTermRankEntity Details", group =>
            {
                PaymentTerms = group.Add(new VocabularyKey(nameof(PaymentTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsRanking = group.Add(new VocabularyKey(nameof(PaymentTermsRanking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PaymentTerms { get; private set; }
        public VocabularyKey PaymentTermsRanking { get; private set; }


    }
}