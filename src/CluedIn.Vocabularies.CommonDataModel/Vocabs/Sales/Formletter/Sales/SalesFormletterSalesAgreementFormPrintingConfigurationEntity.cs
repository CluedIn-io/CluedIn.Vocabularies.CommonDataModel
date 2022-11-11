using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesFormletterSalesAgreementFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public SalesFormletterSalesAgreementFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "SalesFormletterSalesAgreementFormPrintingConfigurationEntity";
            KeyPrefix = "commonDataModel.salesformlettersalesagreementformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/SalesFormletterSalesAgreementFormPrintingConfigurationEntity";

            AddGroup("SalesFormletterSalesAgreementFormPrintingConfigurationEntity Details", group =>
            {
                IsProductColorIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductColorIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductConfigurationIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductConfigurationIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductSizeIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductSizeIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductStyleIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductStyleIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductVersionIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductVersionIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShippingSiteIdDisplayed = group.Add(new VocabularyKey(nameof(IsShippingSiteIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShippingWarehouseIdDisplayed = group.Add(new VocabularyKey(nameof(IsShippingWarehouseIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimSalesAgreement = group.Add(new VocabularyKey(nameof(InventDimSalesAgreement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaperFormat = group.Add(new VocabularyKey(nameof(PaperFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentAttachmentDisplayRule = group.Add(new VocabularyKey(nameof(DocumentAttachmentDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayedDocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(DisplayedDocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAgreementClassificationDisplayed = group.Add(new VocabularyKey(nameof(IsAgreementClassificationDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCashDiscountDisplayed = group.Add(new VocabularyKey(nameof(IsCashDiscountDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsContractReferenceDisplayed = group.Add(new VocabularyKey(nameof(IsContractReferenceDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryTermsDisplayed = group.Add(new VocabularyKey(nameof(IsDeliveryTermsDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMaxEnforcedDisplayed = group.Add(new VocabularyKey(nameof(IsMaxEnforcedDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryModeDisplayed = group.Add(new VocabularyKey(nameof(IsDeliveryModeDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPaymentTermsDisplayed = group.Add(new VocabularyKey(nameof(IsPaymentTermsDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsProductColorIdDisplayed { get; private set; }
        public VocabularyKey IsProductConfigurationIdDisplayed { get; private set; }
        public VocabularyKey IsProductSizeIdDisplayed { get; private set; }
        public VocabularyKey IsProductStyleIdDisplayed { get; private set; }
        public VocabularyKey IsProductVersionIdDisplayed { get; private set; }
        public VocabularyKey IsShippingSiteIdDisplayed { get; private set; }
        public VocabularyKey IsShippingWarehouseIdDisplayed { get; private set; }
        public VocabularyKey InventDimSalesAgreement { get; private set; }
        public VocabularyKey PaperFormat { get; private set; }
        public VocabularyKey DocumentAttachmentDisplayRule { get; private set; }
        public VocabularyKey DisplayedDocumentAttachmentTypeCode { get; private set; }
        public VocabularyKey IsAgreementClassificationDisplayed { get; private set; }
        public VocabularyKey IsCashDiscountDisplayed { get; private set; }
        public VocabularyKey IsContractReferenceDisplayed { get; private set; }
        public VocabularyKey IsDeliveryTermsDisplayed { get; private set; }
        public VocabularyKey IsMaxEnforcedDisplayed { get; private set; }
        public VocabularyKey IsDeliveryModeDisplayed { get; private set; }
        public VocabularyKey IsPaymentTermsDisplayed { get; private set; }


    }
}