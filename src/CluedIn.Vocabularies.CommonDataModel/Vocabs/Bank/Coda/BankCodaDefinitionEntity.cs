using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankCodaDefinitionEntityVocabulary : SimpleVocabulary
    {
        public BankCodaDefinitionEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankCodaDefinitionEntity";
            KeyPrefix = "commonDataModel.bankcodadefinitionentity";
            KeySeparator = ".";
            Grouping = "/BankCodaDefinitionEntity";

            AddGroup("Common Data Model BankCodaDefinitionEntity Details", group =>
            {
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GlobalizationCODA = group.Add(new VocabularyKey(nameof(GlobalizationCODA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Transaction = group.Add(new VocabularyKey(nameof(Transaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionCategory = group.Add(new VocabularyKey(nameof(TransactionCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionGroup = group.Add(new VocabularyKey(nameof(TransactionGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BankAccount { get; private set; }
public VocabularyKey AccountType { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey GlobalizationCODA { get; private set; }
public VocabularyKey Account { get; private set; }
public VocabularyKey SalesTaxGroup { get; private set; }
public VocabularyKey ItemSalesTaxGroup { get; private set; }
public VocabularyKey Transaction { get; private set; }
public VocabularyKey TransactionCategory { get; private set; }
public VocabularyKey TransactionGroup { get; private set; }
public VocabularyKey AccountDisplayValue { get; private set; }


    }
}