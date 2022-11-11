using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerLiquidityDependencyEntityVocabulary : SimpleVocabulary
    {
        public LedgerLiquidityDependencyEntityVocabulary()
        {
            VocabularyName = "LedgerLiquidityDependencyEntity";
            KeyPrefix = "commonDataModel.ledgerliquiditydependencyentity";
            KeySeparator = ".";
            Grouping = "/LedgerLiquidityDependencyEntity";

            AddGroup("LedgerLiquidityDependencyEntity Details", group =>
            {
                ChartOfAccountsName = group.Add(new VocabularyKey(nameof(ChartOfAccountsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromMainAccountId = group.Add(new VocabularyKey(nameof(FromMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToMainAccountId = group.Add(new VocabularyKey(nameof(ToMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingType = group.Add(new VocabularyKey(nameof(PostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionOrBudget = group.Add(new VocabularyKey(nameof(TransactionOrBudget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percent = group.Add(new VocabularyKey(nameof(Percent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ChartOfAccountsName { get; private set; }
        public VocabularyKey FromMainAccountId { get; private set; }
        public VocabularyKey ToMainAccountId { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey PostingType { get; private set; }
        public VocabularyKey TransactionOrBudget { get; private set; }
        public VocabularyKey Percent { get; private set; }


    }
}