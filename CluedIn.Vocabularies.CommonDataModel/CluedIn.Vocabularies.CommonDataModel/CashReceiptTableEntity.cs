using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CashReceiptTableEntityVocabulary : SimpleVocabulary
    {
        public CashReceiptTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model CashReceiptTableEntity";
            KeyPrefix = "commonDataModel.cashreceipttableentity";
            KeySeparator = ".";
            Grouping = "/CashReceiptTableEntity";

            AddGroup("Common Data Model CashReceiptTableEntity Details", group =>
            {
                AcquisitionDate = group.Add(new VocabularyKey(nameof(AcquisitionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BatchNumber = group.Add(new VocabularyKey(nameof(BatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClosingDate = group.Add(new VocabularyKey(nameof(ClosingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Format = group.Add(new VocabularyKey(nameof(Format), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
From = group.Add(new VocabularyKey(nameof(From), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
To = group.Add(new VocabularyKey(nameof(To), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionTo = group.Add(new VocabularyKey(nameof(TransactionTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionFrom = group.Add(new VocabularyKey(nameof(TransactionFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionCurrency = group.Add(new VocabularyKey(nameof(TransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionAmount = group.Add(new VocabularyKey(nameof(TransactionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerName = group.Add(new VocabularyKey(nameof(WorkerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AcquisitionDate { get; private set; }
public VocabularyKey BatchNumber { get; private set; }
public VocabularyKey ClosingDate { get; private set; }
public VocabularyKey Format { get; private set; }
public VocabularyKey From { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey To { get; private set; }
public VocabularyKey TransactionType { get; private set; }
public VocabularyKey TransactionDate { get; private set; }
public VocabularyKey TransactionTo { get; private set; }
public VocabularyKey TransactionFrom { get; private set; }
public VocabularyKey TransactionCurrency { get; private set; }
public VocabularyKey TransactionAmount { get; private set; }
public VocabularyKey WorkerPersonnelNumber { get; private set; }
public VocabularyKey WorkerName { get; private set; }
public VocabularyKey Worker { get; private set; }


    }
}