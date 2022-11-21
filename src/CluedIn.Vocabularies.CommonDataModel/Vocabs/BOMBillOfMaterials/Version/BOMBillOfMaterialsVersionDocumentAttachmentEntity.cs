using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BOMBillOfMaterialsVersionDocumentAttachmentEntityVocabulary : SimpleVocabulary
    {
        public BOMBillOfMaterialsVersionDocumentAttachmentEntityVocabulary()
        {
            VocabularyName = "BOM Bill Of Materials Version Document Attachment Entity";
            KeyPrefix = "commonDataModel.bombillofmaterialsversiondocumentattachmententity";
            KeySeparator = ".";
            Grouping = "/BOMBillOfMaterialsVersionDocumentAttachmentEntity";

            AddGroup("BOMBillOfMaterialsVersionDocumentAttachmentEntity Details", group =>
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
                BOMVersionManufacturedItemNumber = group.Add(new VocabularyKey(nameof(BOMVersionManufacturedItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMId = group.Add(new VocabularyKey(nameof(BOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMVersionProductionSiteId = group.Add(new VocabularyKey(nameof(BOMVersionProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMVersionProductConfigurationId = group.Add(new VocabularyKey(nameof(BOMVersionProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMVersionProductColorId = group.Add(new VocabularyKey(nameof(BOMVersionProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMVersionProductSizeId = group.Add(new VocabularyKey(nameof(BOMVersionProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMVersionProductStyleId = group.Add(new VocabularyKey(nameof(BOMVersionProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMVersionProductVersionId = group.Add(new VocabularyKey(nameof(BOMVersionProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBOMVersionActive = group.Add(new VocabularyKey(nameof(IsBOMVersionActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMVersionValidFromDate = group.Add(new VocabularyKey(nameof(BOMVersionValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMVersionFromQuantity = group.Add(new VocabularyKey(nameof(BOMVersionFromQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
        public VocabularyKey BOMVersionManufacturedItemNumber { get; private set; }
        public VocabularyKey BOMId { get; private set; }
        public VocabularyKey BOMVersionProductionSiteId { get; private set; }
        public VocabularyKey BOMVersionProductConfigurationId { get; private set; }
        public VocabularyKey BOMVersionProductColorId { get; private set; }
        public VocabularyKey BOMVersionProductSizeId { get; private set; }
        public VocabularyKey BOMVersionProductStyleId { get; private set; }
        public VocabularyKey BOMVersionProductVersionId { get; private set; }
        public VocabularyKey IsBOMVersionActive { get; private set; }
        public VocabularyKey BOMVersionValidFromDate { get; private set; }
        public VocabularyKey BOMVersionFromQuantity { get; private set; }
    }
}