using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PmfFormulaVersionDocumentAttachmentEntityVocabulary : SimpleVocabulary
    {
        public PmfFormulaVersionDocumentAttachmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model PmfFormulaVersionDocumentAttachmentEntity";
            KeyPrefix = "commonDataModel.pmfformulaversiondocumentattachmententity";
            KeySeparator = ".";
            Grouping = "/PmfFormulaVersionDocumentAttachmentEntity";

            AddGroup("Common Data Model PmfFormulaVersionDocumentAttachmentEntity Details", group =>
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
                FormulaVersionManufacturedItemNumber = group.Add(new VocabularyKey(nameof(FormulaVersionManufacturedItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaId = group.Add(new VocabularyKey(nameof(FormulaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaVersionProductionSiteId = group.Add(new VocabularyKey(nameof(FormulaVersionProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaVersionProductConfigurationId = group.Add(new VocabularyKey(nameof(FormulaVersionProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaVersionProductColorId = group.Add(new VocabularyKey(nameof(FormulaVersionProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaVersionProductSizeId = group.Add(new VocabularyKey(nameof(FormulaVersionProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaVersionProductStyleId = group.Add(new VocabularyKey(nameof(FormulaVersionProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaVersionProductVersionId = group.Add(new VocabularyKey(nameof(FormulaVersionProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFormulaVersionActive = group.Add(new VocabularyKey(nameof(IsFormulaVersionActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaVersionValidFromDate = group.Add(new VocabularyKey(nameof(FormulaVersionValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaVersionFromQuantity = group.Add(new VocabularyKey(nameof(FormulaVersionFromQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

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
        public VocabularyKey FormulaVersionManufacturedItemNumber { get; private set; }
        public VocabularyKey FormulaId { get; private set; }
        public VocabularyKey FormulaVersionProductionSiteId { get; private set; }
        public VocabularyKey FormulaVersionProductConfigurationId { get; private set; }
        public VocabularyKey FormulaVersionProductColorId { get; private set; }
        public VocabularyKey FormulaVersionProductSizeId { get; private set; }
        public VocabularyKey FormulaVersionProductStyleId { get; private set; }
        public VocabularyKey FormulaVersionProductVersionId { get; private set; }
        public VocabularyKey IsFormulaVersionActive { get; private set; }
        public VocabularyKey FormulaVersionValidFromDate { get; private set; }
        public VocabularyKey FormulaVersionFromQuantity { get; private set; }


    }
}