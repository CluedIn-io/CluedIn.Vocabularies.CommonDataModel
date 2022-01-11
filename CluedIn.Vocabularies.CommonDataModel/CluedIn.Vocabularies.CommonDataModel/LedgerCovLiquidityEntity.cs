using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerCovLiquidityEntityVocabulary : SimpleVocabulary
    {
        public LedgerCovLiquidityEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerCovLiquidityEntity";
            KeyPrefix = "commonDataModel.ledgercovliquidityentity";
            KeySeparator = ".";
            Grouping = "/LedgerCovLiquidityEntity";

            AddGroup("Common Data Model LedgerCovLiquidityEntity Details", group =>
            {
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransTableId = group.Add(new VocabularyKey(nameof(TransTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransRecId = group.Add(new VocabularyKey(nameof(TransRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountMST = group.Add(new VocabularyKey(nameof(AmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnterpriseCurrencyAmount = group.Add(new VocabularyKey(nameof(EnterpriseCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankAccountCurrencyAmount = group.Add(new VocabularyKey(nameof(BankAccountCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InflowOutflow = group.Add(new VocabularyKey(nameof(InflowOutflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingCurrency = group.Add(new VocabularyKey(nameof(AccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentAccountName = group.Add(new VocabularyKey(nameof(DocumentAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentAccountNumber = group.Add(new VocabularyKey(nameof(DocumentAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentDueDate = group.Add(new VocabularyKey(nameof(DocumentDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentTransDate = group.Add(new VocabularyKey(nameof(DocumentTransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentType = group.Add(new VocabularyKey(nameof(DocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentTypeENUSOnly = group.Add(new VocabularyKey(nameof(DocumentTypeENUSOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentVoucher = group.Add(new VocabularyKey(nameof(DocumentVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnterpriseCurrencyInflowAmount = group.Add(new VocabularyKey(nameof(EnterpriseCurrencyInflowAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnterpriseCurrencyOutflowAmount = group.Add(new VocabularyKey(nameof(EnterpriseCurrencyOutflowAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnterpriseCurrencyBalanceAmount = group.Add(new VocabularyKey(nameof(EnterpriseCurrencyBalanceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionCurrencyInflowAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyInflowAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionCurrencyOutflowAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyOutflowAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionCurrencyBalanceAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyBalanceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingCurrencyInflowAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyInflowAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingCurrencyOutflowAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyOutflowAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingCurrencyBalanceAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyBalanceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsBeginningBalance = group.Add(new VocabularyKey(nameof(IsBeginningBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey TransDate { get; private set; }
public VocabularyKey MainAccountId { get; private set; }
public VocabularyKey BankAccount { get; private set; }
public VocabularyKey TransTableId { get; private set; }
public VocabularyKey TransRecId { get; private set; }
public VocabularyKey Amount { get; private set; }
public VocabularyKey AmountMST { get; private set; }
public VocabularyKey EnterpriseCurrencyAmount { get; private set; }
public VocabularyKey BankAccountCurrencyAmount { get; private set; }
public VocabularyKey InflowOutflow { get; private set; }
public VocabularyKey AccountingCurrency { get; private set; }
public VocabularyKey DocumentAccountName { get; private set; }
public VocabularyKey DocumentAccountNumber { get; private set; }
public VocabularyKey DocumentDueDate { get; private set; }
public VocabularyKey DocumentNumber { get; private set; }
public VocabularyKey DocumentTransDate { get; private set; }
public VocabularyKey DocumentType { get; private set; }
public VocabularyKey DocumentTypeENUSOnly { get; private set; }
public VocabularyKey DocumentVoucher { get; private set; }
public VocabularyKey EnterpriseCurrencyInflowAmount { get; private set; }
public VocabularyKey EnterpriseCurrencyOutflowAmount { get; private set; }
public VocabularyKey EnterpriseCurrencyBalanceAmount { get; private set; }
public VocabularyKey TransactionCurrencyInflowAmount { get; private set; }
public VocabularyKey TransactionCurrencyOutflowAmount { get; private set; }
public VocabularyKey TransactionCurrencyBalanceAmount { get; private set; }
public VocabularyKey AccountingCurrencyInflowAmount { get; private set; }
public VocabularyKey AccountingCurrencyOutflowAmount { get; private set; }
public VocabularyKey AccountingCurrencyBalanceAmount { get; private set; }
public VocabularyKey IsBeginningBalance { get; private set; }


    }
}