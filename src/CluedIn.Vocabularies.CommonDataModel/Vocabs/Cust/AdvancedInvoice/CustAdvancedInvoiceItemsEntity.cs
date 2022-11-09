using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustAdvancedInvoiceItemsEntityVocabulary : SimpleVocabulary
    {
        public CustAdvancedInvoiceItemsEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustAdvancedInvoiceItemsEntity";
            KeyPrefix = "commonDataModel.custadvancedinvoiceitemsentity";
            KeySeparator = ".";
            Grouping = "/CustAdvancedInvoiceItemsEntity";

            AddGroup("Common Data Model CustAdvancedInvoiceItemsEntity Details", group =>
            {
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalItemId = group.Add(new VocabularyKey(nameof(OriginalItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalItemName = group.Add(new VocabularyKey(nameof(OriginalItemName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalLineAmountExclTax = group.Add(new VocabularyKey(nameof(OriginalLineAmountExclTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalLineAmountInclTax = group.Add(new VocabularyKey(nameof(OriginalLineAmountInclTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalQty = group.Add(new VocabularyKey(nameof(OriginalQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalSalesPriceExclTax = group.Add(new VocabularyKey(nameof(OriginalSalesPriceExclTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalSalesUnit = group.Add(new VocabularyKey(nameof(OriginalSalesUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalTaxAmount = group.Add(new VocabularyKey(nameof(OriginalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalTaxCode = group.Add(new VocabularyKey(nameof(OriginalTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentRecId = group.Add(new VocabularyKey(nameof(ParentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefTableId = group.Add(new VocabularyKey(nameof(RefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesId = group.Add(new VocabularyKey(nameof(SalesId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LineNum { get; private set; }
public VocabularyKey OriginalItemId { get; private set; }
public VocabularyKey OriginalItemName { get; private set; }
public VocabularyKey OriginalLineAmountExclTax { get; private set; }
public VocabularyKey OriginalLineAmountInclTax { get; private set; }
public VocabularyKey OriginalQty { get; private set; }
public VocabularyKey OriginalSalesPriceExclTax { get; private set; }
public VocabularyKey OriginalSalesUnit { get; private set; }
public VocabularyKey OriginalTaxAmount { get; private set; }
public VocabularyKey OriginalTaxCode { get; private set; }
public VocabularyKey ParentRecId { get; private set; }
public VocabularyKey RefRecId { get; private set; }
public VocabularyKey RefTableId { get; private set; }
public VocabularyKey SalesId { get; private set; }


    }
}