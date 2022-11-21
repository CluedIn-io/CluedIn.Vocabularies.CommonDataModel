using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxReportLedgerAccountsEntityVocabulary : SimpleVocabulary
    {
        public TaxReportLedgerAccountsEntityVocabulary()
        {
            VocabularyName = "Tax Report Ledger Accounts Entity";
            KeyPrefix = "commonDataModel.taxreportledgeraccountsentity";
            KeySeparator = ".";
            Grouping = "/TaxReportLedgerAccountsEntity";

            AddGroup("TaxReportLedgerAccountsEntity Details", group =>
            {
                LedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(LedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccount = group.Add(new VocabularyKey(nameof(LedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LedgerAccountDisplayValue { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey LedgerAccount { get; private set; }
    }
}