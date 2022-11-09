using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxOnNaturalResourcesEntityVocabulary : SimpleVocabulary
    {
        public TaxOnNaturalResourcesEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxOnNaturalResourcesEntity";
            KeyPrefix = "commonDataModel.taxonnaturalresourcesentity";
            KeySeparator = ".";
            Grouping = "/TaxOnNaturalResourcesEntity";

            AddGroup("Common Data Model TaxOnNaturalResourcesEntity Details", group =>
            {
                BOMLine = group.Add(new VocabularyKey(nameof(BOMLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionNumber = group.Add(new VocabularyKey(nameof(DimensionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventTransId = group.Add(new VocabularyKey(nameof(InventTransId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventTransTypeReference = group.Add(new VocabularyKey(nameof(InventTransTypeReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemQty = group.Add(new VocabularyKey(nameof(ItemQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NRTaxGroup = group.Add(new VocabularyKey(nameof(NRTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackingMaterialCode = group.Add(new VocabularyKey(nameof(PackingMaterialCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackingUnit = group.Add(new VocabularyKey(nameof(PackingUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackingQty = group.Add(new VocabularyKey(nameof(PackingQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackingUnitQty = group.Add(new VocabularyKey(nameof(PackingUnitQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackingUnitWeight = group.Add(new VocabularyKey(nameof(PackingUnitWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackingWeight = group.Add(new VocabularyKey(nameof(PackingWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxAmount = group.Add(new VocabularyKey(nameof(TaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxBaseAmount = group.Add(new VocabularyKey(nameof(TaxBaseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxValue = group.Add(new VocabularyKey(nameof(TaxValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransType = group.Add(new VocabularyKey(nameof(TransType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Number = group.Add(new VocabularyKey(nameof(Number), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReferenceTableID = group.Add(new VocabularyKey(nameof(ReferenceTableID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransRecIdReference = group.Add(new VocabularyKey(nameof(TransRecIdReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BOMLine { get; private set; }
public VocabularyKey DimensionNumber { get; private set; }
public VocabularyKey InventTransId { get; private set; }
public VocabularyKey Invoice { get; private set; }
public VocabularyKey InventTransTypeReference { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ItemQty { get; private set; }
public VocabularyKey NRTaxGroup { get; private set; }
public VocabularyKey PackingMaterialCode { get; private set; }
public VocabularyKey PackingUnit { get; private set; }
public VocabularyKey PackingQty { get; private set; }
public VocabularyKey PackingUnitQty { get; private set; }
public VocabularyKey PackingUnitWeight { get; private set; }
public VocabularyKey PackingWeight { get; private set; }
public VocabularyKey SalesTaxGroup { get; private set; }
public VocabularyKey TaxAmount { get; private set; }
public VocabularyKey TaxBaseAmount { get; private set; }
public VocabularyKey TaxCode { get; private set; }
public VocabularyKey TaxValue { get; private set; }
public VocabularyKey TransDate { get; private set; }
public VocabularyKey TransType { get; private set; }
public VocabularyKey Voucher { get; private set; }
public VocabularyKey LineId { get; private set; }
public VocabularyKey Number { get; private set; }
public VocabularyKey ReferenceTableID { get; private set; }
public VocabularyKey TransRecIdReference { get; private set; }


    }
}