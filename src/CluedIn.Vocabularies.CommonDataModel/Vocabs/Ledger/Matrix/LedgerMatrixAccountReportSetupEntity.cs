using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerMatrixAccountReportSetupEntityVocabulary : SimpleVocabulary
    {
        public LedgerMatrixAccountReportSetupEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerMatrixAccountReportSetupEntity";
            KeyPrefix = "commonDataModel.ledgermatrixaccountreportsetupentity";
            KeySeparator = ".";
            Grouping = "/LedgerMatrixAccountReportSetupEntity";

            AddGroup("Common Data Model LedgerMatrixAccountReportSetupEntity Details", group =>
            {
                AccountMatrix = group.Add(new VocabularyKey(nameof(AccountMatrix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Format = group.Add(new VocabularyKey(nameof(Format), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubLevelMainAccount = group.Add(new VocabularyKey(nameof(SubLevelMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubLevelMainAccountId = group.Add(new VocabularyKey(nameof(SubLevelMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountMatrix { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Format { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey SubLevelMainAccount { get; private set; }
        public VocabularyKey SubLevelMainAccountId { get; private set; }


    }
}