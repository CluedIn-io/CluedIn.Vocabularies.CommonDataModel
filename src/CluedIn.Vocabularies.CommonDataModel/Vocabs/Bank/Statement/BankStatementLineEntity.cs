using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankStatementLineEntityVocabulary : SimpleVocabulary
    {
        public BankStatementLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankStatementLineEntity";
            KeyPrefix = "commonDataModel.bankstatementlineentity";
            KeySeparator = ".";
            Grouping = "/BankStatementLineEntity";

            AddGroup("Common Data Model BankStatementLineEntity Details", group =>
            {
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountServicerReference = group.Add(new VocabularyKey(nameof(AccountServicerReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AdditionalEntryInformation = group.Add(new VocabularyKey(nameof(AdditionalEntryInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountCreditDebitIndicator = group.Add(new VocabularyKey(nameof(AmountCreditDebitIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStatementCounterCurrency = group.Add(new VocabularyKey(nameof(BankStatementCounterCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStatementCounterCurrencyAmount = group.Add(new VocabularyKey(nameof(BankStatementCounterCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankDocumentNumber = group.Add(new VocabularyKey(nameof(BankDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStatementCounterExchangeRate = group.Add(new VocabularyKey(nameof(BankStatementCounterExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BookingDateTime = group.Add(new VocabularyKey(nameof(BookingDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EntryReference = group.Add(new VocabularyKey(nameof(EntryReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStatementLineStatus = group.Add(new VocabularyKey(nameof(BankStatementLineStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProprietaryBankTransactionCode = group.Add(new VocabularyKey(nameof(ProprietaryBankTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReferenceNumber = group.Add(new VocabularyKey(nameof(ReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RelatedBankName = group.Add(new VocabularyKey(nameof(RelatedBankName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RelatedBankAccount = group.Add(new VocabularyKey(nameof(RelatedBankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReversalIndicator = group.Add(new VocabularyKey(nameof(ReversalIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TradingParty = group.Add(new VocabularyKey(nameof(TradingParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStmtISOAccountStatement = group.Add(new VocabularyKey(nameof(BankStmtISOAccountStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportEntryTradingPartyName = group.Add(new VocabularyKey(nameof(ReportEntryTradingPartyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportEntryTradingPartyId = group.Add(new VocabularyKey(nameof(ReportEntryTradingPartyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStmtISOReportEntry = group.Add(new VocabularyKey(nameof(BankStmtISOReportEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountLineAmount = group.Add(new VocabularyKey(nameof(AmountLineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountActualDate = group.Add(new VocabularyKey(nameof(AmountActualDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountNumberOfDays = group.Add(new VocabularyKey(nameof(AmountNumberOfDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StatementLineLineNum = group.Add(new VocabularyKey(nameof(StatementLineLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountLineNum = group.Add(new VocabularyKey(nameof(AmountLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentLineNum = group.Add(new VocabularyKey(nameof(DocumentLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StatementLineNum = group.Add(new VocabularyKey(nameof(StatementLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStatementInstructedCurrency = group.Add(new VocabularyKey(nameof(BankStatementInstructedCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStatementInstructedCurrencyAmt = group.Add(new VocabularyKey(nameof(BankStatementInstructedCurrencyAmt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStatementInstructedExchangeRate = group.Add(new VocabularyKey(nameof(BankStatementInstructedExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditorReferenceInformation = group.Add(new VocabularyKey(nameof(CreditorReferenceInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LineAmount { get; private set; }
public VocabularyKey AccountServicerReference { get; private set; }
public VocabularyKey AdditionalEntryInformation { get; private set; }
public VocabularyKey AmountCreditDebitIndicator { get; private set; }
public VocabularyKey BankStatementCounterCurrency { get; private set; }
public VocabularyKey BankStatementCounterCurrencyAmount { get; private set; }
public VocabularyKey BankDocumentNumber { get; private set; }
public VocabularyKey BankStatementCounterExchangeRate { get; private set; }
public VocabularyKey BookingDateTime { get; private set; }
public VocabularyKey EntryReference { get; private set; }
public VocabularyKey BankStatementLineStatus { get; private set; }
public VocabularyKey ProprietaryBankTransactionCode { get; private set; }
public VocabularyKey ReferenceNumber { get; private set; }
public VocabularyKey RelatedBankName { get; private set; }
public VocabularyKey RelatedBankAccount { get; private set; }
public VocabularyKey ReversalIndicator { get; private set; }
public VocabularyKey TradingParty { get; private set; }
public VocabularyKey BankStmtISOAccountStatement { get; private set; }
public VocabularyKey ReportEntryTradingPartyName { get; private set; }
public VocabularyKey ReportEntryTradingPartyId { get; private set; }
public VocabularyKey BankStmtISOReportEntry { get; private set; }
public VocabularyKey AmountLineAmount { get; private set; }
public VocabularyKey AmountActualDate { get; private set; }
public VocabularyKey AmountNumberOfDays { get; private set; }
public VocabularyKey StatementLineLineNum { get; private set; }
public VocabularyKey AmountLineNum { get; private set; }
public VocabularyKey DocumentLineNum { get; private set; }
public VocabularyKey StatementLineNum { get; private set; }
public VocabularyKey BankStatementInstructedCurrency { get; private set; }
public VocabularyKey BankStatementInstructedCurrencyAmt { get; private set; }
public VocabularyKey BankStatementInstructedExchangeRate { get; private set; }
public VocabularyKey CreditorReferenceInformation { get; private set; }


    }
}