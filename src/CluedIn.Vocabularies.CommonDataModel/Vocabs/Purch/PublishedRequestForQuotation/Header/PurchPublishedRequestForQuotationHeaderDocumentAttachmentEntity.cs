using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPublishedRequestForQuotationHeaderDocumentAttachmentEntityVocabulary : SimpleVocabulary
    {
        public PurchPublishedRequestForQuotationHeaderDocumentAttachmentEntityVocabulary()
        {
            VocabularyName = "Purch Published Request For Quotation Header Document Attachment Entity";
            KeyPrefix = "commonDataModel.purchpublishedrequestforquotationheaderdocumentattachmententity";
            KeySeparator = ".";
            Grouping = "/PurchPublishedRequestForQuotationHeaderDocumentAttachmentEntity";

            AddGroup("PurchPublishedRequestForQuotationHeaderDocumentAttachmentEntity Details", group =>
            {
                DocumentId = group.Add(new VocabularyKey(nameof(DocumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(DocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttachmentDescription = group.Add(new VocabularyKey(nameof(AttachmentDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccessRestriction = group.Add(new VocabularyKey(nameof(AccessRestriction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Attachment = group.Add(new VocabularyKey(nameof(Attachment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileName = group.Add(new VocabularyKey(nameof(FileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileType = group.Add(new VocabularyKey(nameof(FileType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualCompanyId = group.Add(new VocabularyKey(nameof(ActualCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultAttachment = group.Add(new VocabularyKey(nameof(IsDefaultAttachment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublishedRFQCaseNumber = group.Add(new VocabularyKey(nameof(PublishedRFQCaseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DocumentId { get; private set; }
        public VocabularyKey DocumentAttachmentTypeCode { get; private set; }
        public VocabularyKey AttachmentDescription { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey AccessRestriction { get; private set; }
        public VocabularyKey Attachment { get; private set; }
        public VocabularyKey FileName { get; private set; }
        public VocabularyKey FileType { get; private set; }
        public VocabularyKey ActualCompanyId { get; private set; }
        public VocabularyKey IsDefaultAttachment { get; private set; }
        public VocabularyKey PublishedRFQCaseNumber { get; private set; }
    }
}