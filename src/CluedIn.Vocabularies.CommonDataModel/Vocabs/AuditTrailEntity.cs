using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AuditTrailEntityVocabulary : SimpleVocabulary
    {
        public AuditTrailEntityVocabulary()
        {
            VocabularyName = "AuditTrailEntity";
            KeyPrefix = "commonDataModel.audittrailentity";
            KeySeparator = ".";
            Grouping = "/AuditTrailEntity";

            AddGroup("AuditTrailEntity Details", group =>
            {
                TransactionId = group.Add(new VocabularyKey(nameof(TransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedByUser = group.Add(new VocabularyKey(nameof(CreatedByUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedTransactionDateTime = group.Add(new VocabularyKey(nameof(CreatedTransactionDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TransactionId { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey CreatedByUser { get; private set; }
        public VocabularyKey CreatedTransactionDateTime { get; private set; }


    }
}