using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailReconcilePaymentEntityVocabulary : SimpleVocabulary
    {
        public RetailReconcilePaymentEntityVocabulary()
        {
            VocabularyName = "Retail Reconcile Payment Entity";
            KeyPrefix = "commonDataModel.retailreconcilepaymententity";
            KeySeparator = ".";
            Grouping = "/RetailReconcilePaymentEntity";

            AddGroup("RetailReconcilePaymentEntity Details", group =>
            {
                TransactionId = group.Add(new VocabularyKey(nameof(TransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconcileStatus = group.Add(new VocabularyKey(nameof(ReconcileStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommentUser = group.Add(new VocabularyKey(nameof(CommentUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommentNote = group.Add(new VocabularyKey(nameof(CommentNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommentTime = group.Add(new VocabularyKey(nameof(CommentTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTransLineNumber = group.Add(new VocabularyKey(nameof(PaymentTransLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TransactionId { get; private set; }
        public VocabularyKey ReconcileStatus { get; private set; }
        public VocabularyKey CommentUser { get; private set; }
        public VocabularyKey CommentNote { get; private set; }
        public VocabularyKey CommentTime { get; private set; }
        public VocabularyKey PaymentTransLineNumber { get; private set; }
    }
}