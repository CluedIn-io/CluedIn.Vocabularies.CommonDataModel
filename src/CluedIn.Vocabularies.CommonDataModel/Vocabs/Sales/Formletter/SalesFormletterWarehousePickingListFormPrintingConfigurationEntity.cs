using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesFormletterWarehousePickingListFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public SalesFormletterWarehousePickingListFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "SalesFormletterWarehousePickingListFormPrintingConfigurationEntity";
            KeyPrefix = "commonDataModel.salesformletterwarehousepickinglistformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/SalesFormletterWarehousePickingListFormPrintingConfigurationEntity";

            AddGroup("SalesFormletterWarehousePickingListFormPrintingConfigurationEntity Details", group =>
            {
                IsInventoryStatusIdDisplayed = group.Add(new VocabularyKey(nameof(IsInventoryStatusIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemBatchNumberDisplayed = group.Add(new VocabularyKey(nameof(IsItemBatchNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemSerialNumberDisplayed = group.Add(new VocabularyKey(nameof(IsItemSerialNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLicensePlateNumberDisplayed = group.Add(new VocabularyKey(nameof(IsLicensePlateNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductColorIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductColorIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductConfigurationIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductConfigurationIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductSizeIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductSizeIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductStyleIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductStyleIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductVersionIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductVersionIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingSiteIdDisplayed = group.Add(new VocabularyKey(nameof(IsPickingSiteIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingWarehouseIdDisplayed = group.Add(new VocabularyKey(nameof(IsPickingWarehouseIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingWarehouseLocationIdDisplayed = group.Add(new VocabularyKey(nameof(IsPickingWarehouseLocationIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimPickingList = group.Add(new VocabularyKey(nameof(InventDimPickingList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentAttachmentDisplayRule = group.Add(new VocabularyKey(nameof(DocumentAttachmentDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayedDocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(DisplayedDocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsInventoryStatusIdDisplayed { get; private set; }
        public VocabularyKey IsItemBatchNumberDisplayed { get; private set; }
        public VocabularyKey IsItemSerialNumberDisplayed { get; private set; }
        public VocabularyKey IsLicensePlateNumberDisplayed { get; private set; }
        public VocabularyKey IsProductColorIdDisplayed { get; private set; }
        public VocabularyKey IsProductConfigurationIdDisplayed { get; private set; }
        public VocabularyKey IsProductSizeIdDisplayed { get; private set; }
        public VocabularyKey IsProductStyleIdDisplayed { get; private set; }
        public VocabularyKey IsProductVersionIdDisplayed { get; private set; }
        public VocabularyKey IsPickingSiteIdDisplayed { get; private set; }
        public VocabularyKey IsPickingWarehouseIdDisplayed { get; private set; }
        public VocabularyKey IsPickingWarehouseLocationIdDisplayed { get; private set; }
        public VocabularyKey InventDimPickingList { get; private set; }
        public VocabularyKey DocumentAttachmentDisplayRule { get; private set; }
        public VocabularyKey DisplayedDocumentAttachmentTypeCode { get; private set; }


    }
}