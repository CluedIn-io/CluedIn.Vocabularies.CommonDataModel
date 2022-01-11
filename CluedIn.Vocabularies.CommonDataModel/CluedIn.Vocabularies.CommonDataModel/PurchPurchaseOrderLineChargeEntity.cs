using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseOrderLineChargeEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseOrderLineChargeEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseOrderLineChargeEntity";
            KeyPrefix = "commonDataModel.purchpurchaseorderlinechargeentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseOrderLineChargeEntity";

            AddGroup("Common Data Model PurchPurchaseOrderLineChargeEntity Details", group =>
            {
                ChargeCategory = group.Add(new VocabularyKey(nameof(ChargeCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseChargeCode = group.Add(new VocabularyKey(nameof(PurchaseChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeDescription = group.Add(new VocabularyKey(nameof(ChargeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeAccountingCurrencyCode = group.Add(new VocabularyKey(nameof(ChargeAccountingCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargePercentage = group.Add(new VocabularyKey(nameof(ChargePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedChargeAmount = group.Add(new VocabularyKey(nameof(FixedChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntercompanyChargePercentage = group.Add(new VocabularyKey(nameof(IntercompanyChargePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeLineNumber = group.Add(new VocabularyKey(nameof(ChargeLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProportionalChargeAmount = group.Add(new VocabularyKey(nameof(ProportionalChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseOrderLineNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalChargeAmount = group.Add(new VocabularyKey(nameof(ExternalChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitChargeAmount = group.Add(new VocabularyKey(nameof(UnitChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentTableId = group.Add(new VocabularyKey(nameof(DocumentTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentRecId = group.Add(new VocabularyKey(nameof(DocumentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentStatus = group.Add(new VocabularyKey(nameof(DocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompanyCharge = group.Add(new VocabularyKey(nameof(IsIntercompanyCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ChargeCategory { get; private set; }
public VocabularyKey PurchaseChargeCode { get; private set; }
public VocabularyKey ChargeDescription { get; private set; }
public VocabularyKey ChargeAccountingCurrencyCode { get; private set; }
public VocabularyKey ChargePercentage { get; private set; }
public VocabularyKey FixedChargeAmount { get; private set; }
public VocabularyKey IntercompanyChargePercentage { get; private set; }
public VocabularyKey ChargeLineNumber { get; private set; }
public VocabularyKey ProportionalChargeAmount { get; private set; }
public VocabularyKey PurchaseOrderNumber { get; private set; }
public VocabularyKey PurchaseOrderLineNumber { get; private set; }
public VocabularyKey SalesTaxGroupCode { get; private set; }
public VocabularyKey SalesTaxItemGroupCode { get; private set; }
public VocabularyKey ExternalChargeAmount { get; private set; }
public VocabularyKey UnitChargeAmount { get; private set; }
public VocabularyKey DocumentTableId { get; private set; }
public VocabularyKey DocumentRecId { get; private set; }
public VocabularyKey DocumentStatus { get; private set; }
public VocabularyKey IsIntercompanyCharge { get; private set; }


    }
}