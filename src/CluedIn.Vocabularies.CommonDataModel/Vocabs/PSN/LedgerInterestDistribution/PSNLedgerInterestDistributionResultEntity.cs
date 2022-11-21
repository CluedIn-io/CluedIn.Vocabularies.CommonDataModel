using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSNLedgerInterestDistributionResultEntityVocabulary : SimpleVocabulary
    {
        public PSNLedgerInterestDistributionResultEntityVocabulary()
        {
            VocabularyName = "PSN Ledger Interest Distribution Result Entity";
            KeyPrefix = "commonDataModel.psnledgerinterestdistributionresultentity";
            KeySeparator = ".";
            Grouping = "/PSNLedgerInterestDistributionResultEntity";

            AddGroup("PSNLedgerInterestDistributionResultEntity Details", group =>
            {
                RuleId = group.Add(new VocabularyKey(nameof(RuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AverageDailyBalance = group.Add(new VocabularyKey(nameof(AverageDailyBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PercentOfTotal = group.Add(new VocabularyKey(nameof(PercentOfTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocatedInterest = group.Add(new VocabularyKey(nameof(AllocatedInterest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestDistributionRules = group.Add(new VocabularyKey(nameof(InterestDistributionRules), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RuleId { get; private set; }
        public VocabularyKey AverageDailyBalance { get; private set; }
        public VocabularyKey PercentOfTotal { get; private set; }
        public VocabularyKey AllocatedInterest { get; private set; }
        public VocabularyKey InterestDistributionRules { get; private set; }
    }
}