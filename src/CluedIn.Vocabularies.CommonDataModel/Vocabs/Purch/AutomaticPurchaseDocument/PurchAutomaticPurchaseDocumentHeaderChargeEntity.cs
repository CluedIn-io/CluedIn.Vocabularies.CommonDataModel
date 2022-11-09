using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchAutomaticPurchaseDocumentHeaderChargeEntityVocabulary : SimpleVocabulary
    {
        public PurchAutomaticPurchaseDocumentHeaderChargeEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchAutomaticPurchaseDocumentHeaderChargeEntity";
            KeyPrefix = "commonDataModel.purchautomaticpurchasedocumentheaderchargeentity";
            KeySeparator = ".";
            Grouping = "/PurchAutomaticPurchaseDocumentHeaderChargeEntity";

            AddGroup("Common Data Model PurchAutomaticPurchaseDocumentHeaderChargeEntity Details", group =>
            {
                ChargingVendorAccountNumber = group.Add(new VocabularyKey(nameof(ChargingVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargingChargeVendorGroupId = group.Add(new VocabularyKey(nameof(ChargingChargeVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseDocumentCurrencyCode = group.Add(new VocabularyKey(nameof(PurchaseDocumentCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseChargeCode = group.Add(new VocabularyKey(nameof(PurchaseChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeCategory = group.Add(new VocabularyKey(nameof(ChargeCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargePercentage = group.Add(new VocabularyKey(nameof(ChargePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedChargeAmount = group.Add(new VocabularyKey(nameof(FixedChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProportionalChargeAmount = group.Add(new VocabularyKey(nameof(ProportionalChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeAccountingCurrencyCode = group.Add(new VocabularyKey(nameof(ChargeAccountingCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ChargingVendorAccountNumber { get; private set; }
public VocabularyKey ChargingChargeVendorGroupId { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey PurchaseDocumentCurrencyCode { get; private set; }
public VocabularyKey PurchaseChargeCode { get; private set; }
public VocabularyKey ChargeCategory { get; private set; }
public VocabularyKey ChargePercentage { get; private set; }
public VocabularyKey FixedChargeAmount { get; private set; }
public VocabularyKey ProportionalChargeAmount { get; private set; }
public VocabularyKey Value { get; private set; }
public VocabularyKey ChargeAccountingCurrencyCode { get; private set; }
public VocabularyKey SalesTaxGroupCode { get; private set; }
public VocabularyKey AccountCode { get; private set; }
public VocabularyKey AccountRelation { get; private set; }


    }
}