using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionIncomeExpenseLineEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionIncomeExpenseLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTransactionIncomeExpenseLineEntity";
            KeyPrefix = "commonDataModel.retailtransactionincomeexpenselineentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionIncomeExpenseLineEntity";

            AddGroup("Common Data Model RetailTransactionIncomeExpenseLineEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceiptNumber = group.Add(new VocabularyKey(nameof(ReceiptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionStatus = group.Add(new VocabularyKey(nameof(TransactionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionTime = group.Add(new VocabularyKey(nameof(TransactionTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailChannelTableOMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountType { get; private set; }
public VocabularyKey Amount { get; private set; }
public VocabularyKey Channel { get; private set; }
public VocabularyKey AccountNumber { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey ReceiptNumber { get; private set; }
public VocabularyKey Terminal { get; private set; }
public VocabularyKey TransactionNumber { get; private set; }
public VocabularyKey TransactionStatus { get; private set; }
public VocabularyKey TransactionDate { get; private set; }
public VocabularyKey TransactionTime { get; private set; }
public VocabularyKey RetailChannelTableOMOperatingUnitID { get; private set; }
public VocabularyKey OperatingUnitNumber { get; private set; }
public VocabularyKey StoreNumber { get; private set; }


    }
}