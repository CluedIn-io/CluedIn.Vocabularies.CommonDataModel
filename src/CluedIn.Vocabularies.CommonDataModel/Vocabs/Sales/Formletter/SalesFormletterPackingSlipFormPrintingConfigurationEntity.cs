using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesFormletterPackingSlipFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public SalesFormletterPackingSlipFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesFormletterPackingSlipFormPrintingConfigurationEntity";
            KeyPrefix = "commonDataModel.salesformletterpackingslipformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/SalesFormletterPackingSlipFormPrintingConfigurationEntity";

            AddGroup("Common Data Model SalesFormletterPackingSlipFormPrintingConfigurationEntity Details", group =>
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
                IsShippingSiteIdDisplayed = group.Add(new VocabularyKey(nameof(IsShippingSiteIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShippingWarehouseIdDisplayed = group.Add(new VocabularyKey(nameof(IsShippingWarehouseIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShippingWarehouseLocationIdDisplayed = group.Add(new VocabularyKey(nameof(IsShippingWarehouseLocationIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimPackingSlip = group.Add(new VocabularyKey(nameof(InventDimPackingSlip), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaperFormat = group.Add(new VocabularyKey(nameof(PaperFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentAttachmentDisplayRule = group.Add(new VocabularyKey(nameof(DocumentAttachmentDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayedDocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(DisplayedDocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreShippingDetailsDisplayed = group.Add(new VocabularyKey(nameof(AreShippingDetailsDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFirstShippingLineDisplayedOnly = group.Add(new VocabularyKey(nameof(IsFirstShippingLineDisplayedOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDisplayedPackingSlipArchived = group.Add(new VocabularyKey(nameof(IsDisplayedPackingSlipArchived), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BackorderTrackingDisplayRule = group.Add(new VocabularyKey(nameof(BackorderTrackingDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

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
        public VocabularyKey IsShippingSiteIdDisplayed { get; private set; }
        public VocabularyKey IsShippingWarehouseIdDisplayed { get; private set; }
        public VocabularyKey IsShippingWarehouseLocationIdDisplayed { get; private set; }
        public VocabularyKey InventDimPackingSlip { get; private set; }
        public VocabularyKey PaperFormat { get; private set; }
        public VocabularyKey DocumentAttachmentDisplayRule { get; private set; }
        public VocabularyKey DisplayedDocumentAttachmentTypeCode { get; private set; }
        public VocabularyKey AreShippingDetailsDisplayed { get; private set; }
        public VocabularyKey IsFirstShippingLineDisplayedOnly { get; private set; }
        public VocabularyKey IsDisplayedPackingSlipArchived { get; private set; }
        public VocabularyKey BackorderTrackingDisplayRule { get; private set; }


    }
}