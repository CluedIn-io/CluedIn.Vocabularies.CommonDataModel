using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSNTreasurerFundReportMainAccountsEntityVocabulary : SimpleVocabulary
    {
        public PSNTreasurerFundReportMainAccountsEntityVocabulary()
        {
            VocabularyName = "PSN Treasurer Fund Report Main Accounts Entity";
            KeyPrefix = "commonDataModel.psntreasurerfundreportmainaccountsentity";
            KeySeparator = ".";
            Grouping = "/PSNTreasurerFundReportMainAccountsEntity";

            AddGroup("PSNTreasurerFundReportMainAccountsEntity Details", group =>
            {
                MainAccountRecId = group.Add(new VocabularyKey(nameof(MainAccountRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerChartOfAccountsRecId = group.Add(new VocabularyKey(nameof(LedgerChartOfAccountsRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerChartOfAccountsName = group.Add(new VocabularyKey(nameof(LedgerChartOfAccountsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MainAccountRecId { get; private set; }
        public VocabularyKey LedgerChartOfAccountsRecId { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey LedgerChartOfAccountsName { get; private set; }
    }
}