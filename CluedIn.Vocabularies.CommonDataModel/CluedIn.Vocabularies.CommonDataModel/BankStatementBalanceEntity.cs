using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankStatementBalanceEntityVocabulary : SimpleVocabulary
    {
        public BankStatementBalanceEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankStatementBalanceEntity";
            KeyPrefix = "commonDataModel.bankstatementbalanceentity";
            KeySeparator = ".";
            Grouping = "/BankStatementBalanceEntity";

            AddGroup("Common Data Model BankStatementBalanceEntity Details", group =>
            {
                BalanceLineNum = group.Add(new VocabularyKey(nameof(BalanceLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AvailibilityLineNum = group.Add(new VocabularyKey(nameof(AvailibilityLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BalanceType = group.Add(new VocabularyKey(nameof(BalanceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BalanceIndicator = group.Add(new VocabularyKey(nameof(BalanceIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BalanceAmount = group.Add(new VocabularyKey(nameof(BalanceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BalanceItemCount = group.Add(new VocabularyKey(nameof(BalanceItemCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BalanceTypeCode = group.Add(new VocabularyKey(nameof(BalanceTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BalanceFundsType = group.Add(new VocabularyKey(nameof(BalanceFundsType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStmtISOAccountStatement = group.Add(new VocabularyKey(nameof(BankStmtISOAccountStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStmtISOCashBalance = group.Add(new VocabularyKey(nameof(BankStmtISOCashBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AvailibilityAmount = group.Add(new VocabularyKey(nameof(AvailibilityAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AvailibilityActualDate = group.Add(new VocabularyKey(nameof(AvailibilityActualDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AvailibilityNumberOfDays = group.Add(new VocabularyKey(nameof(AvailibilityNumberOfDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StatementLineNum = group.Add(new VocabularyKey(nameof(StatementLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentLineNum = group.Add(new VocabularyKey(nameof(DocumentLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BalanceLineNum { get; private set; }
public VocabularyKey AvailibilityLineNum { get; private set; }
public VocabularyKey BalanceType { get; private set; }
public VocabularyKey BalanceIndicator { get; private set; }
public VocabularyKey BalanceAmount { get; private set; }
public VocabularyKey BalanceItemCount { get; private set; }
public VocabularyKey BalanceTypeCode { get; private set; }
public VocabularyKey BalanceFundsType { get; private set; }
public VocabularyKey BankStmtISOAccountStatement { get; private set; }
public VocabularyKey BankStmtISOCashBalance { get; private set; }
public VocabularyKey AvailibilityAmount { get; private set; }
public VocabularyKey AvailibilityActualDate { get; private set; }
public VocabularyKey AvailibilityNumberOfDays { get; private set; }
public VocabularyKey StatementLineNum { get; private set; }
public VocabularyKey DocumentLineNum { get; private set; }


    }
}