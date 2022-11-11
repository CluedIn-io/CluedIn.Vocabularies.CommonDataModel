using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerFinancialReasonEntityVocabulary : SimpleVocabulary
    {
        public LedgerFinancialReasonEntityVocabulary()
        {
            VocabularyName = "LedgerFinancialReasonEntity";
            KeyPrefix = "commonDataModel.ledgerfinancialreasonentity";
            KeySeparator = ".";
            Grouping = "/LedgerFinancialReasonEntity";

            AddGroup("LedgerFinancialReasonEntity Details", group =>
            {
                ForAssetTransactionType = group.Add(new VocabularyKey(nameof(ForAssetTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForBankTransactionType = group.Add(new VocabularyKey(nameof(ForBankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CancellationReason = group.Add(new VocabularyKey(nameof(CancellationReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurposeCode = group.Add(new VocabularyKey(nameof(PurposeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForCustomerTransactionType = group.Add(new VocabularyKey(nameof(ForCustomerTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultComment = group.Add(new VocabularyKey(nameof(DefaultComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForLedgerTransactionType = group.Add(new VocabularyKey(nameof(ForLedgerTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForRCashTransactionType = group.Add(new VocabularyKey(nameof(ForRCashTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForVendorTransactionType = group.Add(new VocabularyKey(nameof(ForVendorTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForRAssetTransactionType = group.Add(new VocabularyKey(nameof(ForRAssetTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ForAssetTransactionType { get; private set; }
        public VocabularyKey ForBankTransactionType { get; private set; }
        public VocabularyKey CancellationReason { get; private set; }
        public VocabularyKey PurposeCode { get; private set; }
        public VocabularyKey ForCustomerTransactionType { get; private set; }
        public VocabularyKey DefaultComment { get; private set; }
        public VocabularyKey ForLedgerTransactionType { get; private set; }
        public VocabularyKey ForRCashTransactionType { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey ForVendorTransactionType { get; private set; }
        public VocabularyKey ForRAssetTransactionType { get; private set; }


    }
}