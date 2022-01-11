using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankCodaAccountStatementEntityVocabulary : SimpleVocabulary
    {
        public BankCodaAccountStatementEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankCodaAccountStatementEntity";
            KeyPrefix = "commonDataModel.bankcodaaccountstatemententity";
            KeySeparator = ".";
            Grouping = "/BankCodaAccountStatementEntity";

            AddGroup("Common Data Model BankCodaAccountStatementEntity Details", group =>
            {
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStatementDate = group.Add(new VocabularyKey(nameof(BankStatementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankStatement = group.Add(new VocabularyKey(nameof(BankStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OpeningBalance = group.Add(new VocabularyKey(nameof(OpeningBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankTransactionType = group.Add(new VocabularyKey(nameof(BankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransferDetails = group.Add(new VocabularyKey(nameof(TransferDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndingBalance = group.Add(new VocabularyKey(nameof(EndingBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClosedDate = group.Add(new VocabularyKey(nameof(ClosedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Reconciled = group.Add(new VocabularyKey(nameof(Reconciled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalAmount = group.Add(new VocabularyKey(nameof(TotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsMovementLinesUpdateDelayed = group.Add(new VocabularyKey(nameof(IsMovementLinesUpdateDelayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BankAccount { get; private set; }
public VocabularyKey BankStatementDate { get; private set; }
public VocabularyKey BankStatement { get; private set; }
public VocabularyKey OpeningBalance { get; private set; }
public VocabularyKey BankTransactionType { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey TransferDetails { get; private set; }
public VocabularyKey EndingBalance { get; private set; }
public VocabularyKey ClosedDate { get; private set; }
public VocabularyKey Reconciled { get; private set; }
public VocabularyKey TotalAmount { get; private set; }
public VocabularyKey IsMovementLinesUpdateDelayed { get; private set; }


    }
}