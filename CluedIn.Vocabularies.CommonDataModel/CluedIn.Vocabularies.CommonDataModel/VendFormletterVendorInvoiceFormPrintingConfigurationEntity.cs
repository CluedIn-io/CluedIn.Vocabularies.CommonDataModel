using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendFormletterVendorInvoiceFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public VendFormletterVendorInvoiceFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendFormletterVendorInvoiceFormPrintingConfigurationEntity";
            KeyPrefix = "commonDataModel.vendformlettervendorinvoiceformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/VendFormletterVendorInvoiceFormPrintingConfigurationEntity";

            AddGroup("Common Data Model VendFormletterVendorInvoiceFormPrintingConfigurationEntity Details", group =>
            {
                IsTaxExemptNumberDisplayed = group.Add(new VocabularyKey(nameof(IsTaxExemptNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInventoryStatusIdDisplayed = group.Add(new VocabularyKey(nameof(IsInventoryStatusIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsItemBatchNumberDisplayed = group.Add(new VocabularyKey(nameof(IsItemBatchNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsItemSerialNumberDisplayed = group.Add(new VocabularyKey(nameof(IsItemSerialNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLicensePlateNumberDisplayed = group.Add(new VocabularyKey(nameof(IsLicensePlateNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductColorIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductColorIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductConfigurationIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductConfigurationIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductSizeIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductSizeIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductStyleIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductStyleIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductVersionIdDisplayed = group.Add(new VocabularyKey(nameof(IsProductVersionIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReceivingSiteIdDisplayed = group.Add(new VocabularyKey(nameof(IsReceivingSiteIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReceivingWarehouseIdDisplayed = group.Add(new VocabularyKey(nameof(IsReceivingWarehouseIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReceivingWarehouseLocationIdDisplayed = group.Add(new VocabularyKey(nameof(IsReceivingWarehouseLocationIdDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventDimInvoice = group.Add(new VocabularyKey(nameof(InventDimInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsTaxExemptNumberDisplayed { get; private set; }
public VocabularyKey IsInventoryStatusIdDisplayed { get; private set; }
public VocabularyKey IsItemBatchNumberDisplayed { get; private set; }
public VocabularyKey IsItemSerialNumberDisplayed { get; private set; }
public VocabularyKey IsLicensePlateNumberDisplayed { get; private set; }
public VocabularyKey IsProductColorIdDisplayed { get; private set; }
public VocabularyKey IsProductConfigurationIdDisplayed { get; private set; }
public VocabularyKey IsProductSizeIdDisplayed { get; private set; }
public VocabularyKey IsProductStyleIdDisplayed { get; private set; }
public VocabularyKey IsProductVersionIdDisplayed { get; private set; }
public VocabularyKey IsReceivingSiteIdDisplayed { get; private set; }
public VocabularyKey IsReceivingWarehouseIdDisplayed { get; private set; }
public VocabularyKey IsReceivingWarehouseLocationIdDisplayed { get; private set; }
public VocabularyKey InventDimInvoice { get; private set; }


    }
}