using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResDocumentAttachmentEntityVocabulary : SimpleVocabulary
    {
        public EcoResDocumentAttachmentEntityVocabulary()
        {
            VocabularyName = "Eco Res Document Attachment Entity";
            KeyPrefix = "commonDataModel.ecoresdocumentattachmententity";
            KeySeparator = ".";
            Grouping = "/EcoResDocumentAttachmentEntity";

            AddGroup("EcoResDocumentAttachmentEntity Details", group =>
            {
                ParentLegalEntityId = group.Add(new VocabularyKey(nameof(ParentLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentTableId = group.Add(new VocabularyKey(nameof(ParentTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentRecordId = group.Add(new VocabularyKey(nameof(ParentRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttachmentDescription = group.Add(new VocabularyKey(nameof(AttachmentDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(DocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentAttachmentTypeLegalEntityId = group.Add(new VocabularyKey(nameof(DocumentAttachmentTypeLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttachmentType = group.Add(new VocabularyKey(nameof(AttachmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Attachment = group.Add(new VocabularyKey(nameof(Attachment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccessRestriction = group.Add(new VocabularyKey(nameof(AccessRestriction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttachingUserId = group.Add(new VocabularyKey(nameof(AttachingUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttachedDateTime = group.Add(new VocabularyKey(nameof(AttachedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileType = group.Add(new VocabularyKey(nameof(FileType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalFileName = group.Add(new VocabularyKey(nameof(OriginalFileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileLocation = group.Add(new VocabularyKey(nameof(FileLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentStorageProviderType = group.Add(new VocabularyKey(nameof(DocumentStorageProviderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductImage = group.Add(new VocabularyKey(nameof(IsProductImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultProductImage = group.Add(new VocabularyKey(nameof(IsDefaultProductImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductImageUsage = group.Add(new VocabularyKey(nameof(ProductImageUsage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ParentLegalEntityId { get; private set; }
        public VocabularyKey ParentTableId { get; private set; }
        public VocabularyKey ParentRecordId { get; private set; }
        public VocabularyKey AttachmentDescription { get; private set; }
        public VocabularyKey DocumentAttachmentTypeCode { get; private set; }
        public VocabularyKey DocumentAttachmentTypeLegalEntityId { get; private set; }
        public VocabularyKey AttachmentType { get; private set; }
        public VocabularyKey Attachment { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey AccessRestriction { get; private set; }
        public VocabularyKey AttachingUserId { get; private set; }
        public VocabularyKey AttachedDateTime { get; private set; }
        public VocabularyKey FileType { get; private set; }
        public VocabularyKey OriginalFileName { get; private set; }
        public VocabularyKey FileLocation { get; private set; }
        public VocabularyKey DocumentStorageProviderType { get; private set; }
        public VocabularyKey IsProductImage { get; private set; }
        public VocabularyKey IsDefaultProductImage { get; private set; }
        public VocabularyKey ProductImageUsage { get; private set; }
    }
}