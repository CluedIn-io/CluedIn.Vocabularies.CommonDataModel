using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CAMImportedGeneralLedgerEntryEntityVocabulary : SimpleVocabulary
    {
        public CAMImportedGeneralLedgerEntryEntityVocabulary()
        {
            VocabularyName = "CAMImportedGeneralLedgerEntryEntity";
            KeyPrefix = "commonDataModel.camimportedgeneralledgerentryentity";
            KeySeparator = ".";
            Grouping = "/CAMImportedGeneralLedgerEntryEntity";

            AddGroup("CAMImportedGeneralLedgerEntryEntity Details", group =>
            {
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionMemberNames = group.Add(new VocabularyKey(nameof(DimensionMemberNames), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountName = group.Add(new VocabularyKey(nameof(MainAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitCredit = group.Add(new VocabularyKey(nameof(DebitCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceIdentifier = group.Add(new VocabularyKey(nameof(SourceIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey DimensionMemberNames { get; private set; }
        public VocabularyKey MainAccountName { get; private set; }
        public VocabularyKey DebitCredit { get; private set; }
        public VocabularyKey SourceIdentifier { get; private set; }


    }
}