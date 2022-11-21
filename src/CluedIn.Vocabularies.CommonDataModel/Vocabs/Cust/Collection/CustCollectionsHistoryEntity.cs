using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsHistoryEntityVocabulary : SimpleVocabulary
    {
        public CustCollectionsHistoryEntityVocabulary()
        {
            VocabularyName = "Cust Collections History Entity";
            KeyPrefix = "commonDataModel.custcollectionshistoryentity";
            KeySeparator = ".";
            Grouping = "/CustCollectionsHistoryEntity";

            AddGroup("CustCollectionsHistoryEntity Details", group =>
            {
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountCur = group.Add(new VocabularyKey(nameof(AmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustTrans = group.Add(new VocabularyKey(nameof(CustTrans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusChangedDate = group.Add(new VocabularyKey(nameof(StatusChangedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrency = group.Add(new VocabularyKey(nameof(TransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionBalance = group.Add(new VocabularyKey(nameof(TransactionBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FollowUpDate = group.Add(new VocabularyKey(nameof(FollowUpDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reason = group.Add(new VocabularyKey(nameof(Reason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonComment = group.Add(new VocabularyKey(nameof(ReasonComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustDisputeHistoryCreatedDateTime = group.Add(new VocabularyKey(nameof(CustDisputeHistoryCreatedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey AmountCur { get; private set; }
        public VocabularyKey CustTrans { get; private set; }
        public VocabularyKey Note { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StatusChangedDate { get; private set; }
        public VocabularyKey TransactionCurrency { get; private set; }
        public VocabularyKey TransactionBalance { get; private set; }
        public VocabularyKey FollowUpDate { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey Reason { get; private set; }
        public VocabularyKey ReasonComment { get; private set; }
        public VocabularyKey CustDisputeHistoryCreatedDateTime { get; private set; }
    }
}