using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionChargeTaxTransEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionChargeTaxTransEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTransactionChargeTaxTransEntity";
            KeyPrefix = "commonDataModel.retailtransactionchargetaxtransentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionChargeTaxTransEntity";

            AddGroup("Common Data Model RetailTransactionChargeTaxTransEntity Details", group =>
            {
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StoreId = group.Add(new VocabularyKey(nameof(StoreId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TerminalId = group.Add(new VocabularyKey(nameof(TerminalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionId = group.Add(new VocabularyKey(nameof(TransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MarkupLineNumber = group.Add(new VocabularyKey(nameof(MarkupLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SaleLineNumber = group.Add(new VocabularyKey(nameof(SaleLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIncludedInPrice = group.Add(new VocabularyKey(nameof(IsIncludedInPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailChannelTable_OMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTable_OMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsExempt = group.Add(new VocabularyKey(nameof(IsExempt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Channel { get; private set; }
public VocabularyKey StoreId { get; private set; }
public VocabularyKey TerminalId { get; private set; }
public VocabularyKey TransactionId { get; private set; }
public VocabularyKey MarkupLineNumber { get; private set; }
public VocabularyKey SaleLineNumber { get; private set; }
public VocabularyKey Amount { get; private set; }
public VocabularyKey IsIncludedInPrice { get; private set; }
public VocabularyKey TaxCode { get; private set; }
public VocabularyKey RetailChannelTable_OMOperatingUnitID { get; private set; }
public VocabularyKey OperatingUnitNumber { get; private set; }
public VocabularyKey IsExempt { get; private set; }


    }
}