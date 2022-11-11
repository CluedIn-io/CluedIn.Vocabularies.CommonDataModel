using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetJournalHeaderEntityVocabulary : SimpleVocabulary
    {
        public AssetJournalHeaderEntityVocabulary()
        {
            VocabularyName = "AssetJournalHeaderEntity";
            KeyPrefix = "commonDataModel.assetjournalheaderentity";
            KeySeparator = ".";
            Grouping = "/AssetJournalHeaderEntity";

            AddGroup("AssetJournalHeaderEntity Details", group =>
            {
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNameId = group.Add(new VocabularyKey(nameof(JournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrency = group.Add(new VocabularyKey(nameof(AccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrency = group.Add(new VocabularyKey(nameof(ReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey JournalNameId { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AccountingCurrency { get; private set; }
        public VocabularyKey ReportingCurrency { get; private set; }


    }
}