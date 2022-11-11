using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchaseAgreementLineNoteEntityVocabulary : SimpleVocabulary
    {
        public PurchaseAgreementLineNoteEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchaseAgreementLineNoteEntity";
            KeyPrefix = "commonDataModel.purchaseagreementlinenoteentity";
            KeySeparator = ".";
            Grouping = "/PurchaseAgreementLineNoteEntity";

            AddGroup("Common Data Model PurchaseAgreementLineNoteEntity Details", group =>
            {
                PurchaseAgreementLegalEntityId = group.Add(new VocabularyKey(nameof(PurchaseAgreementLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseAgreementId = group.Add(new VocabularyKey(nameof(PurchaseAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(DocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttachmentDescription = group.Add(new VocabularyKey(nameof(AttachmentDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttachmentType = group.Add(new VocabularyKey(nameof(AttachmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccessRestriction = group.Add(new VocabularyKey(nameof(AccessRestriction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttachingUserId = group.Add(new VocabularyKey(nameof(AttachingUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttachedDateTime = group.Add(new VocabularyKey(nameof(AttachedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PurchaseAgreementLegalEntityId { get; private set; }
        public VocabularyKey PurchaseAgreementId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey DocumentAttachmentTypeCode { get; private set; }
        public VocabularyKey AttachmentDescription { get; private set; }
        public VocabularyKey AttachmentType { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey AccessRestriction { get; private set; }
        public VocabularyKey AttachingUserId { get; private set; }
        public VocabularyKey AttachedDateTime { get; private set; }


    }
}