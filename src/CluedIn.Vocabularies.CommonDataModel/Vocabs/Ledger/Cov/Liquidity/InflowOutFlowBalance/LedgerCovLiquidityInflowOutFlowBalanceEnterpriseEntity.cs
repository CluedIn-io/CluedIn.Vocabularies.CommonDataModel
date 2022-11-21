using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerCovLiquidityInflowOutFlowBalanceEnterpriseEntityVocabulary : SimpleVocabulary
    {
        public LedgerCovLiquidityInflowOutFlowBalanceEnterpriseEntityVocabulary()
        {
            VocabularyName = "Ledger Cov Liquidity Inflow Out Flow Balance Enterprise Entity";
            KeyPrefix = "commonDataModel.ledgercovliquidityinflowoutflowbalanceenterpriseentity";
            KeySeparator = ".";
            Grouping = "/LedgerCovLiquidityInflowOutFlowBalanceEnterpriseEntity";

            AddGroup("LedgerCovLiquidityInflowOutFlowBalanceEnterpriseEntity Details", group =>
            {
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InflowAmount = group.Add(new VocabularyKey(nameof(InflowAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutflowAmount = group.Add(new VocabularyKey(nameof(OutflowAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceAmount = group.Add(new VocabularyKey(nameof(BalanceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey InflowAmount { get; private set; }
        public VocabularyKey OutflowAmount { get; private set; }
        public VocabularyKey BalanceAmount { get; private set; }
        public VocabularyKey BankAccount { get; private set; }
    }
}