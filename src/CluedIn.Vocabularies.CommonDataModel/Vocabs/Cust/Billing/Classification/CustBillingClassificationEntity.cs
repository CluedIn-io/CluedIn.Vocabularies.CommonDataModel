using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustBillingClassificationEntityVocabulary : SimpleVocabulary
    {
        public CustBillingClassificationEntityVocabulary()
        {
            VocabularyName = "Cust Billing Classification Entity";
            KeyPrefix = "commonDataModel.custbillingclassificationentity";
            KeySeparator = ".";
            Grouping = "/CustBillingClassificationEntity";

            AddGroup("CustBillingClassificationEntity Details", group =>
            {
                InvoiceNumber = group.Add(new VocabularyKey(nameof(InvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingClassification = group.Add(new VocabularyKey(nameof(BillingClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionLetterSequence = group.Add(new VocabularyKey(nameof(CollectionLetterSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditNoteNumber = group.Add(new VocabularyKey(nameof(CreditNoteNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustInterestCode = group.Add(new VocabularyKey(nameof(CustInterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RestrictSettlementOfCreditNotes = group.Add(new VocabularyKey(nameof(RestrictSettlementOfCreditNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseCollectionLetterSequenceFromPostingProfile = group.Add(new VocabularyKey(nameof(UseCollectionLetterSequenceFromPostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseInterestCodeFromPostingProfile = group.Add(new VocabularyKey(nameof(UseInterestCodeFromPostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestCode = group.Add(new VocabularyKey(nameof(InterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey InvoiceNumber { get; private set; }
        public VocabularyKey BillingClassification { get; private set; }
        public VocabularyKey CollectionLetterSequence { get; private set; }
        public VocabularyKey CreditNoteNumber { get; private set; }
        public VocabularyKey CustInterestCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey RestrictSettlementOfCreditNotes { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey UseCollectionLetterSequenceFromPostingProfile { get; private set; }
        public VocabularyKey UseInterestCodeFromPostingProfile { get; private set; }
        public VocabularyKey InterestCode { get; private set; }
    }
}