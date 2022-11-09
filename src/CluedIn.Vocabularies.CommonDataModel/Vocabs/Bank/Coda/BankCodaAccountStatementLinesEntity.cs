using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankCodaAccountStatementLinesEntityVocabulary : SimpleVocabulary
    {
        public BankCodaAccountStatementLinesEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankCodaAccountStatementLinesEntity";
            KeyPrefix = "commonDataModel.bankcodaaccountstatementlinesentity";
            KeySeparator = ".";
            Grouping = "/BankCodaAccountStatementLinesEntity";

            AddGroup("Common Data Model BankCodaAccountStatementLinesEntity Details", group =>
            {
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStatement = group.Add(new VocabularyKey(nameof(BankStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountInAccountingCurrency = group.Add(new VocabularyKey(nameof(AmountInAccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountImported = group.Add(new VocabularyKey(nameof(AmountImported), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankReferenceNumber = group.Add(new VocabularyKey(nameof(BankReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountLinked = group.Add(new VocabularyKey(nameof(CashDiscountLinked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementType = group.Add(new VocabularyKey(nameof(SettlementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerReference = group.Add(new VocabularyKey(nameof(CustomerReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Detail = group.Add(new VocabularyKey(nameof(Detail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalBankReferenceNumber = group.Add(new VocabularyKey(nameof(ExternalBankReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GlobalizationCODA = group.Add(new VocabularyKey(nameof(GlobalizationCODA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HasProcessErrors = group.Add(new VocabularyKey(nameof(HasProcessErrors), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceNumber = group.Add(new VocabularyKey(nameof(InvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Message = group.Add(new VocabularyKey(nameof(Message), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MessageType = group.Add(new VocabularyKey(nameof(MessageType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OppositePartyAddress = group.Add(new VocabularyKey(nameof(OppositePartyAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankAccountNumber = group.Add(new VocabularyKey(nameof(BankAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OppositePartyCity = group.Add(new VocabularyKey(nameof(OppositePartyCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerOrVendorAccountNumber = group.Add(new VocabularyKey(nameof(CustomerOrVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OppositePartyInternalCodes = group.Add(new VocabularyKey(nameof(OppositePartyInternalCodes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OppositePartyName = group.Add(new VocabularyKey(nameof(OppositePartyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Completed = group.Add(new VocabularyKey(nameof(Completed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStatementDate = group.Add(new VocabularyKey(nameof(BankStatementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AssociatedPaymentAttachment = group.Add(new VocabularyKey(nameof(AssociatedPaymentAttachment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Transaction = group.Add(new VocabularyKey(nameof(Transaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionCategory = group.Add(new VocabularyKey(nameof(TransactionCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionGroup = group.Add(new VocabularyKey(nameof(TransactionGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Date1 = group.Add(new VocabularyKey(nameof(Date1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GUID = group.Add(new VocabularyKey(nameof(GUID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankCodaAccountStatementLines1_LineId = group.Add(new VocabularyKey(nameof(BankCodaAccountStatementLines1_LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GlobalisationId = group.Add(new VocabularyKey(nameof(GlobalisationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BankAccount { get; private set; }
public VocabularyKey BankStatement { get; private set; }
public VocabularyKey AccountType { get; private set; }
public VocabularyKey AmountInAccountingCurrency { get; private set; }
public VocabularyKey AmountImported { get; private set; }
public VocabularyKey Amount { get; private set; }
public VocabularyKey BankReferenceNumber { get; private set; }
public VocabularyKey CashDiscountLinked { get; private set; }
public VocabularyKey SettlementType { get; private set; }
public VocabularyKey CustomerReference { get; private set; }
public VocabularyKey Date { get; private set; }
public VocabularyKey Detail { get; private set; }
public VocabularyKey ExternalBankReferenceNumber { get; private set; }
public VocabularyKey GlobalizationCODA { get; private set; }
public VocabularyKey HasProcessErrors { get; private set; }
public VocabularyKey InvoiceNumber { get; private set; }
public VocabularyKey Account { get; private set; }
public VocabularyKey Note { get; private set; }
public VocabularyKey Message { get; private set; }
public VocabularyKey MessageType { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey OppositePartyAddress { get; private set; }
public VocabularyKey BankAccountNumber { get; private set; }
public VocabularyKey OppositePartyCity { get; private set; }
public VocabularyKey CustomerOrVendorAccountNumber { get; private set; }
public VocabularyKey OppositePartyInternalCodes { get; private set; }
public VocabularyKey OppositePartyName { get; private set; }
public VocabularyKey Completed { get; private set; }
public VocabularyKey Reference { get; private set; }
public VocabularyKey SequenceNumber { get; private set; }
public VocabularyKey BankStatementDate { get; private set; }
public VocabularyKey AssociatedPaymentAttachment { get; private set; }
public VocabularyKey SalesTaxGroup { get; private set; }
public VocabularyKey ItemSalesTaxGroup { get; private set; }
public VocabularyKey Transaction { get; private set; }
public VocabularyKey TransactionCategory { get; private set; }
public VocabularyKey TransactionGroup { get; private set; }
public VocabularyKey TransactionType { get; private set; }
public VocabularyKey Date1 { get; private set; }
public VocabularyKey GUID { get; private set; }
public VocabularyKey BankCodaAccountStatementLines1_LineId { get; private set; }
public VocabularyKey AccountDisplayValue { get; private set; }
public VocabularyKey GlobalisationId { get; private set; }


    }
}