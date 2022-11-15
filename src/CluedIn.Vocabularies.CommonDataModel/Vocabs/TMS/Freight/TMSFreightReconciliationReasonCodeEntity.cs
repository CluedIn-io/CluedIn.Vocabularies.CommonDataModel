using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSFreightReconciliationReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public TMSFreightReconciliationReasonCodeEntityVocabulary()
        {
            VocabularyName = "TMS Freight Reconciliation Reason Code Entity";
            KeyPrefix = "commonDataModel.tmsfreightreconciliationreasoncodeentity";
            KeySeparator = ".";
            Grouping = "/TMSFreightReconciliationReasonCodeEntity";

            AddGroup("TMSFreightReconciliationReasonCodeEntity Details", group =>
            {
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditMainAccountId = group.Add(new VocabularyKey(nameof(CreditMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitLedgerAccount = group.Add(new VocabularyKey(nameof(DebitLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsChargeDebitLedgerAccountOveridden = group.Add(new VocabularyKey(nameof(IsChargeDebitLedgerAccountOveridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsVendorPayingFreight = group.Add(new VocabularyKey(nameof(IsVendorPayingFreight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitLedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(DebitLedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ReasonDescription { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey CreditMainAccountId { get; private set; }
        public VocabularyKey DebitLedgerAccount { get; private set; }
        public VocabularyKey IsChargeDebitLedgerAccountOveridden { get; private set; }
        public VocabularyKey IsVendorPayingFreight { get; private set; }
        public VocabularyKey DebitLedgerAccountDisplayValue { get; private set; }
    }
}