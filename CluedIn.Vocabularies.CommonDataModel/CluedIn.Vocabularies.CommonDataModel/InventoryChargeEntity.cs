using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventoryChargeEntityVocabulary : SimpleVocabulary
    {
        public InventoryChargeEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventoryChargeEntity";
            KeyPrefix = "commonDataModel.inventorychargeentity";
            KeySeparator = ".";
            Grouping = "/InventoryChargeEntity";

            AddGroup("Common Data Model InventoryChargeEntity Details", group =>
            {
                DebitPostingMainAccountId = group.Add(new VocabularyKey(nameof(DebitPostingMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DebitPostingMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(DebitPostingMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DebitPostingType = group.Add(new VocabularyKey(nameof(DebitPostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DebitPostingMethod = group.Add(new VocabularyKey(nameof(DebitPostingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeCode = group.Add(new VocabularyKey(nameof(ChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeDescription = group.Add(new VocabularyKey(nameof(ChargeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditPostingMainAccountId = group.Add(new VocabularyKey(nameof(CreditPostingMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditPostingMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(CreditPostingMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditPostingType = group.Add(new VocabularyKey(nameof(CreditPostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditPostingMethod = group.Add(new VocabularyKey(nameof(CreditPostingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillIntrastatInvoiceValueIncludeChargeAmounts = group.Add(new VocabularyKey(nameof(WillIntrastatInvoiceValueIncludeChargeAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillIntrastatStatisticalValueIncludeChargeAmounts = group.Add(new VocabularyKey(nameof(WillIntrastatStatisticalValueIncludeChargeAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeClassification = group.Add(new VocabularyKey(nameof(ChargeClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxRateTypeName = group.Add(new VocabularyKey(nameof(TaxRateTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DebitPostingMainAccountId { get; private set; }
public VocabularyKey DebitPostingMainAccountIdDisplayValue { get; private set; }
public VocabularyKey DebitPostingType { get; private set; }
public VocabularyKey DebitPostingMethod { get; private set; }
public VocabularyKey ChargeCode { get; private set; }
public VocabularyKey SalesTaxItemGroupCode { get; private set; }
public VocabularyKey ChargeDescription { get; private set; }
public VocabularyKey CreditPostingMainAccountId { get; private set; }
public VocabularyKey CreditPostingMainAccountIdDisplayValue { get; private set; }
public VocabularyKey CreditPostingType { get; private set; }
public VocabularyKey CreditPostingMethod { get; private set; }
public VocabularyKey WillIntrastatInvoiceValueIncludeChargeAmounts { get; private set; }
public VocabularyKey WillIntrastatStatisticalValueIncludeChargeAmounts { get; private set; }
public VocabularyKey ChargeClassification { get; private set; }
public VocabularyKey TaxRateTypeName { get; private set; }


    }
}