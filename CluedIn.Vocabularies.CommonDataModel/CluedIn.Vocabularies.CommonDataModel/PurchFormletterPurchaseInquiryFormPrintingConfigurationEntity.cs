using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchFormletterPurchaseInquiryFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public PurchFormletterPurchaseInquiryFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchFormletterPurchaseInquiryFormPrintingConfigurationEntity";
            KeyPrefix = "commonDataModel.purchformletterpurchaseinquiryformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/PurchFormletterPurchaseInquiryFormPrintingConfigurationEntity";

            AddGroup("Common Data Model PurchFormletterPurchaseInquiryFormPrintingConfigurationEntity Details", group =>
            {
                IsInventoryStatusIdDisplayed = group.Add(new VocabularyKey(nameof(IsInventoryStatusIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsItemBatchNumberDisplayed = group.Add(new VocabularyKey(nameof(IsItemBatchNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsItemSerialNumberDisplayed = group.Add(new VocabularyKey(nameof(IsItemSerialNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLicensePlateNumberDisplayed = group.Add(new VocabularyKey(nameof(IsLicensePlateNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductColorIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductColorIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductVersionIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductVersionIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductConfigurationIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductConfigurationIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductSizeIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductSizeIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductStyleIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductStyleIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReceivingSiteIdDisplayed = group.Add(new VocabularyKey(nameof(IsReceivingSiteIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReceivingWarehouseIdDisplayed = group.Add(new VocabularyKey(nameof(IsReceivingWarehouseIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReceivingWarehouseLocationIdDisplayed = group.Add(new VocabularyKey(nameof(IsReceivingWarehouseLocationIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventDimPurchOrderConfirmationRequest = group.Add(new VocabularyKey(nameof(InventDimPurchOrderConfirmationRequest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaperFormat = group.Add(new VocabularyKey(nameof(PaperFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreUpdatedPurchaseInquiryLinesMarked = group.Add(new VocabularyKey(nameof(AreUpdatedPurchaseInquiryLinesMarked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentAttachmentDisplayRule = group.Add(new VocabularyKey(nameof(DocumentAttachmentDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisplayedDocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(DisplayedDocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsInventoryStatusIdDisplayed { get; private set; }
public VocabularyKey IsItemBatchNumberDisplayed { get; private set; }
public VocabularyKey IsItemSerialNumberDisplayed { get; private set; }
public VocabularyKey IsLicensePlateNumberDisplayed { get; private set; }
public VocabularyKey IsProductColorIdDisplayed { get; private set; }
public VocabularyKey IsProductVersionIdDisplayed { get; private set; }
public VocabularyKey IsProductConfigurationIdDisplayed { get; private set; }
public VocabularyKey IsProductSizeIdDisplayed { get; private set; }
public VocabularyKey IsProductStyleIdDisplayed { get; private set; }
public VocabularyKey IsReceivingSiteIdDisplayed { get; private set; }
public VocabularyKey IsReceivingWarehouseIdDisplayed { get; private set; }
public VocabularyKey IsReceivingWarehouseLocationIdDisplayed { get; private set; }
public VocabularyKey InventDimPurchOrderConfirmationRequest { get; private set; }
public VocabularyKey PaperFormat { get; private set; }
public VocabularyKey AreUpdatedPurchaseInquiryLinesMarked { get; private set; }
public VocabularyKey DocumentAttachmentDisplayRule { get; private set; }
public VocabularyKey DisplayedDocumentAttachmentTypeCode { get; private set; }


    }
}