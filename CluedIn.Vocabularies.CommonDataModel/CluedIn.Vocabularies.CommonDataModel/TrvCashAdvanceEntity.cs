using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvCashAdvanceEntityVocabulary : SimpleVocabulary
    {
        public TrvCashAdvanceEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvCashAdvanceEntity";
            KeyPrefix = "commonDataModel.trvcashadvanceentity";
            KeySeparator = ".";
            Grouping = "/TrvCashAdvanceEntity";

            AddGroup("Common Data Model TrvCashAdvanceEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Balance = group.Add(new VocabularyKey(nameof(Balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountInTransactionCurrency = group.Add(new VocabularyKey(nameof(AmountInTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashAdvanceNumber = group.Add(new VocabularyKey(nameof(CashAdvanceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashAdvanceStatus = group.Add(new VocabularyKey(nameof(CashAdvanceStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaidAmount = group.Add(new VocabularyKey(nameof(PaidAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaidAmountMST = group.Add(new VocabularyKey(nameof(PaidAmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaidDate = group.Add(new VocabularyKey(nameof(PaidDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayingWorker = group.Add(new VocabularyKey(nameof(PayingWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestAmountMST = group.Add(new VocabularyKey(nameof(RequestAmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedAmount = group.Add(new VocabularyKey(nameof(RequestedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedDate = group.Add(new VocabularyKey(nameof(RequestedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Employee = group.Add(new VocabularyKey(nameof(Employee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayingWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(PayingWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestingWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(RequestingWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountType { get; private set; }
public VocabularyKey MainAccount { get; private set; }
public VocabularyKey Balance { get; private set; }
public VocabularyKey Amount { get; private set; }
public VocabularyKey AmountInTransactionCurrency { get; private set; }
public VocabularyKey CashAdvanceNumber { get; private set; }
public VocabularyKey CashAdvanceStatus { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey Dimension { get; private set; }
public VocabularyKey Location { get; private set; }
public VocabularyKey ExchangeRate { get; private set; }
public VocabularyKey Note { get; private set; }
public VocabularyKey PaidAmount { get; private set; }
public VocabularyKey PaidAmountMST { get; private set; }
public VocabularyKey PaidDate { get; private set; }
public VocabularyKey PayingWorker { get; private set; }
public VocabularyKey Purpose { get; private set; }
public VocabularyKey RequestAmountMST { get; private set; }
public VocabularyKey RequestedAmount { get; private set; }
public VocabularyKey RequestedDate { get; private set; }
public VocabularyKey Employee { get; private set; }
public VocabularyKey SalesTaxGroup { get; private set; }
public VocabularyKey ItemSalesTaxGroup { get; private set; }
public VocabularyKey TransactionDate { get; private set; }
public VocabularyKey Company { get; private set; }
public VocabularyKey PayingWorkerPersonnelNumber { get; private set; }
public VocabularyKey RequestingWorkerPersonnelNumber { get; private set; }
public VocabularyKey DimensionDisplayValue { get; private set; }
public VocabularyKey MainAccountDisplayValue { get; private set; }


    }
}