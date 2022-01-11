using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustFormletterCustomerFreeTextInvoiceFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public CustFormletterCustomerFreeTextInvoiceFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustFormletterCustomerFreeTextInvoiceFormPrintingConfigurationEntity";
            KeyPrefix = "commonDataModel.custformlettercustomerfreetextinvoiceformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/CustFormletterCustomerFreeTextInvoiceFormPrintingConfigurationEntity";

            AddGroup("Common Data Model CustFormletterCustomerFreeTextInvoiceFormPrintingConfigurationEntity Details", group =>
            {
                PaperFormat = group.Add(new VocabularyKey(nameof(PaperFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentAttachmentDisplayRule = group.Add(new VocabularyKey(nameof(DocumentAttachmentDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisplayedDocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(DisplayedDocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsTaxExemptNumberDisplayed = group.Add(new VocabularyKey(nameof(IsTaxExemptNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditNoteLineDisplayRule = group.Add(new VocabularyKey(nameof(CreditNoteLineDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisplayedPaymentAttachmentType = group.Add(new VocabularyKey(nameof(DisplayedPaymentAttachmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LumpSumRecoveryText = group.Add(new VocabularyKey(nameof(LumpSumRecoveryText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LumpSumRecoveryGracePeriodDays = group.Add(new VocabularyKey(nameof(LumpSumRecoveryGracePeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PaperFormat { get; private set; }
public VocabularyKey DocumentAttachmentDisplayRule { get; private set; }
public VocabularyKey DisplayedDocumentAttachmentTypeCode { get; private set; }
public VocabularyKey IsTaxExemptNumberDisplayed { get; private set; }
public VocabularyKey CreditNoteLineDisplayRule { get; private set; }
public VocabularyKey DisplayedPaymentAttachmentType { get; private set; }
public VocabularyKey LumpSumRecoveryText { get; private set; }
public VocabularyKey LumpSumRecoveryGracePeriodDays { get; private set; }


    }
}