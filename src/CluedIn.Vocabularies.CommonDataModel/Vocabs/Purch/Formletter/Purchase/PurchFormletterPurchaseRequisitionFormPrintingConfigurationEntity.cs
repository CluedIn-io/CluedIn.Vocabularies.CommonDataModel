using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchFormletterPurchaseRequisitionFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public PurchFormletterPurchaseRequisitionFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "Purch Formletter Purchase Requisition Form Printing Configuration Entity";
            KeyPrefix = "commonDataModel.purchformletterpurchaserequisitionformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/PurchFormletterPurchaseRequisitionFormPrintingConfigurationEntity";

            AddGroup("PurchFormletterPurchaseRequisitionFormPrintingConfigurationEntity Details", group =>
            {
                IsProductColorIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductColorIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductConfigurationIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductConfigurationIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductSizeIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductSizeIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductStyleIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductStyleIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductVersionIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductVersionIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReceivingSiteIdDisplayed = group.Add(new VocabularyKey(nameof(IsReceivingSiteIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReceivingWarehouseIdDisplayed = group.Add(new VocabularyKey(nameof(IsReceivingWarehouseIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimPurchReq = group.Add(new VocabularyKey(nameof(InventDimPurchReq), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentAttachmentDisplayRule = group.Add(new VocabularyKey(nameof(DocumentAttachmentDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayedDocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(DisplayedDocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsProductColorIdDisplayed { get; private set; }
        public VocabularyKey IsProductConfigurationIdDisplayed { get; private set; }
        public VocabularyKey IsProductSizeIdDisplayed { get; private set; }
        public VocabularyKey IsProductStyleIdDisplayed { get; private set; }
        public VocabularyKey IsProductVersionIdDisplayed { get; private set; }
        public VocabularyKey IsReceivingSiteIdDisplayed { get; private set; }
        public VocabularyKey IsReceivingWarehouseIdDisplayed { get; private set; }
        public VocabularyKey InventDimPurchReq { get; private set; }
        public VocabularyKey DocumentAttachmentDisplayRule { get; private set; }
        public VocabularyKey DisplayedDocumentAttachmentTypeCode { get; private set; }
    }
}