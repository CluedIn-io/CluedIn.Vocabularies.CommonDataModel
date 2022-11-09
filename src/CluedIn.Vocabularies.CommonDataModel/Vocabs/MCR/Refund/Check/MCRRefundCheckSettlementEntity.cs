using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRRefundCheckSettlementEntityVocabulary : SimpleVocabulary
    {
        public MCRRefundCheckSettlementEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRRefundCheckSettlementEntity";
            KeyPrefix = "commonDataModel.mcrrefundchecksettlemententity";
            KeySeparator = ".";
            Grouping = "/MCRRefundCheckSettlementEntity";

            AddGroup("Common Data Model MCRRefundCheckSettlementEntity Details", group =>
            {
                TransactionBatchId = group.Add(new VocabularyKey(nameof(TransactionBatchId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementStatus = group.Add(new VocabularyKey(nameof(SettlementStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementAmount = group.Add(new VocabularyKey(nameof(SettlementAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementDateTime = group.Add(new VocabularyKey(nameof(SettlementDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesId = group.Add(new VocabularyKey(nameof(SalesId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefundCheckAuthorizationLineNumber = group.Add(new VocabularyKey(nameof(RefundCheckAuthorizationLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerPaymentLineNumber = group.Add(new VocabularyKey(nameof(CustomerPaymentLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerJournalNumber = group.Add(new VocabularyKey(nameof(LedgerJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerJournalVoucher = group.Add(new VocabularyKey(nameof(LedgerJournalVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerJournalTransationLineNumber = group.Add(new VocabularyKey(nameof(LedgerJournalTransationLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TransactionBatchId { get; private set; }
public VocabularyKey SettlementStatus { get; private set; }
public VocabularyKey SettlementAmount { get; private set; }
public VocabularyKey SettlementDateTime { get; private set; }
public VocabularyKey SalesId { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey RefundCheckAuthorizationLineNumber { get; private set; }
public VocabularyKey CustomerPaymentLineNumber { get; private set; }
public VocabularyKey LedgerJournalNumber { get; private set; }
public VocabularyKey LedgerJournalVoucher { get; private set; }
public VocabularyKey LedgerJournalTransationLineNumber { get; private set; }


    }
}